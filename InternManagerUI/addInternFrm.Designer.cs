namespace InternManagerUI
{
	partial class addInternFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addInternFrm));
			topStickyBannerPanel = new Panel();
			titleLabel = new Label();
			horSeparatorPanel = new Panel();
			parentPanel = new Panel();
			warnLabel = new Label();
			submitPanel = new Panel();
			label1 = new Label();
			parrainTextBox = new TextBox();
			parrainLabel = new Label();
			directionAccueilTextBox = new TextBox();
			directionAccueilLabel = new Label();
			entiteAccueilTextBox = new TextBox();
			entiteAccueilLabel = new Label();
			internshipTypeComboBox = new ComboBox();
			internshipTypeLabel = new Label();
			internshipInfoLabel = new Label();
			studyBranchTextBox = new TextBox();
			studyBranchLabel = new Label();
			studyYearTextBox = new TextBox();
			studyYearLabel = new Label();
			schoolTextBox = new TextBox();
			schoolLabel = new Label();
			CNITextBox = new TextBox();
			CNILabel = new Label();
			personalInfoLabel = new Label();
			endDateLabel = new Label();
			endDatePicker = new DateTimePicker();
			startDateLabel = new Label();
			startDatePicker = new DateTimePicker();
			lastNameTextBox = new TextBox();
			lastNameLabel = new Label();
			firstNameTextBox = new TextBox();
			firstNameLabel = new Label();
			civiliteComboBox = new ComboBox();
			civiliteLabel = new Label();
			topStickyBannerPanel.SuspendLayout();
			parentPanel.SuspendLayout();
			submitPanel.SuspendLayout();
			SuspendLayout();
			// 
			// topStickyBannerPanel
			// 
			topStickyBannerPanel.BackColor = Color.FromArgb(244, 246, 249);
			topStickyBannerPanel.Controls.Add(titleLabel);
			topStickyBannerPanel.Dock = DockStyle.Top;
			topStickyBannerPanel.Location = new Point(0, 0);
			topStickyBannerPanel.Name = "topStickyBannerPanel";
			topStickyBannerPanel.Size = new Size(800, 70);
			topStickyBannerPanel.TabIndex = 0;
			// 
			// titleLabel
			// 
			titleLabel.AutoSize = true;
			titleLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
			titleLabel.Location = new Point(22, 13);
			titleLabel.Name = "titleLabel";
			titleLabel.Size = new Size(308, 45);
			titleLabel.TabIndex = 0;
			titleLabel.Text = "Ajouter un stagiaire";
			// 
			// horSeparatorPanel
			// 
			horSeparatorPanel.BackColor = Color.FromArgb(100, 108, 119);
			horSeparatorPanel.Dock = DockStyle.Top;
			horSeparatorPanel.Location = new Point(0, 70);
			horSeparatorPanel.Name = "horSeparatorPanel";
			horSeparatorPanel.Size = new Size(800, 2);
			horSeparatorPanel.TabIndex = 1;
			// 
			// parentPanel
			// 
			parentPanel.AutoScroll = true;
			parentPanel.BackColor = Color.White;
			parentPanel.Controls.Add(warnLabel);
			parentPanel.Controls.Add(submitPanel);
			parentPanel.Controls.Add(parrainTextBox);
			parentPanel.Controls.Add(parrainLabel);
			parentPanel.Controls.Add(directionAccueilTextBox);
			parentPanel.Controls.Add(directionAccueilLabel);
			parentPanel.Controls.Add(entiteAccueilTextBox);
			parentPanel.Controls.Add(entiteAccueilLabel);
			parentPanel.Controls.Add(internshipTypeComboBox);
			parentPanel.Controls.Add(internshipTypeLabel);
			parentPanel.Controls.Add(internshipInfoLabel);
			parentPanel.Controls.Add(studyBranchTextBox);
			parentPanel.Controls.Add(studyBranchLabel);
			parentPanel.Controls.Add(studyYearTextBox);
			parentPanel.Controls.Add(studyYearLabel);
			parentPanel.Controls.Add(schoolTextBox);
			parentPanel.Controls.Add(schoolLabel);
			parentPanel.Controls.Add(CNITextBox);
			parentPanel.Controls.Add(CNILabel);
			parentPanel.Controls.Add(personalInfoLabel);
			parentPanel.Controls.Add(endDateLabel);
			parentPanel.Controls.Add(endDatePicker);
			parentPanel.Controls.Add(startDateLabel);
			parentPanel.Controls.Add(startDatePicker);
			parentPanel.Controls.Add(lastNameTextBox);
			parentPanel.Controls.Add(lastNameLabel);
			parentPanel.Controls.Add(firstNameTextBox);
			parentPanel.Controls.Add(firstNameLabel);
			parentPanel.Controls.Add(civiliteComboBox);
			parentPanel.Controls.Add(civiliteLabel);
			parentPanel.Dock = DockStyle.Fill;
			parentPanel.Location = new Point(0, 72);
			parentPanel.Name = "parentPanel";
			parentPanel.Size = new Size(800, 546);
			parentPanel.TabIndex = 2;
			// 
			// warnLabel
			// 
			warnLabel.AutoSize = true;
			warnLabel.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			warnLabel.ForeColor = Color.FromArgb(232, 86, 63);
			warnLabel.Location = new Point(61, 912);
			warnLabel.Name = "warnLabel";
			warnLabel.Padding = new Padding(0, 0, 0, 10);
			warnLabel.Size = new Size(12, 35);
			warnLabel.TabIndex = 28;
			warnLabel.Text = "‎";
			// 
			// submitPanel
			// 
			submitPanel.BackColor = Color.FromArgb(138, 192, 84);
			submitPanel.Controls.Add(label1);
			submitPanel.Location = new Point(61, 862);
			submitPanel.Name = "submitPanel";
			submitPanel.Size = new Size(678, 47);
			submitPanel.TabIndex = 27;
			submitPanel.Click += submitPanel_Click;
			submitPanel.MouseEnter += submitPanel_MouseEnter;
			submitPanel.MouseLeave += submitPanel_MouseLeave;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(267, 3);
			label1.Name = "label1";
			label1.Size = new Size(146, 37);
			label1.TabIndex = 0;
			label1.Text = "Soumettre";
			// 
			// parrainTextBox
			// 
			parrainTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			parrainTextBox.Location = new Point(61, 802);
			parrainTextBox.Name = "parrainTextBox";
			parrainTextBox.Size = new Size(308, 31);
			parrainTextBox.TabIndex = 12;
			// 
			// parrainLabel
			// 
			parrainLabel.AutoSize = true;
			parrainLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			parrainLabel.Location = new Point(61, 769);
			parrainLabel.Name = "parrainLabel";
			parrainLabel.Size = new Size(77, 30);
			parrainLabel.TabIndex = 25;
			parrainLabel.Text = "Parrain";
			// 
			// directionAccueilTextBox
			// 
			directionAccueilTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			directionAccueilTextBox.Location = new Point(431, 640);
			directionAccueilTextBox.Name = "directionAccueilTextBox";
			directionAccueilTextBox.Size = new Size(308, 31);
			directionAccueilTextBox.TabIndex = 9;
			// 
			// directionAccueilLabel
			// 
			directionAccueilLabel.AutoSize = true;
			directionAccueilLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			directionAccueilLabel.Location = new Point(431, 607);
			directionAccueilLabel.Name = "directionAccueilLabel";
			directionAccueilLabel.Size = new Size(184, 30);
			directionAccueilLabel.TabIndex = 23;
			directionAccueilLabel.Text = "Direction d'accueil";
			// 
			// entiteAccueilTextBox
			// 
			entiteAccueilTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			entiteAccueilTextBox.Location = new Point(61, 640);
			entiteAccueilTextBox.Name = "entiteAccueilTextBox";
			entiteAccueilTextBox.Size = new Size(308, 31);
			entiteAccueilTextBox.TabIndex = 8;
			// 
			// entiteAccueilLabel
			// 
			entiteAccueilLabel.AutoSize = true;
			entiteAccueilLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			entiteAccueilLabel.Location = new Point(61, 607);
			entiteAccueilLabel.Name = "entiteAccueilLabel";
			entiteAccueilLabel.Size = new Size(153, 30);
			entiteAccueilLabel.TabIndex = 21;
			entiteAccueilLabel.Text = "Entité d'accueil";
			// 
			// internshipTypeComboBox
			// 
			internshipTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			internshipTypeComboBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			internshipTypeComboBox.FormattingEnabled = true;
			internshipTypeComboBox.Items.AddRange(new object[] { "PFE", "PFA", "Observation" });
			internshipTypeComboBox.Location = new Point(61, 559);
			internshipTypeComboBox.Name = "internshipTypeComboBox";
			internshipTypeComboBox.Size = new Size(308, 31);
			internshipTypeComboBox.TabIndex = 7;
			// 
			// internshipTypeLabel
			// 
			internshipTypeLabel.AutoSize = true;
			internshipTypeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			internshipTypeLabel.Location = new Point(61, 526);
			internshipTypeLabel.Name = "internshipTypeLabel";
			internshipTypeLabel.Size = new Size(141, 30);
			internshipTypeLabel.TabIndex = 20;
			internshipTypeLabel.Text = "Type de stage";
			// 
			// internshipInfoLabel
			// 
			internshipInfoLabel.AutoSize = true;
			internshipInfoLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			internshipInfoLabel.Location = new Point(33, 481);
			internshipInfoLabel.Name = "internshipInfoLabel";
			internshipInfoLabel.Size = new Size(321, 37);
			internshipInfoLabel.TabIndex = 19;
			internshipInfoLabel.Text = "Informations sur le stage";
			// 
			// studyBranchTextBox
			// 
			studyBranchTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			studyBranchTextBox.Location = new Point(431, 423);
			studyBranchTextBox.Name = "studyBranchTextBox";
			studyBranchTextBox.Size = new Size(308, 31);
			studyBranchTextBox.TabIndex = 6;
			// 
			// studyBranchLabel
			// 
			studyBranchLabel.AutoSize = true;
			studyBranchLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			studyBranchLabel.Location = new Point(431, 390);
			studyBranchLabel.Name = "studyBranchLabel";
			studyBranchLabel.Size = new Size(101, 30);
			studyBranchLabel.TabIndex = 17;
			studyBranchLabel.Text = "Spécialité";
			// 
			// studyYearTextBox
			// 
			studyYearTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			studyYearTextBox.Location = new Point(61, 423);
			studyYearTextBox.Name = "studyYearTextBox";
			studyYearTextBox.Size = new Size(308, 31);
			studyYearTextBox.TabIndex = 5;
			// 
			// studyYearLabel
			// 
			studyYearLabel.AutoSize = true;
			studyYearLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			studyYearLabel.Location = new Point(61, 390);
			studyYearLabel.Name = "studyYearLabel";
			studyYearLabel.Size = new Size(269, 30);
			studyYearLabel.TabIndex = 15;
			studyYearLabel.Text = "Année d'étude (chiffre seul)";
			// 
			// schoolTextBox
			// 
			schoolTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			schoolTextBox.Location = new Point(61, 342);
			schoolTextBox.Name = "schoolTextBox";
			schoolTextBox.Size = new Size(308, 31);
			schoolTextBox.TabIndex = 4;
			// 
			// schoolLabel
			// 
			schoolLabel.AutoSize = true;
			schoolLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			schoolLabel.Location = new Point(61, 309);
			schoolLabel.Name = "schoolLabel";
			schoolLabel.Size = new Size(62, 30);
			schoolLabel.TabIndex = 13;
			schoolLabel.Text = "École";
			// 
			// CNITextBox
			// 
			CNITextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			CNITextBox.Location = new Point(61, 261);
			CNITextBox.Name = "CNITextBox";
			CNITextBox.Size = new Size(308, 31);
			CNITextBox.TabIndex = 3;
			// 
			// CNILabel
			// 
			CNILabel.AutoSize = true;
			CNILabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			CNILabel.Location = new Point(61, 228);
			CNILabel.Name = "CNILabel";
			CNILabel.Size = new Size(48, 30);
			CNILabel.TabIndex = 11;
			CNILabel.Text = "CNI";
			// 
			// personalInfoLabel
			// 
			personalInfoLabel.AutoSize = true;
			personalInfoLabel.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			personalInfoLabel.Location = new Point(33, 23);
			personalInfoLabel.Name = "personalInfoLabel";
			personalInfoLabel.Size = new Size(336, 37);
			personalInfoLabel.TabIndex = 10;
			personalInfoLabel.Text = "Informations personnelles";
			// 
			// endDateLabel
			// 
			endDateLabel.AutoSize = true;
			endDateLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			endDateLabel.Location = new Point(431, 688);
			endDateLabel.Name = "endDateLabel";
			endDateLabel.Size = new Size(172, 30);
			endDateLabel.TabIndex = 9;
			endDateLabel.Text = "Date fin de stage";
			// 
			// endDatePicker
			// 
			endDatePicker.CalendarFont = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			endDatePicker.CustomFormat = "";
			endDatePicker.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			endDatePicker.Location = new Point(431, 721);
			endDatePicker.Name = "endDatePicker";
			endDatePicker.Size = new Size(308, 31);
			endDatePicker.TabIndex = 11;
			// 
			// startDateLabel
			// 
			startDateLabel.AutoSize = true;
			startDateLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			startDateLabel.Location = new Point(61, 688);
			startDateLabel.Name = "startDateLabel";
			startDateLabel.Size = new Size(202, 30);
			startDateLabel.TabIndex = 7;
			startDateLabel.Text = "Date début de stage";
			// 
			// startDatePicker
			// 
			startDatePicker.CalendarFont = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			startDatePicker.CustomFormat = "";
			startDatePicker.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			startDatePicker.Location = new Point(61, 721);
			startDatePicker.Name = "startDatePicker";
			startDatePicker.Size = new Size(308, 31);
			startDatePicker.TabIndex = 10;
			// 
			// lastNameTextBox
			// 
			lastNameTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			lastNameTextBox.Location = new Point(431, 180);
			lastNameTextBox.Name = "lastNameTextBox";
			lastNameTextBox.Size = new Size(308, 31);
			lastNameTextBox.TabIndex = 2;
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lastNameLabel.Location = new Point(431, 147);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new Size(59, 30);
			lastNameLabel.TabIndex = 4;
			lastNameLabel.Text = "Nom";
			// 
			// firstNameTextBox
			// 
			firstNameTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			firstNameTextBox.Location = new Point(61, 180);
			firstNameTextBox.Name = "firstNameTextBox";
			firstNameTextBox.Size = new Size(308, 31);
			firstNameTextBox.TabIndex = 1;
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			firstNameLabel.Location = new Point(61, 147);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new Size(85, 30);
			firstNameLabel.TabIndex = 2;
			firstNameLabel.Text = "Prénom";
			// 
			// civiliteComboBox
			// 
			civiliteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			civiliteComboBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
			civiliteComboBox.FormattingEnabled = true;
			civiliteComboBox.Items.AddRange(new object[] { "Madame", "Monsieur" });
			civiliteComboBox.Location = new Point(61, 99);
			civiliteComboBox.Name = "civiliteComboBox";
			civiliteComboBox.Size = new Size(308, 31);
			civiliteComboBox.TabIndex = 0;
			// 
			// civiliteLabel
			// 
			civiliteLabel.AutoSize = true;
			civiliteLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			civiliteLabel.Location = new Point(61, 66);
			civiliteLabel.Name = "civiliteLabel";
			civiliteLabel.Size = new Size(74, 30);
			civiliteLabel.TabIndex = 0;
			civiliteLabel.Text = "Civilité";
			// 
			// addInternFrm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 618);
			Controls.Add(parentPanel);
			Controls.Add(horSeparatorPanel);
			Controls.Add(topStickyBannerPanel);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "addInternFrm";
			Text = "Ajouter un stagiaire • OCP";
			topStickyBannerPanel.ResumeLayout(false);
			topStickyBannerPanel.PerformLayout();
			parentPanel.ResumeLayout(false);
			parentPanel.PerformLayout();
			submitPanel.ResumeLayout(false);
			submitPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel topStickyBannerPanel;
		private Label titleLabel;
		private Panel horSeparatorPanel;
		private Panel parentPanel;
		private Label civiliteLabel;
		private ComboBox civiliteComboBox;
		private TextBox firstNameTextBox;
		private Label firstNameLabel;
		private TextBox lastNameTextBox;
		private Label lastNameLabel;
		private DateTimePicker startDatePicker;
		private Label startDateLabel;
		private Label endDateLabel;
		private DateTimePicker endDatePicker;
		private Label personalInfoLabel;
		private TextBox CNITextBox;
		private Label CNILabel;
		private TextBox schoolTextBox;
		private Label schoolLabel;
		private TextBox studyBranchTextBox;
		private Label studyBranchLabel;
		private TextBox studyYearTextBox;
		private Label studyYearLabel;
		private Label internshipInfoLabel;
		private Label internshipTypeLabel;
		private ComboBox internshipTypeComboBox;
		private TextBox directionAccueilTextBox;
		private Label directionAccueilLabel;
		private TextBox entiteAccueilTextBox;
		private Label entiteAccueilLabel;
		private TextBox parrainTextBox;
		private Label parrainLabel;
		private Panel submitPanel;
		private Label label1;
		private Label warnLabel;
	}
}