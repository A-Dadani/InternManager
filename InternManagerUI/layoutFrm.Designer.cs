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
			logoutPanel = new Panel();
			logoutLabel = new Label();
			logoutIcon = new PictureBox();
			logoPictureBox = new PictureBox();
			sideNavBar.SuspendLayout();
			logoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logoutIcon).BeginInit();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			SuspendLayout();
			// 
			// sideNavBar
			// 
			sideNavBar.BackColor = Color.FromArgb(13, 13, 13);
			sideNavBar.Controls.Add(logoutPanel);
			sideNavBar.Controls.Add(logoPictureBox);
			sideNavBar.Dock = DockStyle.Left;
			sideNavBar.Location = new Point(0, 0);
			sideNavBar.Name = "sideNavBar";
			sideNavBar.Size = new Size(290, 681);
			sideNavBar.TabIndex = 0;
			// 
			// logoutPanel
			// 
			logoutPanel.BackColor = Color.FromArgb(232, 86, 63);
			logoutPanel.Controls.Add(logoutLabel);
			logoutPanel.Controls.Add(logoutIcon);
			logoutPanel.Location = new Point(23, 620);
			logoutPanel.Name = "logoutPanel";
			logoutPanel.Size = new Size(242, 49);
			logoutPanel.TabIndex = 1;
			logoutPanel.Click += logoutPanel_Click;
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
			logoPictureBox.Location = new Point(59, 27);
			logoPictureBox.Name = "logoPictureBox";
			logoPictureBox.Size = new Size(172, 56);
			logoPictureBox.TabIndex = 0;
			logoPictureBox.TabStop = false;
			// 
			// layoutFrm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(244, 246, 249);
			ClientSize = new Size(1264, 681);
			Controls.Add(sideNavBar);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "layoutFrm";
			Text = "Tableau de bord • OCP";
			FormClosed += layoutFrm_FormClosed;
			Load += layoutFrm_Load;
			sideNavBar.ResumeLayout(false);
			logoutPanel.ResumeLayout(false);
			logoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)logoutIcon).EndInit();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel sideNavBar;
		private PictureBox logoPictureBox;
		private Panel logoutPanel;
		private PictureBox logoutIcon;
		private Label logoutLabel;
	}
}