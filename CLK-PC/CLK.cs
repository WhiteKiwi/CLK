using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;
using System.Threading;
using KiwiLibrary;
using System.Drawing;
using System.Net.NetworkInformation;
using Microsoft.Win32;

namespace CLK {
	public partial class CLK : Form {
		// HTTP 통신에 사용 할 CookieAwareWebClient
		CookieAwareWebClient Web;

		// CNSA net Id를 저장할 변수
		string cnsaId;
		// CNSA net Pw를 저장할 변수
		string cnsaPw;
		// Session 값을 저장할 변수
		string session;

		// 내부망 주소를 저장할 변수
		string urlIntraNet;
		// 외부망 주소를 저장할 변수
		string urlExtraNet;
		// 주소를 저장할 변수
		string cnsaUrl;

		// 스레드를 저장할 변수
		Thread keepSession;
		Thread checkIntraNet;

		// 마우스 위치값을 저장할 변수
		Point mousePoint;

		// 화면 모서리를 둥글게 함
		[System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn (
			 int nLeftRect, // x-coordinate of upper-left corner
			 int nTopRect, // y-coordinate of upper-left corner
			 int nRightRect, // x-coordinate of lower-right corner
			 int nBottomRect, // y-coordinate of lower-right corner
			 int nWidthEllipse, // height of ellipse
			 int nHeightEllipse // width of ellipse
		);

		// Program Start - 생성자
		public CLK() {
			InitializeComponent();

			// 화면 모서리를 둥글게 함
			Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 3, 3));
		}

		// 폼에 그림자 생성
		private const int CS_DROPSHADOW = 0x00020000;
		protected override CreateParams CreateParams {
			get {
				CreateParams cp = base.CreateParams;
				cp.ClassStyle |= CS_DROPSHADOW;
				return cp;
			}
		}

		// Program Start - 프로그램이 처음 Load 될 시
		private void SmartWorkers_Load(object sender, EventArgs e) {
			// Session 유지 스레드 생성
			keepSession = new Thread(KeepSession);

			// Tray Icon을 NotifyIcon에 연결
			notifyIcon.ContextMenuStrip = contextMenuStrip;

			// 시작 프로그램에 등록되어 있는지 확인
			string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
			RegistryKey strUpKey = Registry.LocalMachine.OpenSubKey(runKey);
			// 시작 프로그램에 CLK가 있을 경우
			if (strUpKey.GetValue("CLK") != null) {
				startProgramCheck.Checked = true;
			}
		}

		// Thread Code - Session 유지를 위해 실행될 코드
		private void KeepSession() {
			// 무한 반복
			while (true) {
				// CNSA net에서 저장된 Session 받아오기
				string nowSession = Encoding.UTF8.GetString(Web.DownloadData(cnsaUrl + "/login/dupLoginCheck?loginId=" + cnsaId));

				// Session이 저장된 세션과 다르고 저장된 세션이 비어있지 않을 경우 -> 저장된 Session 교체
				if (!session.Equals(nowSession) && !nowSession.Trim().Equals("")) {
					// 저장된 Session 교체
					session = nowSession;

					// CookieAwareWebClient의 Session 초기화 -> CookieContainer 초기화
					Web.CookieContainer = new CookieContainer();

					// Session 저장
					Web.AddCookie(new Uri(urlIntraNet), new Cookie("JSESSIONID", session));
					Web.AddCookie(new Uri(urlExtraNet), new Cookie("JSESSIONID", session));
				}

				// 로그인을 통한 Session 갱신
				Web.UploadValues(cnsaUrl + "/login/userLogin", new NameValueCollection() {
					{ "loginId", cnsaId },
					{ "loginPw", cnsaPw }
				});

				// 10초에 한 번 씩 실행
				Thread.Sleep(10000);
			}
		}

		// Form - 시작 버튼 클릭 시
		private void startButton_Clicked(object sender, EventArgs e) {
			if (inputId.Text.Trim().Equals("")) { // 아이디 입력란이 비어있을 경우
												  // inputId 초기화 후 포커스 맞춤
				inputId.Text = "";
				inputId.Focus();

				// MessageBox 띄움
				MessageBox.Show("아이디를 입력해 주세요.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if (inputPw.Text.Trim().Equals("")) { // 패스워드 입력란이 비어있을 경우
														 // inputPw 초기화 후 포커스 맞춤
				inputPw.Text = "";
				inputPw.Focus();

				// MessageBox 띄움
				MessageBox.Show("패스워드를 입력해 주세요.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				// 네트워크가 연결되어 있는지 확인 (인터넷 연결 여부는 관계없음)
				if (NetworkInterface.GetIsNetworkAvailable()) {
					// CookieAwareWebClient 생성
					Web = new CookieAwareWebClient();

					// CNSA net Id, Pw 저장
					cnsaId = inputId.Text;
					cnsaPw = inputPw.Text;

					if (studentRadioButton.Checked) {   // 학생일 경우
						urlIntraNet = "http://10.1.100.32";
						urlExtraNet = "https://student.cnsa.hs.kr";
					}
					else {    // 선생님 || 교직원 일 경우
						urlIntraNet = "http://10.1.100.31";
						urlExtraNet = "https://school.cnsa.hs.kr";
					}

					// 사용할 큰사넷 주소 초기화
					cnsaUrl = urlExtraNet;
					// 내부망 / 외부망 확인 스레드 생성
					checkIntraNet = new Thread(CheckIntraNet);
					// 내부망 / 외부망 확인 시작
					checkIntraNet.Start();

					// CNSA net에서 Session을 받아옴
					session = Encoding.UTF8.GetString(Web.DownloadData(cnsaUrl + "/login/dupLoginCheck?loginId=" + cnsaId));

					// session이 존재할 경우 (로그인이 되어 있을 경우)
					if (!session.Trim().Equals("")) {
						// session 값을 저장
						Web.AddCookie(new Uri(urlIntraNet), new Cookie("JSESSIONID", session));
						Web.AddCookie(new Uri(urlExtraNet), new Cookie("JSESSIONID", session));

						// 로그인 시도
						string responseData = Encoding.UTF8.GetString(Web.UploadValues(cnsaUrl + "/login/userLogin", new NameValueCollection() {
						{ "loginId", cnsaId },
						{ "loginPw", cnsaPw }
					}));

						// requestData에 특정 문자열이 포함되어 있을 경우 로그인 성공으로 간주
						if (!responseData.Contains("/login/userLogin")) {
							// 현재 창 숨기기
							this.Hide();
							// Tray Icon 표시
							notifyIcon.Visible = true;

							// Session 유지 스레드 생성
							keepSession = new Thread(KeepSession);
							// Session 유지 시작
							keepSession.Start();

							// 알림 띄우기
							notifyIcon.BalloonTipTitle = "Login Keeper";
							notifyIcon.BalloonTipText = "CNSA Login Keeper를 시작합니다.";
							notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
							notifyIcon.ShowBalloonTip(3000);

							// Session 유지 시작 -> openToolStripMenuItem.Text = "사용자 변경" 으로 설정
							reloginToolStripMenuItem.Text = "사용자 변경";
						}
						else {  // 로그인 실패
								// MessageBox 띄움
							MessageBox.Show("로그인 정보가 일치하지 않습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
					else {  // session이 존재하지 않을 경우 (로그인이 되어 있지 않을 경우)
							// MessageBox 띄움
						MessageBox.Show("유지할 데이터가 존재하지 않습니다.\n아이디와 패스워드 또는 현재 로그인 되어있는지를 확인해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else {
					MessageBox.Show("네트워크 연결상태를 확인해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		// Thread Code - 내부망 / 외부망을 결정하기 위해 실행될 코드
		private void CheckIntraNet() {
			CookieAwareWebClient anotherWeb = new CookieAwareWebClient();
			// 연결할 페이지 결정 (내부망/외부망)
			try {
				// CNSA net 내부망에서 Session을 받아옴
				session = Encoding.UTF8.GetString(anotherWeb.DownloadData(urlIntraNet + "/login/dupLoginCheck?loginId=" + cnsaId));
				cnsaUrl = urlIntraNet;
			}
			// WebException이 발생하면 내부망에 연결되어있지 않은 것으로 간주
			catch (WebException) {
				cnsaUrl = urlExtraNet;
			}
		}

		// Form - 사용자 변경 버튼 클릭 시
		private void changeUserButton_Click(object sender, EventArgs e) {
			// changeUserButton을 띄움
			changeUserButton.Enabled = false;

			// inputId, inputPw, startButton 활성화
			inputId.Enabled = true;
			inputPw.Enabled = true;
			startButton.Enabled = true;
			studentRadioButton.Enabled = true;
			tcrRadioButton.Enabled = true;
			employeeRadioButton.Enabled = true;

			infoLabel.Text = "실행하기 전에 큰사넷에 로그인 되어 있는지 확인해주세요";

			// Session 유지 중일 경우
			if (keepSession.IsAlive) {
				// Session 유지 중단
				keepSession.Abort();
				// Session 유지 종료 -> openToolStripMenuItem.Text = "열기" 로 설정
				reloginToolStripMenuItem.Text = "열기";
			}

			// 입력란 초기화
			inputId.Text = "";
			inputPw.Text = "";
			// inputId에 포커스 맞춤
			inputId.Focus();
		}

		// Form - inputId의 KeyDownEvent
		private void inputId_KeyDown(object sender, KeyEventArgs e) {
			// inputId에서 Enter 입력 시
			if (e.KeyCode == Keys.Enter) {
				// inputPw에 포커스 맞춤
				inputPw.Focus();
			}
		}

		// Form - inputPw의 KeyDownEvent
		private void inputPw_KeyDown(object sender, KeyEventArgs e) {
			// inputPw에서 Enter 입력 시
			if (e.KeyCode == Keys.Enter) {
				// Session 유지 시작 (startButton.Click 이벤트 발생)
				startButton.PerformClick();
			}
		}



		// Tray Icon - 열기 || 사용자 변경 클릭 시
		private void openToolStripMenuItem_Click(object sender, EventArgs e) {
			// 프로그램 화면에 띄우기
			this.Show();
			// 최소화 되어 있다면 원래 사이즈로 변경
			if (FormWindowState.Minimized == this.WindowState) {
				this.WindowState = FormWindowState.Normal;
			}

			// Session 유지 스레드가 실행 중일 경우
			if (keepSession.IsAlive) {
				// Session 유지 스레드 종료
				keepSession.Abort();
				// Session이 유지되고 있지 않을 경우 -> openToolStripMenuItem.Text = "열기" 로 설정
				reloginToolStripMenuItem.Text = "열기";
			}

			// 입력란 초기화
			inputId.Text = "";
			inputPw.Text = "";
			// inputId에 포커스 맞춤
			inputId.Focus();
		}

		// Tray Icon - 더블 클릭 시
		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
			// 프로그램 화면에 띄우기
			this.Show();

			// 최소화 되어 있을 경우
			if (FormWindowState.Minimized == this.WindowState) {
				// 본래 크기로 변경
				this.WindowState = FormWindowState.Normal;
			}

			// 입력란 초기화
			inputId.Text = "";
			inputPw.Text = "";
			// inputId에 포커스 맞춤
			inputId.Focus();

			// Session 유지 스레드가 실행 중일 경우
			if (keepSession.IsAlive) {
				// changeUserButton을 띄움
				changeUserButton.Enabled = true;

				// inputId, inputPw, startButton, radioButton 비활성화
				inputId.Enabled = false;
				inputPw.Enabled = false;
				startButton.Enabled = false;
				studentRadioButton.Enabled = false;
				tcrRadioButton.Enabled = false;
				employeeRadioButton.Enabled = false;

				infoLabel.Text = "다른 계정을 사용하시려면 사용자 변경 버튼을 눌러주세요";
			}
		}

		// Tray Icon - 종료 클릭 시
		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			// 프로그램 종료
			this.Close();
		}

		// Program - 화면 크기가 변경되었을 경우 (Form - 최소화 버튼 클릭 || (Tray Icon - 열기 || 사용자 변경 클릭))
		private void SmartWorkers_Resize(object sender, EventArgs e) {
			// 최소화 되었을 경우
			if (FormWindowState.Minimized == this.WindowState) {
				// Tray Icon 표시
				notifyIcon.Visible = true;
				// 현재 화면 최소화
				this.Hide();
			}
			// 크기가 Normal이 되었을 경우
			else if (FormWindowState.Normal == this.WindowState) {
				// Tray Icon 제거
				notifyIcon.Visible = false;
				// 작업 표시줄에 표시
				this.ShowInTaskbar = true;
			}
		}



		// Program - 프로그램 종료 시
		private void SmartWorkers_FormClosing(object sender, FormClosingEventArgs e) {
			// MessageBox를 띄운 후 결과 저장
			DialogResult dialogResult = MessageBox.Show("정말 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo);

			// "아니요"를 클릭했을 경우
			if (dialogResult == DialogResult.No) {
				// 종료 취소
				e.Cancel = true;
			}
			// "예"를 클릭했을 경우
			else {
				// Session 유지 스레드가 실행 중일 경우
				if (keepSession.IsAlive) {
					// Session 유지 스레드 종료
					keepSession.Abort();
				}
			}
		}



		// 헤더 패널을 클릭하고 드래그할 때 폼 전체가 이동
		private void headerPanel_MouseDown(object sender, MouseEventArgs e) {
			// 현재의 마우스 좌표를 저장
			mousePoint = new Point(e.X, e.Y);
		}

		// 헤더 패널을 클릭하고 드래그할 때 폼 전체가 이동
		private void headerPanel_MouseMove(object sender, MouseEventArgs e) {
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
				Location = new Point(this.Left - (mousePoint.X - e.X),
					this.Top - (mousePoint.Y - e.Y));
			}
		}

		// 헤더 패널을 클릭하고 드래그할 때 폼 전체가 이동
		private void logoPanel_MouseDown(object sender, MouseEventArgs e) {
			// 현재의 마우스 좌표를 저장
			mousePoint = new Point(e.X, e.Y);
		}

		// 헤더 패널을 클릭하고 드래그할 때 폼 전체가 이동
		private void logoPanel_MouseMove(object sender, MouseEventArgs e) {
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
				Location = new Point(this.Left - (mousePoint.X - e.X),
					this.Top - (mousePoint.Y - e.Y));
			}
		}

		// 헤더 패널을 클릭하고 드래그할 때 폼 전체가 이동
		private void nameLabel_MouseDown(object sender, MouseEventArgs e) {
			// 현재의 마우스 좌표를 저장
			mousePoint = new Point(e.X, e.Y);
		}

		// 헤더 패널을 클릭하고 드래그할 때 폼 전체가 이동
		private void nameLabel_MouseMove(object sender, MouseEventArgs e) {
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
				Location = new Point(this.Left - (mousePoint.X - e.X),
					this.Top - (mousePoint.Y - e.Y));
			}
		}



		// 로고를 클릭했을 때 CLK 패널 표시
		private void logoPictureBox_Click(object sender, EventArgs e) {
			clkPanel.Visible = true;
			settingPanel.Visible = false;
			creditPanel.Visible = false;

			nameLabel.Text = "CLK";
		}
		// 로고를 클릭했을 때 CLK 패널 표시
		private void cnsaLabel_Click(object sender, EventArgs e) {
			clkPanel.Visible = true;
			settingPanel.Visible = false;
			creditPanel.Visible = false;

			nameLabel.Text = "CLK";
		}
		// 로고를 클릭했을 때 CLK 패널 표시
		private void loginkeeperLabel_Click(object sender, EventArgs e) {
			clkPanel.Visible = true;
			settingPanel.Visible = false;
			creditPanel.Visible = false;

			nameLabel.Text = "CLK";
		}

		// Setting 버튼을 클릭했을 때 Setting 패널 표시
		private void settingButton_Click(object sender, EventArgs e) {
			clkPanel.Visible = false;
			settingPanel.Visible = true;
			creditPanel.Visible = false;

			nameLabel.Text = "Setting";
		}

		// Credit 버튼을 클릭했을 때 Credit 패널 표시
		private void creditButton_Click(object sender, EventArgs e) {
			clkPanel.Visible = false;
			settingPanel.Visible = false;
			creditPanel.Visible = true;

			nameLabel.Text = "Credit";
		}

		// 종료 이미지를 클릭했을 때 프로그램 종료
		private void closePictureBox_Click(object sender, EventArgs e) {
			this.Close();
		}



		// 설정 적용 버튼을 클릭했을 시 설정 적용
		private void applyButton_Click(object sender, EventArgs e) {
			// 레지스트리 키를 이용해서 CLK를 시작 프로그램에 등록
			if (startProgramCheck.Checked) { // 체크박스가 체크되었을 경우 - CLK를 시작 프로그램에 등록
				try {
					string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
					RegistryKey strUpKey = Registry.LocalMachine.OpenSubKey(runKey);
					// 시작 프로그램에 CLK가 없을 경우
					if (strUpKey.GetValue("CLK") == null) {
						strUpKey.Close();
						strUpKey = Registry.LocalMachine.OpenSubKey(runKey, true);
						// 시작프로그램에 CLK를 등록
						strUpKey.SetValue("CLK", Application.ExecutablePath);
					}
				}
				catch {
					// 오류가 발생했을 경우 메세지박스 출력
					MessageBox.Show("시작 프로그램 등록에 실패했습니다.", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else { // 체크박스가 해제되었을 경우 - CLK를 시작 프로그램에서 제거
				try {
					string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
					RegistryKey strUpKey = Registry.LocalMachine.OpenSubKey(runKey, true);
					// 시작 프로그램에서 CLK 제거
					strUpKey.DeleteValue("CLK");
				}
				catch {
					// 오류가 발생했을 경우 메세지박스 출력
					MessageBox.Show("시작 프로그램 제거에 실패했습니다.", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}

			// 설정이 완료되면 CLK 메인화면으로 이동
			clkPanel.Visible = true;
			settingPanel.Visible = false;
			creditPanel.Visible = false;

			nameLabel.Text = "CLK";
		}
	}
} 
