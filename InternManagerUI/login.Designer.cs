namespace InternManagerUI
{
	partial class login
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
			backroundSmallPanel = new Panel();
			credentialsWarnLabel = new Label();
			createRequestLinkLabel = new LinkLabel();
			noAccountLabel = new Label();
			signInButton = new Button();
			emailWarnLabel = new Label();
			passwordMaskedTextBox = new MaskedTextBox();
			emailMaskedTextBox = new MaskedTextBox();
			seConnecterLabel = new Label();
			logoPictureBox = new PictureBox();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			backroundSmallPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			SuspendLayout();
			// 
			// backroundSmallPanel
			// 
			backroundSmallPanel.Controls.Add(credentialsWarnLabel);
			backroundSmallPanel.Controls.Add(createRequestLinkLabel);
			backroundSmallPanel.Controls.Add(noAccountLabel);
			backroundSmallPanel.Controls.Add(signInButton);
			backroundSmallPanel.Controls.Add(emailWarnLabel);
			backroundSmallPanel.Controls.Add(passwordMaskedTextBox);
			backroundSmallPanel.Controls.Add(emailMaskedTextBox);
			backroundSmallPanel.Controls.Add(seConnecterLabel);
			backroundSmallPanel.Controls.Add(logoPictureBox);
			backroundSmallPanel.Location = new Point(333, 104);
			backroundSmallPanel.Name = "backroundSmallPanel";
			backroundSmallPanel.Size = new Size(598, 473);
			backroundSmallPanel.TabIndex = 0;
			// 
			// credentialsWarnLabel
			// 
			credentialsWarnLabel.AutoSize = true;
			credentialsWarnLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			credentialsWarnLabel.ForeColor = Color.FromArgb(217, 68, 82);
			credentialsWarnLabel.Location = new Point(37, 293);
			credentialsWarnLabel.Name = "credentialsWarnLabel";
			credentialsWarnLabel.Size = new Size(237, 20);
			credentialsWarnLabel.TabIndex = 8;
			credentialsWarnLabel.Text = "E-mail ou mot de passe pas valide";
			credentialsWarnLabel.Visible = false;
			// 
			// createRequestLinkLabel
			// 
			createRequestLinkLabel.AutoSize = true;
			createRequestLinkLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			createRequestLinkLabel.Location = new Point(244, 400);
			createRequestLinkLabel.Name = "createRequestLinkLabel";
			createRequestLinkLabel.Size = new Size(155, 21);
			createRequestLinkLabel.TabIndex = 7;
			createRequestLinkLabel.TabStop = true;
			createRequestLinkLabel.Text = "Créez une demande";
			// 
			// noAccountLabel
			// 
			noAccountLabel.AutoSize = true;
			noAccountLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			noAccountLabel.Location = new Point(37, 400);
			noAccountLabel.Name = "noAccountLabel";
			noAccountLabel.Size = new Size(213, 21);
			noAccountLabel.TabIndex = 6;
			noAccountLabel.Text = "Vous n'avez pas de compte?";
			// 
			// signInButton
			// 
			signInButton.BackColor = Color.FromArgb(138, 192, 84);
			signInButton.FlatAppearance.BorderSize = 0;
			signInButton.FlatStyle = FlatStyle.Flat;
			signInButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			signInButton.ForeColor = Color.White;
			signInButton.Location = new Point(37, 320);
			signInButton.Name = "signInButton";
			signInButton.Size = new Size(175, 50);
			signInButton.TabIndex = 5;
			signInButton.Text = "Se connecter";
			signInButton.UseVisualStyleBackColor = false;
			signInButton.Click += signInButton_Click;
			// 
			// emailWarnLabel
			// 
			emailWarnLabel.AutoSize = true;
			emailWarnLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			emailWarnLabel.ForeColor = Color.FromArgb(217, 68, 82);
			emailWarnLabel.Location = new Point(37, 228);
			emailWarnLabel.Name = "emailWarnLabel";
			emailWarnLabel.Size = new Size(270, 20);
			emailWarnLabel.TabIndex = 4;
			emailWarnLabel.Text = "Veuillez entrer une adresse email valide";
			emailWarnLabel.Visible = false;
			// 
			// passwordMaskedTextBox
			// 
			passwordMaskedTextBox.BackColor = Color.White;
			passwordMaskedTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			passwordMaskedTextBox.ForeColor = Color.FromArgb(100, 108, 119);
			passwordMaskedTextBox.Location = new Point(37, 255);
			passwordMaskedTextBox.Name = "passwordMaskedTextBox";
			passwordMaskedTextBox.Size = new Size(524, 35);
			passwordMaskedTextBox.TabIndex = 3;
			passwordMaskedTextBox.Text = "Mot de passe";
			passwordMaskedTextBox.Enter += passwordMaskedTextBox_Enter;
			passwordMaskedTextBox.Leave += passwordMaskedTextBox_Leave;
			// 
			// emailMaskedTextBox
			// 
			emailMaskedTextBox.BackColor = Color.White;
			emailMaskedTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			emailMaskedTextBox.ForeColor = Color.FromArgb(100, 108, 119);
			emailMaskedTextBox.Location = new Point(37, 190);
			emailMaskedTextBox.Name = "emailMaskedTextBox";
			emailMaskedTextBox.Size = new Size(524, 35);
			emailMaskedTextBox.TabIndex = 2;
			emailMaskedTextBox.Text = "Adresse E-mail";
			emailMaskedTextBox.Enter += emailMaskedTextBox_Enter;
			emailMaskedTextBox.Leave += emailMaskedTextBox_Leave;
			// 
			// seConnecterLabel
			// 
			seConnecterLabel.AutoSize = true;
			seConnecterLabel.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
			seConnecterLabel.ForeColor = Color.FromArgb(27, 27, 27);
			seConnecterLabel.Location = new Point(29, 117);
			seConnecterLabel.Name = "seConnecterLabel";
			seConnecterLabel.Size = new Size(245, 50);
			seConnecterLabel.TabIndex = 1;
			seConnecterLabel.Text = "Se Connecter";
			// 
			// logoPictureBox
			// 
			logoPictureBox.BackgroundImage = (Image)resources.GetObject("logoPictureBox.BackgroundImage");
			logoPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			logoPictureBox.Location = new Point(29, 35);
			logoPictureBox.Name = "logoPictureBox";
			logoPictureBox.Size = new Size(200, 65);
			logoPictureBox.TabIndex = 0;
			logoPictureBox.TabStop = false;
			// 
			// login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(244, 246, 249);
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1264, 681);
			Controls.Add(backroundSmallPanel);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(3, 2, 3, 2);
			MaximizeBox = false;
			Name = "login";
			Text = "Gestionnaire de Stagiaires • OCP";
			Shown += login_Shown;
			backroundSmallPanel.ResumeLayout(false);
			backroundSmallPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel backroundSmallPanel;
		private PictureBox logoPictureBox;
		private Label seConnecterLabel;
		private MaskedTextBox emailMaskedTextBox;
		private MaskedTextBox passwordMaskedTextBox;
		private Label emailWarnLabel;
		private Button signInButton;
		private LinkLabel createRequestLinkLabel;
		private Label noAccountLabel;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Label credentialsWarnLabel;
	}
}