﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CLK {
	public partial class Setting : Form {

		//마우스 위치값을 저장할 변수
		Point mousePoint;

		//화면 모서리를 둥글게 함
		[System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn(
			 int nLeftRect, // x-coordinate of upper-left corner
			 int nTopRect, // y-coordinate of upper-left corner
			 int nRightRect, // x-coordinate of lower-right corner
			 int nBottomRect, // y-coordinate of lower-right corner
			 int nWidthEllipse, // height of ellipse
			 int nHeightEllipse // width of ellipse
		);

		public Setting() {
			InitializeComponent();

			Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 3, 3));
		}

		//폼에 그림자 생성
		private const int CS_DROPSHADOW = 0x00020000;
		protected override CreateParams CreateParams {
			get {
				CreateParams cp = base.CreateParams;
				cp.ClassStyle |= CS_DROPSHADOW;
				return cp;
			}
		}

		//종료 이미지를 클릭했을 때 폼 종료
		private void pictureBox2_Click(object sender, EventArgs e) {
			this.Close();
		}

		//헤더 패널을 클릭하고 드래그할 때 폼 전체가 이동
		private void panel2_MouseDown(object sender, MouseEventArgs e) {
			mousePoint = new Point(e.X, e.Y);
		}

		//헤더 패널을 클릭하고 드래그할 때 폼 전체가 이동
		private void panel2_MouseMove(object sender, MouseEventArgs e) {
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
				Location = new Point(this.Left - (mousePoint.X - e.X),
					this.Top - (mousePoint.Y - e.Y));
			}
		}

		//헤더 패널을 클릭하고 드래그할 때 폼 전체가 이동
		private void panel1_MouseDown(object sender, MouseEventArgs e) {
			mousePoint = new Point(e.X, e.Y);
		}

		//헤더 패널을 클릭하고 드래그할 때 폼 전체가 이동
		private void panel1_MouseMove(object sender, MouseEventArgs e) {
			if ((e.Button & MouseButtons.Left) == MouseButtons.Left) {
				Location = new Point(this.Left - (mousePoint.X - e.X),
					this.Top - (mousePoint.Y - e.Y));
			}
		}

		//설정 적용
		private void button1_Click(object sender, EventArgs e) {
			
			//레지스트리 키를 이용해서 CLK를 시작 프로그램에 등록
			if (startProgramCheck.Checked) { //체크박스가 체크되었을 경우 - CLK를 시작 프로그램에 등록
				try {
					string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
					RegistryKey strUpKey = Registry.LocalMachine.OpenSubKey(runKey);
					if (strUpKey.GetValue("CLK") == null) {
						strUpKey.Close();
						strUpKey = Registry.LocalMachine.OpenSubKey(runKey, true);
						strUpKey.SetValue("CLK", Application.ExecutablePath);
					}
				}
				catch {
					MessageBox.Show("시작 프로그램 등록에 실패했습니다.", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else { //체크박스가 해제되었을 경우 - CLK를 시작 프로그램에서 제거
				try {
					string runKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
					RegistryKey strUpKey = Registry.LocalMachine.OpenSubKey(runKey, true);
					strUpKey.DeleteValue("CLK");
				}
				catch {
					MessageBox.Show("시작 프로그램 제거에 실패했습니다.", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
	}
}