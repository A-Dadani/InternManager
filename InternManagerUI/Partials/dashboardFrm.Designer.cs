namespace InternManagerUI.Partials
{
	partial class dashboardFrm
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
			PFAPanel = new Panel();
			PFACountLabel = new Label();
			PFApersonnesLabel = new Label();
			PFATitleLabel = new Label();
			PFEPanel = new Panel();
			PFECountLabel = new Label();
			PFEpersonnesLabel = new Label();
			PFETitleLabel = new Label();
			obsPanel = new Panel();
			obsCountLabel = new Label();
			obsPersonnesLabel = new Label();
			obsTitleLabel = new Label();
			adminsPanel = new Panel();
			adminCountLabel = new Label();
			adminsPersonnesLabel = new Label();
			adminsTitleLabel = new Label();
			PFAPanel.SuspendLayout();
			PFEPanel.SuspendLayout();
			obsPanel.SuspendLayout();
			adminsPanel.SuspendLayout();
			SuspendLayout();
			// 
			// PFAPanel
			// 
			PFAPanel.BackColor = Color.FromArgb(244, 246, 249);
			PFAPanel.BorderStyle = BorderStyle.FixedSingle;
			PFAPanel.Controls.Add(PFACountLabel);
			PFAPanel.Controls.Add(PFApersonnesLabel);
			PFAPanel.Controls.Add(PFATitleLabel);
			PFAPanel.Location = new Point(505, 101);
			PFAPanel.Name = "PFAPanel";
			PFAPanel.Size = new Size(380, 165);
			PFAPanel.TabIndex = 3;
			// 
			// PFACountLabel
			// 
			PFACountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			PFACountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			PFACountLabel.ForeColor = Color.FromArgb(138, 192, 84);
			PFACountLabel.Location = new Point(143, 106);
			PFACountLabel.Name = "PFACountLabel";
			PFACountLabel.Size = new Size(79, 37);
			PFACountLabel.TabIndex = 1;
			PFACountLabel.Text = "...";
			PFACountLabel.TextAlign = ContentAlignment.TopRight;
			// 
			// PFApersonnesLabel
			// 
			PFApersonnesLabel.AutoSize = true;
			PFApersonnesLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			PFApersonnesLabel.Location = new Point(215, 106);
			PFApersonnesLabel.Name = "PFApersonnesLabel";
			PFApersonnesLabel.Size = new Size(143, 37);
			PFApersonnesLabel.TabIndex = 2;
			PFApersonnesLabel.Text = "personnes";
			// 
			// PFATitleLabel
			// 
			PFATitleLabel.AutoSize = true;
			PFATitleLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			PFATitleLabel.Location = new Point(18, 21);
			PFATitleLabel.MaximumSize = new Size(350, 0);
			PFATitleLabel.Name = "PFATitleLabel";
			PFATitleLabel.Size = new Size(324, 74);
			PFATitleLabel.TabIndex = 0;
			PFATitleLabel.Text = "Le nombre de personnes en stage PFA: ";
			// 
			// PFEPanel
			// 
			PFEPanel.BackColor = Color.FromArgb(244, 246, 249);
			PFEPanel.BorderStyle = BorderStyle.FixedSingle;
			PFEPanel.Controls.Add(PFECountLabel);
			PFEPanel.Controls.Add(PFEpersonnesLabel);
			PFEPanel.Controls.Add(PFETitleLabel);
			PFEPanel.Location = new Point(64, 101);
			PFEPanel.Name = "PFEPanel";
			PFEPanel.Size = new Size(380, 165);
			PFEPanel.TabIndex = 4;
			// 
			// PFECountLabel
			// 
			PFECountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			PFECountLabel.ForeColor = Color.FromArgb(138, 192, 84);
			PFECountLabel.Location = new Point(141, 106);
			PFECountLabel.Name = "PFECountLabel";
			PFECountLabel.Size = new Size(83, 37);
			PFECountLabel.TabIndex = 1;
			PFECountLabel.Text = "...";
			PFECountLabel.TextAlign = ContentAlignment.TopRight;
			// 
			// PFEpersonnesLabel
			// 
			PFEpersonnesLabel.AutoSize = true;
			PFEpersonnesLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			PFEpersonnesLabel.Location = new Point(215, 106);
			PFEpersonnesLabel.Name = "PFEpersonnesLabel";
			PFEpersonnesLabel.Size = new Size(143, 37);
			PFEpersonnesLabel.TabIndex = 2;
			PFEpersonnesLabel.Text = "personnes";
			// 
			// PFETitleLabel
			// 
			PFETitleLabel.AutoSize = true;
			PFETitleLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			PFETitleLabel.Location = new Point(18, 21);
			PFETitleLabel.MaximumSize = new Size(350, 0);
			PFETitleLabel.Name = "PFETitleLabel";
			PFETitleLabel.Size = new Size(324, 74);
			PFETitleLabel.TabIndex = 0;
			PFETitleLabel.Text = "Le nombre de personnes en stage PFE: ";
			// 
			// obsPanel
			// 
			obsPanel.BackColor = Color.FromArgb(244, 246, 249);
			obsPanel.BorderStyle = BorderStyle.FixedSingle;
			obsPanel.Controls.Add(obsCountLabel);
			obsPanel.Controls.Add(obsPersonnesLabel);
			obsPanel.Controls.Add(obsTitleLabel);
			obsPanel.Location = new Point(64, 333);
			obsPanel.Name = "obsPanel";
			obsPanel.Size = new Size(380, 165);
			obsPanel.TabIndex = 5;
			// 
			// obsCountLabel
			// 
			obsCountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			obsCountLabel.ForeColor = Color.FromArgb(138, 192, 84);
			obsCountLabel.Location = new Point(141, 106);
			obsCountLabel.Name = "obsCountLabel";
			obsCountLabel.Size = new Size(83, 37);
			obsCountLabel.TabIndex = 1;
			obsCountLabel.Text = "...";
			obsCountLabel.TextAlign = ContentAlignment.TopRight;
			// 
			// obsPersonnesLabel
			// 
			obsPersonnesLabel.AutoSize = true;
			obsPersonnesLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			obsPersonnesLabel.Location = new Point(215, 106);
			obsPersonnesLabel.Name = "obsPersonnesLabel";
			obsPersonnesLabel.Size = new Size(143, 37);
			obsPersonnesLabel.TabIndex = 2;
			obsPersonnesLabel.Text = "personnes";
			// 
			// obsTitleLabel
			// 
			obsTitleLabel.AutoSize = true;
			obsTitleLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			obsTitleLabel.Location = new Point(18, 21);
			obsTitleLabel.MaximumSize = new Size(350, 0);
			obsTitleLabel.Name = "obsTitleLabel";
			obsTitleLabel.Size = new Size(324, 74);
			obsTitleLabel.TabIndex = 0;
			obsTitleLabel.Text = "Le nombre de personnes en stage d'observation: ";
			// 
			// adminsPanel
			// 
			adminsPanel.BackColor = Color.FromArgb(244, 246, 249);
			adminsPanel.BorderStyle = BorderStyle.FixedSingle;
			adminsPanel.Controls.Add(adminCountLabel);
			adminsPanel.Controls.Add(adminsPersonnesLabel);
			adminsPanel.Controls.Add(adminsTitleLabel);
			adminsPanel.Location = new Point(505, 333);
			adminsPanel.Name = "adminsPanel";
			adminsPanel.Size = new Size(380, 165);
			adminsPanel.TabIndex = 6;
			// 
			// adminCountLabel
			// 
			adminCountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			adminCountLabel.ForeColor = Color.FromArgb(138, 192, 84);
			adminCountLabel.Location = new Point(141, 106);
			adminCountLabel.Name = "adminCountLabel";
			adminCountLabel.Size = new Size(83, 37);
			adminCountLabel.TabIndex = 1;
			adminCountLabel.Text = "...";
			adminCountLabel.TextAlign = ContentAlignment.TopRight;
			// 
			// adminsPersonnesLabel
			// 
			adminsPersonnesLabel.AutoSize = true;
			adminsPersonnesLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			adminsPersonnesLabel.Location = new Point(215, 106);
			adminsPersonnesLabel.Name = "adminsPersonnesLabel";
			adminsPersonnesLabel.Size = new Size(143, 37);
			adminsPersonnesLabel.TabIndex = 2;
			adminsPersonnesLabel.Text = "personnes";
			// 
			// adminsTitleLabel
			// 
			adminsTitleLabel.AutoSize = true;
			adminsTitleLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			adminsTitleLabel.Location = new Point(18, 21);
			adminsTitleLabel.MaximumSize = new Size(350, 0);
			adminsTitleLabel.Name = "adminsTitleLabel";
			adminsTitleLabel.Size = new Size(246, 74);
			adminsTitleLabel.TabIndex = 0;
			adminsTitleLabel.Text = "Le nombre d'administrateurs: ";
			// 
			// dashboardFrm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(949, 598);
			Controls.Add(adminsPanel);
			Controls.Add(obsPanel);
			Controls.Add(PFEPanel);
			Controls.Add(PFAPanel);
			Name = "dashboardFrm";
			Text = "dashboardFrm";
			PFAPanel.ResumeLayout(false);
			PFAPanel.PerformLayout();
			PFEPanel.ResumeLayout(false);
			PFEPanel.PerformLayout();
			obsPanel.ResumeLayout(false);
			obsPanel.PerformLayout();
			adminsPanel.ResumeLayout(false);
			adminsPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Panel PFAPanel;
		private Label PFACountLabel;
		private Label PFApersonnesLabel;
		private Label PFATitleLabel;
		private Panel PFEPanel;
		private Label PFECountLabel;
		private Label PFEpersonnesLabel;
		private Label PFETitleLabel;
		private Panel obsPanel;
		private Label obsCountLabel;
		private Label obsPersonnesLabel;
		private Label obsTitleLabel;
		private Panel adminsPanel;
		private Label adminCountLabel;
		private Label adminsPersonnesLabel;
		private Label adminsTitleLabel;
	}
}