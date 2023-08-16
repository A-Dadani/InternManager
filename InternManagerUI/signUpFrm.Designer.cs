namespace InternManagerUI
{
	partial class signUpFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUpFrm));
			backroundSmallPanel = new Panel();
			successMessageLabel = new Label();
			nameWarnLabel = new Label();
			passwordConfirmationWarnLabel = new Label();
			passwordConfirmTextBox = new MaskedTextBox();
			lastNameTextBox = new MaskedTextBox();
			firstNameTextBox = new MaskedTextBox();
			passwordWarnLabel = new Label();
			createRequestLinkLabel = new LinkLabel();
			noAccountLabel = new Label();
			signUpButton = new Button();
			emailWarnLabel = new Label();
			passwordTextBox = new MaskedTextBox();
			emailTextBox = new MaskedTextBox();
			seConnecterLabel = new Label();
			logoPictureBox = new PictureBox();
			backroundSmallPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			SuspendLayout();
			// 
			// backroundSmallPanel
			// 
			backroundSmallPanel.Controls.Add(successMessageLabel);
			backroundSmallPanel.Controls.Add(nameWarnLabel);
			backroundSmallPanel.Controls.Add(passwordConfirmationWarnLabel);
			backroundSmallPanel.Controls.Add(passwordConfirmTextBox);
			backroundSmallPanel.Controls.Add(lastNameTextBox);
			backroundSmallPanel.Controls.Add(firstNameTextBox);
			backroundSmallPanel.Controls.Add(passwordWarnLabel);
			backroundSmallPanel.Controls.Add(createRequestLinkLabel);
			backroundSmallPanel.Controls.Add(noAccountLabel);
			backroundSmallPanel.Controls.Add(signUpButton);
			backroundSmallPanel.Controls.Add(emailWarnLabel);
			backroundSmallPanel.Controls.Add(passwordTextBox);
			backroundSmallPanel.Controls.Add(emailTextBox);
			backroundSmallPanel.Controls.Add(seConnecterLabel);
			backroundSmallPanel.Controls.Add(logoPictureBox);
			backroundSmallPanel.Location = new Point(333, 46);
			backroundSmallPanel.Name = "backroundSmallPanel";
			backroundSmallPanel.Size = new Size(598, 588);
			backroundSmallPanel.TabIndex = 1;
			// 
			// successMessageLabel
			// 
			successMessageLabel.AutoSize = true;
			successMessageLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			successMessageLabel.ForeColor = Color.FromArgb(138, 192, 84);
			successMessageLabel.Location = new Point(37, 505);
			successMessageLabel.Name = "successMessageLabel";
			successMessageLabel.Size = new Size(287, 20);
			successMessageLabel.TabIndex = 14;
			successMessageLabel.Text = "Votre demande a été créée avec succès. ";
			successMessageLabel.Visible = false;
			// 
			// nameWarnLabel
			// 
			nameWarnLabel.AutoSize = true;
			nameWarnLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			nameWarnLabel.ForeColor = Color.FromArgb(217, 68, 82);
			nameWarnLabel.Location = new Point(37, 222);
			nameWarnLabel.Name = "nameWarnLabel";
			nameWarnLabel.Size = new Size(325, 20);
			nameWarnLabel.TabIndex = 13;
			nameWarnLabel.Text = "Le nom et le prénom ne peuvent pas êtres vides";
			nameWarnLabel.Visible = false;
			// 
			// passwordConfirmationWarnLabel
			// 
			passwordConfirmationWarnLabel.AutoSize = true;
			passwordConfirmationWarnLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			passwordConfirmationWarnLabel.ForeColor = Color.FromArgb(217, 68, 82);
			passwordConfirmationWarnLabel.Location = new Point(37, 423);
			passwordConfirmationWarnLabel.Name = "passwordConfirmationWarnLabel";
			passwordConfirmationWarnLabel.Size = new Size(354, 20);
			passwordConfirmationWarnLabel.TabIndex = 12;
			passwordConfirmationWarnLabel.Text = "La confirmation n'est pas identique au mot de passe";
			passwordConfirmationWarnLabel.Visible = false;
			// 
			// passwordConfirmTextBox
			// 
			passwordConfirmTextBox.BackColor = Color.White;
			passwordConfirmTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			passwordConfirmTextBox.ForeColor = Color.FromArgb(100, 108, 119);
			passwordConfirmTextBox.Location = new Point(37, 385);
			passwordConfirmTextBox.Name = "passwordConfirmTextBox";
			passwordConfirmTextBox.Size = new Size(524, 35);
			passwordConfirmTextBox.TabIndex = 4;
			passwordConfirmTextBox.Text = "Confirmer le mot de passe";
			passwordConfirmTextBox.Enter += passwordConfirmTextBox_Enter;
			passwordConfirmTextBox.Leave += passwordConfirmTextBox_Leave;
			// 
			// lastNameTextBox
			// 
			lastNameTextBox.BackColor = Color.White;
			lastNameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lastNameTextBox.ForeColor = Color.FromArgb(100, 108, 119);
			lastNameTextBox.Location = new Point(302, 184);
			lastNameTextBox.Name = "lastNameTextBox";
			lastNameTextBox.Size = new Size(259, 35);
			lastNameTextBox.TabIndex = 1;
			lastNameTextBox.Text = "Nom";
			lastNameTextBox.Enter += lastNameTextBox_Enter;
			lastNameTextBox.Leave += lastNameTextBox_Leave;
			// 
			// firstNameTextBox
			// 
			firstNameTextBox.BackColor = Color.White;
			firstNameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			firstNameTextBox.ForeColor = Color.FromArgb(100, 108, 119);
			firstNameTextBox.Location = new Point(37, 184);
			firstNameTextBox.Name = "firstNameTextBox";
			firstNameTextBox.Size = new Size(259, 35);
			firstNameTextBox.TabIndex = 0;
			firstNameTextBox.Text = "Prénom";
			firstNameTextBox.Enter += firstNameTextBox_Enter;
			firstNameTextBox.Leave += firstNameTextBox_Leave;
			// 
			// passwordWarnLabel
			// 
			passwordWarnLabel.AutoSize = true;
			passwordWarnLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			passwordWarnLabel.ForeColor = Color.FromArgb(217, 68, 82);
			passwordWarnLabel.Location = new Point(37, 356);
			passwordWarnLabel.Name = "passwordWarnLabel";
			passwordWarnLabel.Size = new Size(355, 20);
			passwordWarnLabel.TabIndex = 8;
			passwordWarnLabel.Text = "Le mot de passe doit contenir au moin 8 charactères";
			passwordWarnLabel.Visible = false;
			// 
			// createRequestLinkLabel
			// 
			createRequestLinkLabel.AutoSize = true;
			createRequestLinkLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			createRequestLinkLabel.Location = new Point(239, 527);
			createRequestLinkLabel.Name = "createRequestLinkLabel";
			createRequestLinkLabel.Size = new Size(125, 21);
			createRequestLinkLabel.TabIndex = 6;
			createRequestLinkLabel.TabStop = true;
			createRequestLinkLabel.Text = "Connectez vous";
			createRequestLinkLabel.Click += createRequestLinkLabel_Click;
			// 
			// noAccountLabel
			// 
			noAccountLabel.AutoSize = true;
			noAccountLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			noAccountLabel.Location = new Point(37, 527);
			noAccountLabel.Name = "noAccountLabel";
			noAccountLabel.Size = new Size(206, 21);
			noAccountLabel.TabIndex = 6;
			noAccountLabel.Text = "Vous avez déjà un compte?";
			// 
			// signUpButton
			// 
			signUpButton.BackColor = Color.FromArgb(138, 192, 84);
			signUpButton.FlatAppearance.BorderSize = 0;
			signUpButton.FlatStyle = FlatStyle.Flat;
			signUpButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			signUpButton.ForeColor = Color.White;
			signUpButton.Location = new Point(37, 452);
			signUpButton.Name = "signUpButton";
			signUpButton.Size = new Size(192, 50);
			signUpButton.TabIndex = 5;
			signUpButton.Text = "Créer un compte";
			signUpButton.UseVisualStyleBackColor = false;
			signUpButton.Click += signUpButton_Click;
			// 
			// emailWarnLabel
			// 
			emailWarnLabel.AutoSize = true;
			emailWarnLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			emailWarnLabel.ForeColor = Color.FromArgb(217, 68, 82);
			emailWarnLabel.Location = new Point(37, 289);
			emailWarnLabel.Name = "emailWarnLabel";
			emailWarnLabel.Size = new Size(270, 20);
			emailWarnLabel.TabIndex = 4;
			emailWarnLabel.Text = "Veuillez entrer une adresse email valide";
			emailWarnLabel.Visible = false;
			// 
			// passwordTextBox
			// 
			passwordTextBox.BackColor = Color.White;
			passwordTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			passwordTextBox.ForeColor = Color.FromArgb(100, 108, 119);
			passwordTextBox.Location = new Point(37, 318);
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.Size = new Size(524, 35);
			passwordTextBox.TabIndex = 3;
			passwordTextBox.Text = "Mot de passe";
			passwordTextBox.Enter += passwordTextBox_Enter;
			passwordTextBox.Leave += passwordTextBox_Leave;
			// 
			// emailTextBox
			// 
			emailTextBox.BackColor = Color.White;
			emailTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			emailTextBox.ForeColor = Color.FromArgb(100, 108, 119);
			emailTextBox.Location = new Point(37, 251);
			emailTextBox.Name = "emailTextBox";
			emailTextBox.Size = new Size(524, 35);
			emailTextBox.TabIndex = 2;
			emailTextBox.Text = "Adresse E-mail";
			emailTextBox.Enter += emailTextBox_Enter;
			emailTextBox.Leave += emailTextBox_Leave;
			// 
			// seConnecterLabel
			// 
			seConnecterLabel.AutoSize = true;
			seConnecterLabel.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
			seConnecterLabel.ForeColor = Color.FromArgb(27, 27, 27);
			seConnecterLabel.Location = new Point(29, 117);
			seConnecterLabel.Name = "seConnecterLabel";
			seConnecterLabel.Size = new Size(304, 50);
			seConnecterLabel.TabIndex = 0;
			seConnecterLabel.Text = "Créer un compte";
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
			// signUpFrm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.login_background;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1264, 681);
			Controls.Add(backroundSmallPanel);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "signUpFrm";
			Text = "Créer un compte • OCP";
			FormClosed += signUpFrm_FormClosed;
			Shown += signUpFrm_Shown;
			backroundSmallPanel.ResumeLayout(false);
			backroundSmallPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel backroundSmallPanel;
		private Label passwordWarnLabel;
		private LinkLabel createRequestLinkLabel;
		private Label noAccountLabel;
		private Button signUpButton;
		private Label emailWarnLabel;
		private MaskedTextBox passwordTextBox;
		private MaskedTextBox emailTextBox;
		private Label seConnecterLabel;
		private PictureBox logoPictureBox;
		private MaskedTextBox lastNameTextBox;
		private MaskedTextBox firstNameTextBox;
		private Label passwordConfirmationWarnLabel;
		private MaskedTextBox passwordConfirmTextBox;
		private Label nameWarnLabel;
		private Label successMessageLabel;
	}
}