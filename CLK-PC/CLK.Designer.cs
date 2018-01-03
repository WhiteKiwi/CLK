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
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.headerPanel = new System.Windows.Forms.Panel();
			this.nameLabel = new System.Windows.Forms.Label();
			this.closePictureBox = new System.Windows.Forms.PictureBox();
			this.menuPanel = new System.Windows.Forms.Panel();
			this.creditButton = new System.Windows.Forms.Button();
			this.settingButton = new System.Windows.Forms.Button();
			this.logoPanel = new System.Windows.Forms.Panel();
			this.loginkeeperLabel = new System.Windows.Forms.Label();
			this.cnsaLabel = new System.Windows.Forms.Label();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.idLabel = new System.Windows.Forms.Label();
			this.pwLabel = new System.Windows.Forms.Label();
			this.infoLabel = new System.Windows.Forms.Label();
			this.clkPanel = new System.Windows.Forms.Panel();
			this.settingPanel = new System.Windows.Forms.Panel();
			this.applyButton = new System.Windows.Forms.Button();
			this.startProgramCheck = new System.Windows.Forms.CheckBox();
			this.creditPanel = new System.Windows.Forms.Panel();
			this.creditLabel = new System.Windows.Forms.Label();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.headerPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
			this.menuPanel.SuspendLayout();
			this.logoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.clkPanel.SuspendLayout();
			this.settingPanel.SuspendLayout();
			this.creditPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// inputId
			// 
			this.inputId.Location = new System.Drawing.Point(33, 8);
			this.inputId.Name = "inputId";
			this.inputId.Size = new System.Drawing.Size(128, 21);
			this.inputId.TabIndex = 1;
			this.inputId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputId_KeyDown);
			// 
			// inputPw
			// 
			this.inputPw.Location = new System.Drawing.Point(33, 35);
			this.inputPw.Name = "inputPw";
			this.inputPw.PasswordChar = '*';
			this.inputPw.Size = new System.Drawing.Size(128, 21);
			this.inputPw.TabIndex = 2;
			this.inputPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputPw_KeyDown);
			// 
			// startButton
			// 
			this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
			this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.startButton.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.startButton.Location = new System.Drawing.Point(171, 8);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(50, 48);
			this.startButton.TabIndex = 3;
			this.startButton.Text = "실행";
			this.startButton.UseVisualStyleBackColor = false;
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
			this.contextMenuStrip.Size = new System.Drawing.Size(99, 48);
			// 
			// reloginToolStripMenuItem
			// 
			this.reloginToolStripMenuItem.Name = "reloginToolStripMenuItem";
			this.reloginToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.reloginToolStripMenuItem.Text = "열기";
			this.reloginToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.exitToolStripMenuItem.Text = "종료";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// changeUserButton
			// 
			this.changeUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
			this.changeUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.changeUserButton.Enabled = false;
			this.changeUserButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.changeUserButton.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.changeUserButton.Location = new System.Drawing.Point(8, 62);
			this.changeUserButton.Name = "changeUserButton";
			this.changeUserButton.Size = new System.Drawing.Size(213, 26);
			this.changeUserButton.TabIndex = 0;
			this.changeUserButton.Text = "사용자 변경";
			this.changeUserButton.UseVisualStyleBackColor = false;
			this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
			// 
			// studentRadioButton
			// 
			this.studentRadioButton.AutoSize = true;
			this.studentRadioButton.Checked = true;
			this.studentRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.studentRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.studentRadioButton.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.studentRadioButton.Location = new System.Drawing.Point(227, 10);
			this.studentRadioButton.Name = "studentRadioButton";
			this.studentRadioButton.Size = new System.Drawing.Size(53, 19);
			this.studentRadioButton.TabIndex = 4;
			this.studentRadioButton.TabStop = true;
			this.studentRadioButton.Text = "학생";
			this.studentRadioButton.UseVisualStyleBackColor = true;
			// 
			// employeeRadioButton
			// 
			this.employeeRadioButton.AutoSize = true;
			this.employeeRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.employeeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.employeeRadioButton.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.employeeRadioButton.Location = new System.Drawing.Point(227, 54);
			this.employeeRadioButton.Name = "employeeRadioButton";
			this.employeeRadioButton.Size = new System.Drawing.Size(64, 19);
			this.employeeRadioButton.TabIndex = 6;
			this.employeeRadioButton.Text = "교직원";
			this.employeeRadioButton.UseVisualStyleBackColor = true;
			// 
			// tcrRadioButton
			// 
			this.tcrRadioButton.AutoSize = true;
			this.tcrRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tcrRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.tcrRadioButton.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.tcrRadioButton.Location = new System.Drawing.Point(227, 32);
			this.tcrRadioButton.Name = "tcrRadioButton";
			this.tcrRadioButton.Size = new System.Drawing.Size(53, 19);
			this.tcrRadioButton.TabIndex = 5;
			this.tcrRadioButton.Text = "교사";
			this.tcrRadioButton.UseVisualStyleBackColor = true;
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// headerPanel
			// 
			this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(183)))), ((int)(((byte)(234)))));
			this.headerPanel.Controls.Add(this.nameLabel);
			this.headerPanel.Controls.Add(this.closePictureBox);
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(450, 50);
			this.headerPanel.TabIndex = 7;
			this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
			this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.nameLabel.ForeColor = System.Drawing.Color.White;
			this.nameLabel.Location = new System.Drawing.Point(141, 15);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(44, 21);
			this.nameLabel.TabIndex = 12;
			this.nameLabel.Text = "CLK";
			this.nameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nameLabel_MouseDown);
			this.nameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nameLabel_MouseMove);
			// 
			// closePictureBox
			// 
			this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
			this.closePictureBox.Location = new System.Drawing.Point(413, 3);
			this.closePictureBox.Name = "closePictureBox";
			this.closePictureBox.Size = new System.Drawing.Size(12, 12);
			this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.closePictureBox.TabIndex = 1;
			this.closePictureBox.TabStop = false;
			this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.Color.DimGray;
			this.menuPanel.Controls.Add(this.creditButton);
			this.menuPanel.Controls.Add(this.settingButton);
			this.menuPanel.Controls.Add(this.logoPanel);
			this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(135, 158);
			this.menuPanel.TabIndex = 8;
			// 
			// creditButton
			// 
			this.creditButton.BackColor = System.Drawing.Color.DimGray;
			this.creditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.creditButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.creditButton.FlatAppearance.BorderSize = 0;
			this.creditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.creditButton.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.creditButton.ForeColor = System.Drawing.Color.Gainsboro;
			this.creditButton.Location = new System.Drawing.Point(1, 90);
			this.creditButton.Name = "creditButton";
			this.creditButton.Size = new System.Drawing.Size(134, 40);
			this.creditButton.TabIndex = 2;
			this.creditButton.Text = "Credit";
			this.creditButton.UseVisualStyleBackColor = false;
			this.creditButton.Click += new System.EventHandler(this.creditButton_Click);
			// 
			// settingButton
			// 
			this.settingButton.BackColor = System.Drawing.Color.DimGray;
			this.settingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.settingButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.settingButton.FlatAppearance.BorderSize = 0;
			this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.settingButton.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.settingButton.ForeColor = System.Drawing.Color.Gainsboro;
			this.settingButton.Location = new System.Drawing.Point(0, 48);
			this.settingButton.Name = "settingButton";
			this.settingButton.Size = new System.Drawing.Size(134, 40);
			this.settingButton.TabIndex = 1;
			this.settingButton.Text = "Setting";
			this.settingButton.UseVisualStyleBackColor = false;
			this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
			// 
			// logoPanel
			// 
			this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.logoPanel.Controls.Add(this.loginkeeperLabel);
			this.logoPanel.Controls.Add(this.cnsaLabel);
			this.logoPanel.Controls.Add(this.logoPictureBox);
			this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.logoPanel.Location = new System.Drawing.Point(0, 0);
			this.logoPanel.Name = "logoPanel";
			this.logoPanel.Size = new System.Drawing.Size(135, 50);
			this.logoPanel.TabIndex = 0;
			this.logoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logoPanel_MouseDown);
			this.logoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logoPanel_MouseMove);
			// 
			// loginkeeperLabel
			// 
			this.loginkeeperLabel.AutoSize = true;
			this.loginkeeperLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.loginkeeperLabel.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.loginkeeperLabel.ForeColor = System.Drawing.Color.White;
			this.loginkeeperLabel.Location = new System.Drawing.Point(51, 26);
			this.loginkeeperLabel.Name = "loginkeeperLabel";
			this.loginkeeperLabel.Size = new System.Drawing.Size(75, 13);
			this.loginkeeperLabel.TabIndex = 2;
			this.loginkeeperLabel.Text = "Login Keeper";
			this.loginkeeperLabel.Click += new System.EventHandler(this.loginkeeperLabel_Click);
			// 
			// cnsaLabel
			// 
			this.cnsaLabel.AutoSize = true;
			this.cnsaLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cnsaLabel.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cnsaLabel.ForeColor = System.Drawing.Color.White;
			this.cnsaLabel.Location = new System.Drawing.Point(51, 9);
			this.cnsaLabel.Name = "cnsaLabel";
			this.cnsaLabel.Size = new System.Drawing.Size(48, 17);
			this.cnsaLabel.TabIndex = 1;
			this.cnsaLabel.Text = "CNSA";
			this.cnsaLabel.Click += new System.EventHandler(this.cnsaLabel_Click);
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(3, 2);
			this.logoPictureBox.Name = "logoPictureBox";
			this.logoPictureBox.Size = new System.Drawing.Size(51, 43);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoPictureBox.TabIndex = 0;
			this.logoPictureBox.TabStop = false;
			this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
			// 
			// idLabel
			// 
			this.idLabel.AutoSize = true;
			this.idLabel.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.idLabel.Location = new System.Drawing.Point(13, 10);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(19, 14);
			this.idLabel.TabIndex = 9;
			this.idLabel.Text = "ID";
			// 
			// pwLabel
			// 
			this.pwLabel.AutoSize = true;
			this.pwLabel.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.pwLabel.Location = new System.Drawing.Point(6, 37);
			this.pwLabel.Name = "pwLabel";
			this.pwLabel.Size = new System.Drawing.Size(26, 14);
			this.pwLabel.TabIndex = 10;
			this.pwLabel.Text = "PW";
			// 
			// infoLabel
			// 
			this.infoLabel.AutoSize = true;
			this.infoLabel.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.infoLabel.ForeColor = System.Drawing.Color.Gray;
			this.infoLabel.Location = new System.Drawing.Point(3, 91);
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.Size = new System.Drawing.Size(289, 14);
			this.infoLabel.TabIndex = 11;
			this.infoLabel.Text = "실행하기 전에 큰사넷에 로그인 되어 있는지 확인해주세요";
			// 
			// clkPanel
			// 
			this.clkPanel.Controls.Add(this.startButton);
			this.clkPanel.Controls.Add(this.inputId);
			this.clkPanel.Controls.Add(this.infoLabel);
			this.clkPanel.Controls.Add(this.idLabel);
			this.clkPanel.Controls.Add(this.employeeRadioButton);
			this.clkPanel.Controls.Add(this.tcrRadioButton);
			this.clkPanel.Controls.Add(this.pwLabel);
			this.clkPanel.Controls.Add(this.inputPw);
			this.clkPanel.Controls.Add(this.studentRadioButton);
			this.clkPanel.Controls.Add(this.changeUserButton);
			this.clkPanel.Location = new System.Drawing.Point(135, 50);
			this.clkPanel.Name = "clkPanel";
			this.clkPanel.Size = new System.Drawing.Size(293, 110);
			this.clkPanel.TabIndex = 12;
			// 
			// settingPanel
			// 
			this.settingPanel.Controls.Add(this.applyButton);
			this.settingPanel.Controls.Add(this.startProgramCheck);
			this.settingPanel.Location = new System.Drawing.Point(135, 50);
			this.settingPanel.Name = "settingPanel";
			this.settingPanel.Size = new System.Drawing.Size(293, 110);
			this.settingPanel.TabIndex = 13;
			this.settingPanel.Visible = false;
			// 
			// applyButton
			// 
			this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.applyButton.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.applyButton.Location = new System.Drawing.Point(215, 84);
			this.applyButton.Name = "applyButton";
			this.applyButton.Size = new System.Drawing.Size(75, 21);
			this.applyButton.TabIndex = 1;
			this.applyButton.Text = "적용";
			this.applyButton.UseVisualStyleBackColor = true;
			this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
			// 
			// startProgramCheck
			// 
			this.startProgramCheck.AutoSize = true;
			this.startProgramCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.startProgramCheck.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.startProgramCheck.Location = new System.Drawing.Point(7, 7);
			this.startProgramCheck.Name = "startProgramCheck";
			this.startProgramCheck.Size = new System.Drawing.Size(148, 19);
			this.startProgramCheck.TabIndex = 0;
			this.startProgramCheck.Text = "시작 프로그램으로 등록";
			this.startProgramCheck.UseVisualStyleBackColor = true;
			// 
			// creditPanel
			// 
			this.creditPanel.AutoScroll = true;
			this.creditPanel.Controls.Add(this.creditLabel);
			this.creditPanel.Location = new System.Drawing.Point(135, 50);
			this.creditPanel.Name = "creditPanel";
			this.creditPanel.Size = new System.Drawing.Size(293, 110);
			this.creditPanel.TabIndex = 14;
			this.creditPanel.Visible = false;
			// 
			// creditLabel
			// 
			this.creditLabel.AutoSize = true;
			this.creditLabel.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.creditLabel.Location = new System.Drawing.Point(6, 6);
			this.creditLabel.Name = "creditLabel";
			this.creditLabel.Size = new System.Drawing.Size(225, 154);
			this.creditLabel.TabIndex = 0;
			this.creditLabel.Text = "아이디어: 누구누구\r\n디자인: 누구누구\r\n프로그래밍: 누구누구\r\n기타등등\r\n\r\n이 프로그램은\r\n창의적산출물로 우려먹기 위해 만들어졌으며\r\n말말말아" +
    "무말아무말\r\n\r\n크레딧 내용은 알아서 바꾸면 됩니다\r\n부탁해요 디자이너\r\n";
			this.creditLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// CLK
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(428, 158);
			this.Controls.Add(this.creditPanel);
			this.Controls.Add(this.settingPanel);
			this.Controls.Add(this.clkPanel);
			this.Controls.Add(this.menuPanel);
			this.Controls.Add(this.headerPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1000, 1000);
			this.MinimumSize = new System.Drawing.Size(428, 158);
			this.Name = "CLK";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CLK";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SmartWorkers_FormClosing);
			this.Load += new System.EventHandler(this.SmartWorkers_Load);
			this.Resize += new System.EventHandler(this.SmartWorkers_Resize);
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.headerPanel.ResumeLayout(false);
			this.headerPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
			this.menuPanel.ResumeLayout(false);
			this.logoPanel.ResumeLayout(false);
			this.logoPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.clkPanel.ResumeLayout(false);
			this.clkPanel.PerformLayout();
			this.settingPanel.ResumeLayout(false);
			this.settingPanel.PerformLayout();
			this.creditPanel.ResumeLayout(false);
			this.creditPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox inputId;
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
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.Panel headerPanel;
		private System.Windows.Forms.PictureBox closePictureBox;
		private System.Windows.Forms.Panel menuPanel;
		private System.Windows.Forms.Panel logoPanel;
		private System.Windows.Forms.Label loginkeeperLabel;
		private System.Windows.Forms.Label cnsaLabel;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Button settingButton;
		private System.Windows.Forms.Button creditButton;
		private System.Windows.Forms.Label pwLabel;
		private System.Windows.Forms.Label idLabel;
		private System.Windows.Forms.Label infoLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Panel clkPanel;
		private System.Windows.Forms.Panel settingPanel;
		private System.Windows.Forms.CheckBox startProgramCheck;
		private System.Windows.Forms.Button applyButton;
		private System.Windows.Forms.Panel creditPanel;
		private System.Windows.Forms.Label creditLabel;
	}
}