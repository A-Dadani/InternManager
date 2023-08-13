namespace InternManagerUI
{
	partial class layoutFrm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(layoutFrm));
			sideNavBar = new Panel();
			signupRequestsPanel = new Panel();
			signupRequestsPictureBox = new PictureBox();
			signupRequestsLabel = new Label();
			manageInternsPanel = new Panel();
			manageInternsPictureBox = new PictureBox();
			manageInternsLabel = new Label();
			navigationSelectorPanel = new Panel();
			dashboardPanel = new Panel();
			dashboardLogoPictureBox = new PictureBox();
			dashboardLabel = new Label();
			horizontalSeparator = new Panel();
			logoutPanel = new Panel();
			logoutLabel = new Label();
			logoutIcon = new PictureBox();
			logoPictureBox = new PictureBox();
			titleBarPanel = new Panel();
			titleLabel = new Label();
			contentPlaceholderPanel = new Panel();
			panel1 = new Panel();
			sideNavBar.SuspendLayout();
			signupRequestsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)signupRequestsPictureBox).BeginInit();
			manageInternsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)manageInternsPictureBox).BeginInit();
			dashboardPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dashboardLogoPictureBox).BeginInit();
			logoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logoutIcon).BeginInit();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			titleBarPanel.SuspendLayout();
			SuspendLayout();
			// 
			// sideNavBar
			// 
			sideNavBar.BackColor = Color.FromArgb(13, 13, 13);
			sideNavBar.Controls.Add(signupRequestsPanel);
			sideNavBar.Controls.Add(manageInternsPanel);
			sideNavBar.Controls.Add(navigationSelectorPanel);
			sideNavBar.Controls.Add(dashboardPanel);
			sideNavBar.Controls.Add(horizontalSeparator);
			sideNavBar.Controls.Add(logoutPanel);
			sideNavBar.Controls.Add(logoPictureBox);
			sideNavBar.Dock = DockStyle.Left;
			sideNavBar.Location = new Point(0, 0);
			sideNavBar.Name = "sideNavBar";
			sideNavBar.Size = new Size(316, 681);
			sideNavBar.TabIndex = 0;
			// 
			// signupRequestsPanel
			// 
			signupRequestsPanel.Controls.Add(signupRequestsPictureBox);
			signupRequestsPanel.Controls.Add(signupRequestsLabel);
			signupRequestsPanel.Location = new Point(0, 266);
			signupRequestsPanel.Name = "signupRequestsPanel";
			signupRequestsPanel.Size = new Size(316, 56);
			signupRequestsPanel.TabIndex = 7;
			signupRequestsPanel.Click += signupRequestsPanel_Click;
			signupRequestsPanel.MouseEnter += signupRequestsPanel_MouseEnter;
			signupRequestsPanel.MouseLeave += signupRequestsPanel_MouseLeave;
			// 
			// signupRequestsPictureBox
			// 
			signupRequestsPictureBox.BackColor = Color.Transparent;
			signupRequestsPictureBox.BackgroundImage = Properties.Resources.user_add;
			signupRequestsPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			signupRequestsPictureBox.Location = new Point(29, 16);
			signupRequestsPictureBox.Name = "signupRequestsPictureBox";
			signupRequestsPictureBox.Size = new Size(27, 22);
			signupRequestsPictureBox.TabIndex = 1;
			signupRequestsPictureBox.TabStop = false;
			// 
			// signupRequestsLabel
			// 
			signupRequestsLabel.AutoSize = true;
			signupRequestsLabel.BackColor = Color.Transparent;
			signupRequestsLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			signupRequestsLabel.ForeColor = Color.White;
			signupRequestsLabel.Location = new Point(64, 12);
			signupRequestsLabel.Name = "signupRequestsLabel";
			signupRequestsLabel.Size = new Size(239, 30);
			signupRequestsLabel.TabIndex = 0;
			signupRequestsLabel.Text = "Demandes d'Inscription";
			// 
			// manageInternsPanel
			// 
			manageInternsPanel.Controls.Add(manageInternsPictureBox);
			manageInternsPanel.Controls.Add(manageInternsLabel);
			manageInternsPanel.Location = new Point(0, 196);
			manageInternsPanel.Name = "manageInternsPanel";
			manageInternsPanel.Size = new Size(316, 56);
			manageInternsPanel.TabIndex = 6;
			manageInternsPanel.Click += manageInternsPanel_Click;
			manageInternsPanel.MouseEnter += manageInternsPanel_MouseEnter;
			manageInternsPanel.MouseLeave += manageInternsPanel_MouseLeave;
			// 
			// manageInternsPictureBox
			// 
			manageInternsPictureBox.BackColor = Color.Transparent;
			manageInternsPictureBox.BackgroundImage = Properties.Resources.users;
			manageInternsPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			manageInternsPictureBox.Location = new Point(29, 16);
			manageInternsPictureBox.Name = "manageInternsPictureBox";
			manageInternsPictureBox.Size = new Size(27, 22);
			manageInternsPictureBox.TabIndex = 1;
			manageInternsPictureBox.TabStop = false;
			// 
			// manageInternsLabel
			// 
			manageInternsLabel.AutoSize = true;
			manageInternsLabel.BackColor = Color.Transparent;
			manageInternsLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			manageInternsLabel.ForeColor = Color.White;
			manageInternsLabel.Location = new Point(64, 12);
			manageInternsLabel.Name = "manageInternsLabel";
			manageInternsLabel.Size = new Size(213, 30);
			manageInternsLabel.TabIndex = 0;
			manageInternsLabel.Text = "Gestion de Stagiaires";
			// 
			// navigationSelectorPanel
			// 
			navigationSelectorPanel.BackColor = Color.FromArgb(138, 192, 84);
			navigationSelectorPanel.Location = new Point(0, 0);
			navigationSelectorPanel.Name = "navigationSelectorPanel";
			navigationSelectorPanel.Size = new Size(5, 56);
			navigationSelectorPanel.TabIndex = 2;
			// 
			// dashboardPanel
			// 
			dashboardPanel.Controls.Add(dashboardLogoPictureBox);
			dashboardPanel.Controls.Add(dashboardLabel);
			dashboardPanel.Location = new Point(0, 126);
			dashboardPanel.Name = "dashboardPanel";
			dashboardPanel.Size = new Size(316, 56);
			dashboardPanel.TabIndex = 5;
			dashboardPanel.Click += dashboardPanel_Click;
			dashboardPanel.MouseEnter += dashboardPanel_MouseEnter;
			dashboardPanel.MouseLeave += dashboardPanel_MouseLeave;
			// 
			// dashboardLogoPictureBox
			// 
			dashboardLogoPictureBox.BackColor = Color.Transparent;
			dashboardLogoPictureBox.BackgroundImage = Properties.Resources.dashboard_white1;
			dashboardLogoPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			dashboardLogoPictureBox.Location = new Point(30, 15);
			dashboardLogoPictureBox.Name = "dashboardLogoPictureBox";
			dashboardLogoPictureBox.Size = new Size(25, 25);
			dashboardLogoPictureBox.TabIndex = 1;
			dashboardLogoPictureBox.TabStop = false;
			// 
			// dashboardLabel
			// 
			dashboardLabel.AutoSize = true;
			dashboardLabel.BackColor = Color.Transparent;
			dashboardLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			dashboardLabel.ForeColor = Color.White;
			dashboardLabel.Location = new Point(64, 12);
			dashboardLabel.Name = "dashboardLabel";
			dashboardLabel.Size = new Size(169, 30);
			dashboardLabel.TabIndex = 0;
			dashboardLabel.Text = "Tableau de Bord";
			// 
			// horizontalSeparator
			// 
			horizontalSeparator.BackColor = Color.FromArgb(37, 37, 37);
			horizontalSeparator.ForeColor = Color.Transparent;
			horizontalSeparator.Location = new Point(0, 109);
			horizontalSeparator.Name = "horizontalSeparator";
			horizontalSeparator.Size = new Size(316, 3);
			horizontalSeparator.TabIndex = 2;
			// 
			// logoutPanel
			// 
			logoutPanel.BackColor = Color.FromArgb(232, 86, 63);
			logoutPanel.Controls.Add(logoutLabel);
			logoutPanel.Controls.Add(logoutIcon);
			logoutPanel.Location = new Point(37, 620);
			logoutPanel.Name = "logoutPanel";
			logoutPanel.Size = new Size(242, 49);
			logoutPanel.TabIndex = 1;
			logoutPanel.Click += logoutPanel_Click;
			logoutPanel.MouseEnter += logoutPanel_MouseEnter;
			logoutPanel.MouseLeave += logoutPanel_MouseLeave;
			// 
			// logoutLabel
			// 
			logoutLabel.AutoSize = true;
			logoutLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			logoutLabel.ForeColor = Color.White;
			logoutLabel.Location = new Point(58, 8);
			logoutLabel.Name = "logoutLabel";
			logoutLabel.Size = new Size(160, 30);
			logoutLabel.TabIndex = 1;
			logoutLabel.Text = "Se déconnecter";
			// 
			// logoutIcon
			// 
			logoutIcon.BackgroundImage = Properties.Resources.logout_white;
			logoutIcon.BackgroundImageLayout = ImageLayout.Stretch;
			logoutIcon.Location = new Point(21, 9);
			logoutIcon.Name = "logoutIcon";
			logoutIcon.Size = new Size(30, 30);
			logoutIcon.TabIndex = 0;
			logoutIcon.TabStop = false;
			// 
			// logoPictureBox
			// 
			logoPictureBox.BackgroundImage = Properties.Resources.logo_white;
			logoPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			logoPictureBox.Location = new Point(72, 27);
			logoPictureBox.Name = "logoPictureBox";
			logoPictureBox.Size = new Size(172, 56);
			logoPictureBox.TabIndex = 0;
			logoPictureBox.TabStop = false;
			// 
			// titleBarPanel
			// 
			titleBarPanel.Controls.Add(panel1);
			titleBarPanel.Controls.Add(titleLabel);
			titleBarPanel.Location = new Point(316, 0);
			titleBarPanel.Name = "titleBarPanel";
			titleBarPanel.Size = new Size(949, 83);
			titleBarPanel.TabIndex = 1;
			// 
			// titleLabel
			// 
			titleLabel.AutoSize = true;
			titleLabel.BackColor = Color.Transparent;
			titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
			titleLabel.Location = new Point(41, 19);
			titleLabel.Name = "titleLabel";
			titleLabel.Size = new Size(264, 45);
			titleLabel.TabIndex = 0;
			titleLabel.Text = "Tableau de Bord";
			// 
			// contentPlaceholderPanel
			// 
			contentPlaceholderPanel.Location = new Point(316, 83);
			contentPlaceholderPanel.Name = "contentPlaceholderPanel";
			contentPlaceholderPanel.Size = new Size(949, 598);
			contentPlaceholderPanel.TabIndex = 2;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(100, 108, 119);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 81);
			panel1.Name = "panel1";
			panel1.Size = new Size(949, 2);
			panel1.TabIndex = 1;
			// 
			// layoutFrm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(244, 246, 249);
			ClientSize = new Size(1264, 681);
			Controls.Add(contentPlaceholderPanel);
			Controls.Add(titleBarPanel);
			Controls.Add(sideNavBar);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "layoutFrm";
			Text = "Tableau de bord • OCP";
			FormClosed += layoutFrm_FormClosed;
			Load += layoutFrm_Load;
			sideNavBar.ResumeLayout(false);
			signupRequestsPanel.ResumeLayout(false);
			signupRequestsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)signupRequestsPictureBox).EndInit();
			manageInternsPanel.ResumeLayout(false);
			manageInternsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)manageInternsPictureBox).EndInit();
			dashboardPanel.ResumeLayout(false);
			dashboardPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dashboardLogoPictureBox).EndInit();
			logoutPanel.ResumeLayout(false);
			logoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)logoutIcon).EndInit();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			titleBarPanel.ResumeLayout(false);
			titleBarPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel sideNavBar;
		private PictureBox logoPictureBox;
		private Panel logoutPanel;
		private PictureBox logoutIcon;
		private Label logoutLabel;
		private Panel horizontalSeparator;
		private Panel dashboardPanel;
		private Label dashboardLabel;
		private PictureBox dashboardLogoPictureBox;
		private Panel navigationSelectorPanel;
		private Panel manageInternsPanel;
		private PictureBox manageInternsPictureBox;
		private Label manageInternsLabel;
		private Panel signupRequestsPanel;
		private PictureBox signupRequestsPictureBox;
		private Label signupRequestsLabel;
		private Panel titleBarPanel;
		private Label titleLabel;
		private Panel contentPlaceholderPanel;
		private Panel panel1;
	}
}