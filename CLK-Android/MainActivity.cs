using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;
using System.Net;
using System.Text;
using KiwiLibrary;

namespace CLK {
	[Activity(Label = "CLK", MainLauncher = true)]
	public class MainActivity : Activity {
		// HTTP 통신에 사용 할 CookieAwareWebClient
		CookieAwareWebClient Web = new CookieAwareWebClient();

		// CNSA net Id를 저장할 변수
		static string cnsaId;
		// CNSA net Pw를 저장할 변수
		static string cnsaPw;
		// Session 값을 저장할 변수
		static string session;

		// 학생/교사 여부를 저장할 변수
		bool studentCount = true;

		// 내부망 주소를 저장할 변수 [기본: 학생]
		string intraNetUrl = "http://10.1.100.32";
		readonly string strIntraNetUrl = "http://10.1.100.32";
		readonly string tcrIntraNetUrl = "http://10.1.100.31";
		// 외부망 주소를 저장할 변수 [기본: 학생]
		string extraNetUrl = "https://student.cnsa.hs.kr";
		readonly string strExtraNetUrl = "https://student.cnsa.hs.kr";
		readonly string tcrExtraNetUrl = "https://school.cnsa.hs.kr";

		// Background에서 실행 될 Service
		static Intent CLKService;

		// Background Service를 유지시켜줄 Receiver
		RestartService receiver;

		// Service 실행 여부를 저장할 변수
		bool IsStarted = false;

		// Activity가 Load될 때 실행
		protected override void OnStart() {
			// Service가 실행 중이라면 종료
			if (CLKService != null)
				StopService(CLKService);

			// 입력했던 ID, PW 복원
			if (cnsaId != null)
				FindViewById<EditText>(Resource.Id.inputId).Text = cnsaId;
			if (cnsaPw != null)
				FindViewById<EditText>(Resource.Id.inputPw).Text = cnsaPw;

			base.OnStart();
		}

		// App이 처음 로드 될 때 실행되는 메서드
		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			// Open Main.axml
			SetContentView(Resource.Layout.Main);
			// Add Button Click Event
			FindViewById<Button>(Resource.Id.loginLogo).Click += CLK_Click;
			// Add Button LongClick Event
			FindViewById<Button>(Resource.Id.loginLogo).LongClick += CLK_LongClick;
		}

		// Button Click Event
		private void CLK_Click(object sender, EventArgs e) {
			// CNSAnet Id, Pw 저장
			cnsaId = FindViewById<EditText>(Resource.Id.inputId).Text;
			cnsaPw = FindViewById<EditText>(Resource.Id.inputPw).Text;

			if (IsStarted) {    // Service가 실행 중인 경우
								// Service 종료
				StopService(CLKService);
				// Service 실행 상태 갱신
				IsStarted = false;
				// Button Image 변경
				FindViewById<Button>(Resource.Id.loginLogo).Background = GetDrawable(Resource.Drawable.CLKStop);
			} else if (cnsaId.Trim().Equals("")) {   // If ID column is empty
													 // inputId 초기화 후 포커스 맞춤
				FindViewById<EditText>(Resource.Id.inputId).Text = "";
				FindViewById<EditText>(Resource.Id.inputId).FocusableInTouchMode = true;
				FindViewById<EditText>(Resource.Id.inputId).RequestFocus();

				// Toast
				Toast.MakeText(this, "Please enter your ID", ToastLength.Long).Show();
			} else if (cnsaPw.Trim().Equals("")) {    // If PW column is empty
													  // inputPw 초기화 후 포커스 맞춤
				FindViewById<EditText>(Resource.Id.inputPw).Text = "";
				FindViewById<EditText>(Resource.Id.inputPw).FocusableInTouchMode = true;
				FindViewById<EditText>(Resource.Id.inputPw).RequestFocus();

				// Toast
				Toast.MakeText(this, "Please enter your PW", ToastLength.Long).Show();
			} else {
				try {
					// CNSAnet에서 Session을 받아옴
					session = Encoding.UTF8.GetString(Web.DownloadData(extraNetUrl + "/login/dupLoginCheck?loginId=" + cnsaId));
				} catch (WebException webE) {   // WebException 발생 시 실행 [CNSAnet 연결 실패 포함]
												// Toast
					Toast.MakeText(this, "CNSAnet에 연결할 수 없습니다.", ToastLength.Long).Show();

					return;
				}
				// Session이 존재할 경우 (로그인이 되어 있을 경우)
				if (session.Trim() != "") {
					// Session 초기화
					Web.CookieContainer = new CookieContainer();
					// Session 값을 저장
					Web.AddCookie(new Uri(intraNetUrl), new Cookie("JSESSIONID", session));
					Web.AddCookie(new Uri(extraNetUrl), new Cookie("JSESSIONID", session));

					// 로그인 시도
					string responseData = Encoding.UTF8.GetString(Web.UploadValues(extraNetUrl + "/login/userLogin", new System.Collections.Specialized.NameValueCollection() {
						{ "loginId", cnsaId },
						{ "loginPw", cnsaPw }
					}));

					if (!responseData.Contains("/login/userLogin")) {   // requestData에 특정 문자열이 포함되어 있지 않은 경우 로그인 성공으로 간주
																		// Service가 실행 중이지 않은 경우
						if (!IsStarted) {
							// Create Service
							CLKService = new Intent(this, typeof(KeepSession));
							// Set Service Action
							CLKService.SetAction("com.CLK.KeepService");

							// Add Receiver
							receiver = new RestartService();
							// Save Receiver
							RegisterReceiver(receiver, new IntentFilter(CLKService.Action));

							// Service에 값 전달
							CLKService.PutExtra("cnsaId", cnsaId);
							CLKService.PutExtra("cnsaPw", cnsaPw);
							if (studentCount) { // 학생인 경우
								CLKService.PutExtra("intraNetUrl", strIntraNetUrl);
								CLKService.PutExtra("extraNetUrl", strExtraNetUrl);
							} else {    // 교사/교직원인 경우
								CLKService.PutExtra("intraNetUrl", tcrIntraNetUrl);
								CLKService.PutExtra("extraNetUrl", tcrExtraNetUrl);
							}
							CLKService.PutExtra("session", session);

							// Service 실행
							StartService(CLKService);
							// Service 상태 저장
							IsStarted = true;

							// Button Image 변경
							FindViewById<Button>(Resource.Id.loginLogo).Background = GetDrawable(Resource.Drawable.CLKRun);
						}
					} else {  // 로그인 실패
							  // Toast
						Toast.MakeText(this, "Login Failed", ToastLength.Long).Show();
					}
				} else {    // session이 존재하지 않을 경우 (로그인이 되어 있지 않을 경우)
							// Toast
					Toast.MakeText(this, "CNSAnet에 로그인이 되어있지 않습니다.", ToastLength.Long).Show();
				}
			}
		}

		// Button LongClick Event
		private void CLK_LongClick(object sender, Android.Views.View.LongClickEventArgs e) {
			// 상태 전환
			studentCount = !studentCount;

			if (studentCount) { // 학생일 경우
				intraNetUrl = strIntraNetUrl;
				extraNetUrl = strExtraNetUrl;

				FindViewById<TextView>(Resource.Id.statusInfo).Text = "# Logo를 길게 클릭하면 교사/교직원으로 변경됩니다.";
				FindViewById<TextView>(Resource.Id.status).Text = "[학생]";
			} else {    // 교사/교직원인 경우
				intraNetUrl = tcrIntraNetUrl;
				extraNetUrl = tcrExtraNetUrl;

				FindViewById<TextView>(Resource.Id.statusInfo).Text = "# Logo를 길게 클릭하면 학생으로 변경됩니다.";
				FindViewById<TextView>(Resource.Id.status).Text = "[교사/교직원]";
			}
		}

		protected override void OnDestroy() {
			// Remove Receiver [삭제하지 않으면 Error]
			if (receiver != null) {
				UnregisterReceiver(receiver);
			}

			base.OnDestroy();
		}
	}
}

