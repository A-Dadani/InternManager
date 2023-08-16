namespace InternManagerUI
{
	partial class detailedInternViewFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detailedInternViewFrm));
			headerPanel = new Panel();
			printPanel = new Panel();
			printLogo = new PictureBox();
			printLabel = new Label();
			deletePanel = new Panel();
			deleteLogoPictureBox = new PictureBox();
			deleteLabel = new Label();
			bigNameLabel = new Label();
			horSperatorPanel = new Panel();
			bodyPanel = new Panel();
			civiliteLabel = new Label();
			label15 = new Label();
			parrainLabel = new Label();
			endYearLabel = new Label();
			startYearLabel = new Label();
			directionAccueilLabel = new Label();
			entiteAccueilLabel = new Label();
			internshipTypeLabel = new Label();
			studyBranchLabel = new Label();
			studyYearLabel = new Label();
			ecoleLabel = new Label();
			CNILabel = new Label();
			firstNameLabel = new Label();
			lastNameLabel = new Label();
			label13 = new Label();
			label12 = new Label();
			label11 = new Label();
			label10 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			personalInfoLabel = new Label();
			headerPanel.SuspendLayout();
			printPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)printLogo).BeginInit();
			deletePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)deleteLogoPictureBox).BeginInit();
			bodyPanel.SuspendLayout();
			SuspendLayout();
			// 
			// headerPanel
			// 
			headerPanel.BackColor = Color.FromArgb(229, 232, 236);
			headerPanel.Controls.Add(printPanel);
			headerPanel.Controls.Add(deletePanel);
			headerPanel.Controls.Add(bigNameLabel);
			headerPanel.Dock = DockStyle.Top;
			headerPanel.Location = new Point(0, 0);
			headerPanel.Name = "headerPanel";
			headerPanel.Size = new Size(1077, 67);
			headerPanel.TabIndex = 0;
			// 
			// printPanel
			// 
			printPanel.BackColor = Color.FromArgb(59, 137, 218);
			printPanel.Controls.Add(printLogo);
			printPanel.Controls.Add(printLabel);
			printPanel.Location = new Point(722, 11);
			printPanel.Name = "printPanel";
			printPanel.Size = new Size(150, 44);
			printPanel.TabIndex = 3;
			printPanel.Click += printPanel_Click;
			printPanel.MouseEnter += printPanel_MouseEnter;
			printPanel.MouseLeave += printPanel_MouseLeave;
			// 
			// printLogo
			// 
			printLogo.BackColor = Color.Transparent;
			printLogo.BackgroundImage = Properties.Resources.printer_white;
			printLogo.BackgroundImageLayout = ImageLayout.Stretch;
			printLogo.Location = new Point(21, 11);
			printLogo.Name = "printLogo";
			printLogo.Size = new Size(21, 21);
			printLogo.TabIndex = 2;
			printLogo.TabStop = false;
			// 
			// printLabel
			// 
			printLabel.AutoSize = true;
			printLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			printLabel.ForeColor = Color.White;
			printLabel.Location = new Point(43, 8);
			printLabel.Name = "printLabel";
			printLabel.Size = new Size(92, 25);
			printLabel.TabIndex = 1;
			printLabel.Text = "Imprimer";
			// 
			// deletePanel
			// 
			deletePanel.BackColor = Color.FromArgb(232, 86, 63);
			deletePanel.Controls.Add(deleteLogoPictureBox);
			deletePanel.Controls.Add(deleteLabel);
			deletePanel.Location = new Point(888, 11);
			deletePanel.Name = "deletePanel";
			deletePanel.Size = new Size(173, 44);
			deletePanel.TabIndex = 2;
			deletePanel.Click += deletePanel_Click;
			deletePanel.MouseEnter += deletePanel_MouseEnter;
			deletePanel.MouseLeave += deletePanel_MouseLeave;
			// 
			// deleteLogoPictureBox
			// 
			deleteLogoPictureBox.BackColor = Color.Transparent;
			deleteLogoPictureBox.BackgroundImage = Properties.Resources.trash_can_solid_white;
			deleteLogoPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			deleteLogoPictureBox.Location = new Point(28, 11);
			deleteLogoPictureBox.Name = "deleteLogoPictureBox";
			deleteLogoPictureBox.Size = new Size(18, 21);
			deleteLogoPictureBox.TabIndex = 2;
			deleteLogoPictureBox.TabStop = false;
			// 
			// deleteLabel
			// 
			deleteLabel.AutoSize = true;
			deleteLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			deleteLabel.ForeColor = Color.White;
			deleteLabel.Location = new Point(49, 8);
			deleteLabel.Name = "deleteLabel";
			deleteLabel.Size = new Size(101, 25);
			deleteLabel.TabIndex = 1;
			deleteLabel.Text = "Supprimer";
			// 
			// bigNameLabel
			// 
			bigNameLabel.AutoSize = true;
			bigNameLabel.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
			bigNameLabel.Location = new Point(32, 10);
			bigNameLabel.Name = "bigNameLabel";
			bigNameLabel.Size = new Size(174, 47);
			bigNameLabel.TabIndex = 0;
			bigNameLabel.Text = "DOE John";
			// 
			// horSperatorPanel
			// 
			horSperatorPanel.BackColor = Color.FromArgb(66, 73, 83);
			horSperatorPanel.Dock = DockStyle.Top;
			horSperatorPanel.Location = new Point(0, 67);
			horSperatorPanel.Name = "horSperatorPanel";
			horSperatorPanel.Size = new Size(1077, 2);
			horSperatorPanel.TabIndex = 1;
			// 
			// bodyPanel
			// 
			bodyPanel.Controls.Add(civiliteLabel);
			bodyPanel.Controls.Add(label15);
			bodyPanel.Controls.Add(parrainLabel);
			bodyPanel.Controls.Add(endYearLabel);
			bodyPanel.Controls.Add(startYearLabel);
			bodyPanel.Controls.Add(directionAccueilLabel);
			bodyPanel.Controls.Add(entiteAccueilLabel);
			bodyPanel.Controls.Add(internshipTypeLabel);
			bodyPanel.Controls.Add(studyBranchLabel);
			bodyPanel.Controls.Add(studyYearLabel);
			bodyPanel.Controls.Add(ecoleLabel);
			bodyPanel.Controls.Add(CNILabel);
			bodyPanel.Controls.Add(firstNameLabel);
			bodyPanel.Controls.Add(lastNameLabel);
			bodyPanel.Controls.Add(label13);
			bodyPanel.Controls.Add(label12);
			bodyPanel.Controls.Add(label11);
			bodyPanel.Controls.Add(label10);
			bodyPanel.Controls.Add(label9);
			bodyPanel.Controls.Add(label8);
			bodyPanel.Controls.Add(label7);
			bodyPanel.Controls.Add(label6);
			bodyPanel.Controls.Add(label5);
			bodyPanel.Controls.Add(label4);
			bodyPanel.Controls.Add(label3);
			bodyPanel.Controls.Add(label2);
			bodyPanel.Controls.Add(label1);
			bodyPanel.Controls.Add(personalInfoLabel);
			bodyPanel.Dock = DockStyle.Fill;
			bodyPanel.Location = new Point(0, 69);
			bodyPanel.Name = "bodyPanel";
			bodyPanel.Size = new Size(1077, 549);
			bodyPanel.TabIndex = 2;
			// 
			// civiliteLabel
			// 
			civiliteLabel.AutoSize = true;
			civiliteLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			civiliteLabel.Location = new Point(178, 125);
			civiliteLabel.Name = "civiliteLabel";
			civiliteLabel.Size = new Size(81, 25);
			civiliteLabel.TabIndex = 27;
			civiliteLabel.Text = "<none>";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label15.Location = new Point(106, 125);
			label15.Name = "label15";
			label15.Size = new Size(76, 25);
			label15.TabIndex = 26;
			label15.Text = "Civilité:";
			// 
			// parrainLabel
			// 
			parrainLabel.AutoSize = true;
			parrainLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			parrainLabel.Location = new Point(179, 500);
			parrainLabel.Name = "parrainLabel";
			parrainLabel.Size = new Size(81, 25);
			parrainLabel.TabIndex = 25;
			parrainLabel.Text = "<none>";
			// 
			// endYearLabel
			// 
			endYearLabel.AutoSize = true;
			endYearLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			endYearLabel.Location = new Point(188, 467);
			endYearLabel.Name = "endYearLabel";
			endYearLabel.Size = new Size(81, 25);
			endYearLabel.TabIndex = 24;
			endYearLabel.Text = "<none>";
			// 
			// startYearLabel
			// 
			startYearLabel.AutoSize = true;
			startYearLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			startYearLabel.Location = new Point(215, 434);
			startYearLabel.Name = "startYearLabel";
			startYearLabel.Size = new Size(81, 25);
			startYearLabel.TabIndex = 23;
			startYearLabel.Text = "<none>";
			// 
			// directionAccueilLabel
			// 
			directionAccueilLabel.AutoSize = true;
			directionAccueilLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			directionAccueilLabel.Location = new Point(278, 401);
			directionAccueilLabel.Name = "directionAccueilLabel";
			directionAccueilLabel.Size = new Size(81, 25);
			directionAccueilLabel.TabIndex = 22;
			directionAccueilLabel.Text = "<none>";
			// 
			// entiteAccueilLabel
			// 
			entiteAccueilLabel.AutoSize = true;
			entiteAccueilLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			entiteAccueilLabel.Location = new Point(249, 368);
			entiteAccueilLabel.Name = "entiteAccueilLabel";
			entiteAccueilLabel.Size = new Size(81, 25);
			entiteAccueilLabel.TabIndex = 21;
			entiteAccueilLabel.Text = "<none>";
			// 
			// internshipTypeLabel
			// 
			internshipTypeLabel.AutoSize = true;
			internshipTypeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			internshipTypeLabel.Location = new Point(236, 335);
			internshipTypeLabel.Name = "internshipTypeLabel";
			internshipTypeLabel.Size = new Size(81, 25);
			internshipTypeLabel.TabIndex = 20;
			internshipTypeLabel.Text = "<none>";
			// 
			// studyBranchLabel
			// 
			studyBranchLabel.AutoSize = true;
			studyBranchLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			studyBranchLabel.Location = new Point(201, 257);
			studyBranchLabel.Name = "studyBranchLabel";
			studyBranchLabel.Size = new Size(81, 25);
			studyBranchLabel.TabIndex = 19;
			studyBranchLabel.Text = "<none>";
			// 
			// studyYearLabel
			// 
			studyYearLabel.AutoSize = true;
			studyYearLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			studyYearLabel.Location = new Point(244, 224);
			studyYearLabel.Name = "studyYearLabel";
			studyYearLabel.Size = new Size(81, 25);
			studyYearLabel.TabIndex = 18;
			studyYearLabel.Text = "<none>";
			// 
			// ecoleLabel
			// 
			ecoleLabel.AutoSize = true;
			ecoleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			ecoleLabel.Location = new Point(162, 191);
			ecoleLabel.Name = "ecoleLabel";
			ecoleLabel.Size = new Size(81, 25);
			ecoleLabel.TabIndex = 17;
			ecoleLabel.Text = "<none>";
			// 
			// CNILabel
			// 
			CNILabel.AutoSize = true;
			CNILabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			CNILabel.Location = new Point(152, 158);
			CNILabel.Name = "CNILabel";
			CNILabel.Size = new Size(81, 25);
			CNILabel.TabIndex = 16;
			CNILabel.Text = "<none>";
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			firstNameLabel.Location = new Point(186, 92);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new Size(81, 25);
			firstNameLabel.TabIndex = 15;
			firstNameLabel.Text = "<none>";
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lastNameLabel.Location = new Point(162, 59);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new Size(81, 25);
			lastNameLabel.TabIndex = 14;
			lastNameLabel.Text = "<none>";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label13.Location = new Point(106, 500);
			label13.Name = "label13";
			label13.Size = new Size(77, 25);
			label13.TabIndex = 13;
			label13.Text = "Parrain:";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label12.Location = new Point(106, 467);
			label12.Name = "label12";
			label12.Size = new Size(86, 25);
			label12.TabIndex = 12;
			label12.Text = "Date fin:";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label11.Location = new Point(106, 434);
			label11.Name = "label11";
			label11.Size = new Size(113, 25);
			label11.TabIndex = 11;
			label11.Text = "Date début:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label10.Location = new Point(106, 401);
			label10.Name = "label10";
			label10.Size = new Size(176, 25);
			label10.TabIndex = 10;
			label10.Text = "Direction d'accueil:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label9.Location = new Point(106, 368);
			label9.Name = "label9";
			label9.Size = new Size(147, 25);
			label9.TabIndex = 9;
			label9.Text = "Entité d'accueil:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label8.Location = new Point(106, 335);
			label8.Name = "label8";
			label8.Size = new Size(134, 25);
			label8.TabIndex = 8;
			label8.Text = "Type de stage:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(32, 290);
			label7.Name = "label7";
			label7.Size = new Size(321, 37);
			label7.TabIndex = 7;
			label7.Text = "Informations sur le stage";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(106, 257);
			label6.Name = "label6";
			label6.Size = new Size(99, 25);
			label6.TabIndex = 6;
			label6.Text = "Spécialité:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(106, 224);
			label5.Name = "label5";
			label5.Size = new Size(142, 25);
			label5.TabIndex = 5;
			label5.Text = "Année d'étude:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(106, 191);
			label4.Name = "label4";
			label4.Size = new Size(62, 25);
			label4.TabIndex = 4;
			label4.Text = "École:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(106, 158);
			label3.Name = "label3";
			label3.Size = new Size(50, 25);
			label3.TabIndex = 3;
			label3.Text = "CNI:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(106, 92);
			label2.Name = "label2";
			label2.Size = new Size(84, 25);
			label2.TabIndex = 2;
			label2.Text = "Prénom:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(106, 59);
			label1.Name = "label1";
			label1.Size = new Size(60, 25);
			label1.TabIndex = 1;
			label1.Text = "Nom:";
			// 
			// personalInfoLabel
			// 
			personalInfoLabel.AutoSize = true;
			personalInfoLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			personalInfoLabel.Location = new Point(32, 14);
			personalInfoLabel.Name = "personalInfoLabel";
			personalInfoLabel.Size = new Size(336, 37);
			personalInfoLabel.TabIndex = 0;
			personalInfoLabel.Text = "Informations personnelles";
			// 
			// detailedInternViewFrm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1077, 618);
			Controls.Add(bodyPanel);
			Controls.Add(horSperatorPanel);
			Controls.Add(headerPanel);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "detailedInternViewFrm";
			Text = "detailedInternViewFrm";
			headerPanel.ResumeLayout(false);
			headerPanel.PerformLayout();
			printPanel.ResumeLayout(false);
			printPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)printLogo).EndInit();
			deletePanel.ResumeLayout(false);
			deletePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)deleteLogoPictureBox).EndInit();
			bodyPanel.ResumeLayout(false);
			bodyPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel headerPanel;
		private Label bigNameLabel;
		private Panel horSperatorPanel;
		private Panel bodyPanel;
		private Label personalInfoLabel;
		private Panel deletePanel;
		private Label deleteLabel;
		private PictureBox deleteLogoPictureBox;
		private Panel printPanel;
		private PictureBox printLogo;
		private Label printLabel;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label8;
		private Label label13;
		private Label label12;
		private Label label11;
		private Label label10;
		private Label label9;
		private Label studyBranchLabel;
		private Label studyYearLabel;
		private Label ecoleLabel;
		private Label CNILabel;
		private Label firstNameLabel;
		private Label lastNameLabel;
		private Label parrainLabel;
		private Label endYearLabel;
		private Label startYearLabel;
		private Label directionAccueilLabel;
		private Label entiteAccueilLabel;
		private Label internshipTypeLabel;
		private Label civiliteLabel;
		private Label label15;
	}
}