namespace CLK {
	partial class CLK {
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLK));
			this.inputId = new System.Windows.Forms.TextBox();
			this.idLabel = new System.Windows.Forms.Label();
			this.pwLabel = new System.Windows.Forms.Label();
			this.inputPw = new System.Windows.Forms.TextBox();
			this.startButton = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.reloginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeUserButton = new System.Windows.Forms.Button();
			this.studentRadioButton = new System.Windows.Forms.RadioButton();
			this.employeeRadioButton = new System.Windows.Forms.RadioButton();
			this.tcrRadioButton = new System.Windows.Forms.RadioButton();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// inputId
			// 
			this.inputId.Location = new System.Drawing.Point(34, 6);
			this.inputId.Name = "inputId";
			this.inputId.Size = new System.Drawing.Size(100, 21);
			this.inputId.TabIndex = 1;
			this.inputId.UseWaitCursor = true;
			this.inputId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputId_KeyDown);
			// 
			// idLabel
			// 
			this.idLabel.AutoSize = true;
			this.idLabel.Location = new System.Drawing.Point(12, 9);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(16, 12);
			this.idLabel.TabIndex = 0;
			this.idLabel.Text = "ID";
			this.idLabel.UseWaitCursor = true;
			// 
			// pwLabel
			// 
			this.pwLabel.AutoSize = true;
			this.pwLabel.Location = new System.Drawing.Point(5, 33);
			this.pwLabel.Name = "pwLabel";
			this.pwLabel.Size = new System.Drawing.Size(23, 12);
			this.pwLabel.TabIndex = 0;
			this.pwLabel.Text = "PW";
			this.pwLabel.UseWaitCursor = true;
			// 
			// inputPw
			// 
			this.inputPw.Location = new System.Drawing.Point(34, 30);
			this.inputPw.Name = "inputPw";
			this.inputPw.PasswordChar = '*';
			this.inputPw.Size = new System.Drawing.Size(100, 21);
			this.inputPw.TabIndex = 2;
			this.inputPw.UseWaitCursor = true;
			this.inputPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputPw_KeyDown);
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(141, 6);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(50, 45);
			this.startButton.TabIndex = 3;
			this.startButton.Text = "실행";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.UseWaitCursor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Clicked);
			// 
			// notifyIcon
			// 
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "SmartWorkers";
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.reloginToolStripMenuItem,
			this.exitToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip1";
			this.contextMenuStrip.Size = new System.Drawing.Size(103, 48);
			// 
			// reloginToolStripMenuItem
			// 
			this.reloginToolStripMenuItem.Name = "reloginToolStripMenuItem";
			this.reloginToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.reloginToolStripMenuItem.Text = "열기";
			this.reloginToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
			this.exitToolStripMenuItem.Text = "종료";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// changeUserButton
			// 
			this.changeUserButton.Font = new System.Drawing.Font("맑은 고딕", 10F);
			this.changeUserButton.Location = new System.Drawing.Point(7, 6);
			this.changeUserButton.Name = "changeUserButton";
			this.changeUserButton.Size = new System.Drawing.Size(184, 67);
			this.changeUserButton.TabIndex = 0;
			this.changeUserButton.Text = "사용자 변경";
			this.changeUserButton.UseVisualStyleBackColor = true;
			this.changeUserButton.UseWaitCursor = true;
			this.changeUserButton.Visible = false;
			this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
			// 
			// studentRadioButton
			// 
			this.studentRadioButton.AutoSize = true;
			this.studentRadioButton.Checked = true;
			this.studentRadioButton.Location = new System.Drawing.Point(7, 57);
			this.studentRadioButton.Name = "studentRadioButton";
			this.studentRadioButton.Size = new System.Drawing.Size(47, 16);
			this.studentRadioButton.TabIndex = 4;
			this.studentRadioButton.TabStop = true;
			this.studentRadioButton.Text = "학생";
			this.studentRadioButton.UseVisualStyleBackColor = true;
			// 
			// employeeRadioButton
			// 
			this.employeeRadioButton.AutoSize = true;
			this.employeeRadioButton.Location = new System.Drawing.Point(125, 57);
			this.employeeRadioButton.Name = "employeeRadioButton";
			this.employeeRadioButton.Size = new System.Drawing.Size(59, 16);
			this.employeeRadioButton.TabIndex = 6;
			this.employeeRadioButton.Text = "교직원";
			this.employeeRadioButton.UseVisualStyleBackColor = true;
			// 
			// tcrRadioButton
			// 
			this.tcrRadioButton.AutoSize = true;
			this.tcrRadioButton.Location = new System.Drawing.Point(60, 57);
			this.tcrRadioButton.Name = "tcrRadioButton";
			this.tcrRadioButton.Size = new System.Drawing.Size(59, 16);
			this.tcrRadioButton.TabIndex = 5;
			this.tcrRadioButton.Text = "선생님";
			this.tcrRadioButton.UseVisualStyleBackColor = true;
			// 
			// CLK
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(199, 78);
			this.Controls.Add(this.changeUserButton);
			this.Controls.Add(this.tcrRadioButton);
			this.Controls.Add(this.employeeRadioButton);
			this.Controls.Add(this.studentRadioButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.inputPw);
			this.Controls.Add(this.pwLabel);
			this.Controls.Add(this.idLabel);
			this.Controls.Add(this.inputId);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1000, 1000);
			this.MinimumSize = new System.Drawing.Size(215, 95);
			this.Name = "CLK";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CLK";
			this.UseWaitCursor = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SmartWorkers_FormClosing);
			this.Load += new System.EventHandler(this.SmartWorkers_Load);
			this.Resize += new System.EventHandler(this.SmartWorkers_Resize);
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inputId;
		private System.Windows.Forms.Label idLabel;
		private System.Windows.Forms.Label pwLabel;
		private System.Windows.Forms.TextBox inputPw;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reloginToolStripMenuItem;
		private System.Windows.Forms.Button changeUserButton;
		private System.Windows.Forms.RadioButton studentRadioButton;
		private System.Windows.Forms.RadioButton employeeRadioButton;
		private System.Windows.Forms.RadioButton tcrRadioButton;
	}
}