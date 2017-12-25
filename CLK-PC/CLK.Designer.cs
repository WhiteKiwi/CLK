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
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.creditButton = new System.Windows.Forms.Button();
			this.settingButton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.headerPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// inputId
			// 
			this.inputId.Location = new System.Drawing.Point(171, 60);
			this.inputId.Name = "inputId";
			this.inputId.Size = new System.Drawing.Size(128, 21);
			this.inputId.TabIndex = 1;
			this.inputId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputId_KeyDown);
			// 
			// inputPw
			// 
			this.inputPw.Location = new System.Drawing.Point(171, 87);
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
			this.startButton.Location = new System.Drawing.Point(305, 60);
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
			this.changeUserButton.Location = new System.Drawing.Point(142, 114);
			this.changeUserButton.Name = "changeUserButton";
			this.changeUserButton.Size = new System.Drawing.Size(213, 26);
			this.changeUserButton.TabIndex = 0;
			this.changeUserButton.Text = "로그아웃";
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
			this.studentRadioButton.Location = new System.Drawing.Point(361, 56);
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
			this.employeeRadioButton.Location = new System.Drawing.Point(361, 106);
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
			this.tcrRadioButton.Location = new System.Drawing.Point(361, 81);
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
			this.headerPanel.Controls.Add(this.label6);
			this.headerPanel.Controls.Add(this.pictureBox2);
			this.headerPanel.Location = new System.Drawing.Point(0, 0);
			this.headerPanel.Name = "headerPanel";
			this.headerPanel.Size = new System.Drawing.Size(450, 50);
			this.headerPanel.TabIndex = 7;
			this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
			this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(413, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(12, 12);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.Controls.Add(this.creditButton);
			this.panel1.Controls.Add(this.settingButton);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(135, 158);
			this.panel1.TabIndex = 8;
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
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(135, 50);
			this.panel2.TabIndex = 0;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(51, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Login Keeper";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(51, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "CNSA";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(51, 43);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(146, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 14);
			this.label3.TabIndex = 9;
			this.label3.Text = "ID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(139, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 14);
			this.label4.TabIndex = 10;
			this.label4.Text = "PW";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.ForeColor = System.Drawing.Color.Gray;
			this.label5.Location = new System.Drawing.Point(137, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(289, 14);
			this.label5.TabIndex = 11;
			this.label5.Text = "실행하기 전에 큰사넷에 로그인 되어 있는지 확인해주세요";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(141, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 21);
			this.label6.TabIndex = 12;
			this.label6.Text = "CLK";
			// 
			// CLK
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(428, 158);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.headerPanel);
			this.Controls.Add(this.changeUserButton);
			this.Controls.Add(this.tcrRadioButton);
			this.Controls.Add(this.employeeRadioButton);
			this.Controls.Add(this.studentRadioButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.inputPw);
			this.Controls.Add(this.inputId);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(428, 158);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button settingButton;
		private System.Windows.Forms.Button creditButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}