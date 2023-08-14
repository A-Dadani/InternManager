namespace InternManagerUI.Partials
{
	partial class manageInternsFrm
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
			loadingPanel = new Panel();
			loadingLabel = new Label();
			loadingPictureBox = new PictureBox();
			emptyListPanel = new Panel();
			emptyListLabel = new Label();
			emptyListLogo = new PictureBox();
			searchTextBox = new TextBox();
			parentPanel = new Panel();
			searchPanel = new Panel();
			searchPictureBox = new PictureBox();
			seachButtonLabel = new Label();
			addPanel = new Panel();
			addPictureBox = new PictureBox();
			addLabel = new Label();
			topParentPanel = new Panel();
			horSeparatorPanel = new Panel();
			loadingPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)loadingPictureBox).BeginInit();
			emptyListPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)emptyListLogo).BeginInit();
			parentPanel.SuspendLayout();
			searchPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)searchPictureBox).BeginInit();
			addPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)addPictureBox).BeginInit();
			topParentPanel.SuspendLayout();
			SuspendLayout();
			// 
			// loadingPanel
			// 
			loadingPanel.Controls.Add(loadingLabel);
			loadingPanel.Controls.Add(loadingPictureBox);
			loadingPanel.Location = new Point(175, 226);
			loadingPanel.Name = "loadingPanel";
			loadingPanel.Size = new Size(598, 84);
			loadingPanel.TabIndex = 1;
			// 
			// loadingLabel
			// 
			loadingLabel.AutoSize = true;
			loadingLabel.Font = new Font("Segoe UI Semibold", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
			loadingLabel.Location = new Point(69, 27);
			loadingLabel.Name = "loadingLabel";
			loadingLabel.Size = new Size(494, 31);
			loadingLabel.TabIndex = 1;
			loadingLabel.Text = "Chargement de la liste de stagiaires en cours...";
			// 
			// loadingPictureBox
			// 
			loadingPictureBox.BackgroundImage = Properties.Resources.clock_regular;
			loadingPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			loadingPictureBox.Location = new Point(36, 27);
			loadingPictureBox.Name = "loadingPictureBox";
			loadingPictureBox.Size = new Size(30, 30);
			loadingPictureBox.TabIndex = 0;
			loadingPictureBox.TabStop = false;
			// 
			// emptyListPanel
			// 
			emptyListPanel.Controls.Add(emptyListLabel);
			emptyListPanel.Controls.Add(emptyListLogo);
			emptyListPanel.Location = new Point(281, 226);
			emptyListPanel.Name = "emptyListPanel";
			emptyListPanel.Size = new Size(386, 84);
			emptyListPanel.TabIndex = 2;
			emptyListPanel.Visible = false;
			// 
			// emptyListLabel
			// 
			emptyListLabel.AutoSize = true;
			emptyListLabel.Font = new Font("Segoe UI Semibold", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
			emptyListLabel.Location = new Point(53, 27);
			emptyListLabel.Name = "emptyListLabel";
			emptyListLabel.Size = new Size(314, 31);
			emptyListLabel.TabIndex = 1;
			emptyListLabel.Text = "La liste de stagiaires est vide.";
			// 
			// emptyListLogo
			// 
			emptyListLogo.BackgroundImage = Properties.Resources.info;
			emptyListLogo.BackgroundImageLayout = ImageLayout.Stretch;
			emptyListLogo.Location = new Point(20, 27);
			emptyListLogo.Name = "emptyListLogo";
			emptyListLogo.Size = new Size(30, 30);
			emptyListLogo.TabIndex = 0;
			emptyListLogo.TabStop = false;
			// 
			// searchTextBox
			// 
			searchTextBox.BackColor = Color.FromArgb(244, 246, 249);
			searchTextBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			searchTextBox.ForeColor = Color.FromArgb(100, 108, 119);
			searchTextBox.Location = new Point(20, 13);
			searchTextBox.Name = "searchTextBox";
			searchTextBox.Size = new Size(517, 35);
			searchTextBox.TabIndex = 3;
			searchTextBox.Text = "Rechercher...";
			searchTextBox.Enter += searchTextBox_Enter;
			searchTextBox.KeyDown += searchTextBox_KeyDown;
			searchTextBox.Leave += searchTextBox_Leave;
			// 
			// parentPanel
			// 
			parentPanel.AutoScroll = true;
			parentPanel.Controls.Add(emptyListPanel);
			parentPanel.Controls.Add(loadingPanel);
			parentPanel.Dock = DockStyle.Bottom;
			parentPanel.Location = new Point(0, 62);
			parentPanel.Margin = new Padding(0);
			parentPanel.Name = "parentPanel";
			parentPanel.Size = new Size(949, 536);
			parentPanel.TabIndex = 5;
			// 
			// searchPanel
			// 
			searchPanel.BackColor = Color.FromArgb(138, 192, 84);
			searchPanel.Controls.Add(searchPictureBox);
			searchPanel.Controls.Add(seachButtonLabel);
			searchPanel.Location = new Point(543, 13);
			searchPanel.Name = "searchPanel";
			searchPanel.Size = new Size(190, 35);
			searchPanel.TabIndex = 4;
			searchPanel.Click += searchPanel_Click;
			searchPanel.MouseEnter += searchPanel_MouseEnter;
			searchPanel.MouseLeave += searchPanel_MouseLeave;
			// 
			// searchPictureBox
			// 
			searchPictureBox.BackColor = Color.Transparent;
			searchPictureBox.BackgroundImage = Properties.Resources.magnifying_glass_white;
			searchPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			searchPictureBox.Location = new Point(35, 7);
			searchPictureBox.Name = "searchPictureBox";
			searchPictureBox.Size = new Size(20, 20);
			searchPictureBox.TabIndex = 1;
			searchPictureBox.TabStop = false;
			// 
			// seachButtonLabel
			// 
			seachButtonLabel.AutoSize = true;
			seachButtonLabel.BackColor = Color.Transparent;
			seachButtonLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			seachButtonLabel.ForeColor = Color.White;
			seachButtonLabel.Location = new Point(54, 5);
			seachButtonLabel.Name = "seachButtonLabel";
			seachButtonLabel.Size = new Size(107, 25);
			seachButtonLabel.TabIndex = 0;
			seachButtonLabel.Text = "Rechercher";
			// 
			// addPanel
			// 
			addPanel.BackColor = Color.FromArgb(75, 137, 218);
			addPanel.Controls.Add(addPictureBox);
			addPanel.Controls.Add(addLabel);
			addPanel.Location = new Point(739, 13);
			addPanel.Name = "addPanel";
			addPanel.Size = new Size(190, 35);
			addPanel.TabIndex = 5;
			addPanel.MouseEnter += addPanel_MouseEnter;
			addPanel.MouseLeave += addPanel_MouseLeave;
			// 
			// addPictureBox
			// 
			addPictureBox.BackgroundImage = Properties.Resources.plus_white;
			addPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			addPictureBox.Location = new Point(50, 7);
			addPictureBox.Name = "addPictureBox";
			addPictureBox.Size = new Size(20, 20);
			addPictureBox.TabIndex = 1;
			addPictureBox.TabStop = false;
			// 
			// addLabel
			// 
			addLabel.AutoSize = true;
			addLabel.BackColor = Color.Transparent;
			addLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			addLabel.ForeColor = Color.White;
			addLabel.Location = new Point(71, 5);
			addLabel.Name = "addLabel";
			addLabel.Size = new Size(76, 25);
			addLabel.TabIndex = 0;
			addLabel.Text = "Ajouter";
			// 
			// topParentPanel
			// 
			topParentPanel.BackColor = Color.FromArgb(244, 246, 249);
			topParentPanel.Controls.Add(addPanel);
			topParentPanel.Controls.Add(searchPanel);
			topParentPanel.Controls.Add(searchTextBox);
			topParentPanel.Dock = DockStyle.Top;
			topParentPanel.Location = new Point(0, 0);
			topParentPanel.Name = "topParentPanel";
			topParentPanel.Size = new Size(949, 60);
			topParentPanel.TabIndex = 6;
			// 
			// horSeparatorPanel
			// 
			horSeparatorPanel.BackColor = Color.FromArgb(100, 108, 119);
			horSeparatorPanel.Dock = DockStyle.Top;
			horSeparatorPanel.Location = new Point(0, 60);
			horSeparatorPanel.Name = "horSeparatorPanel";
			horSeparatorPanel.Size = new Size(949, 2);
			horSeparatorPanel.TabIndex = 7;
			// 
			// manageInternsFrm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(949, 598);
			Controls.Add(horSeparatorPanel);
			Controls.Add(topParentPanel);
			Controls.Add(parentPanel);
			Name = "manageInternsFrm";
			Text = "manageInternsFrm";
			Shown += manageInternsFrm_Shown;
			loadingPanel.ResumeLayout(false);
			loadingPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)loadingPictureBox).EndInit();
			emptyListPanel.ResumeLayout(false);
			emptyListPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)emptyListLogo).EndInit();
			parentPanel.ResumeLayout(false);
			searchPanel.ResumeLayout(false);
			searchPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)searchPictureBox).EndInit();
			addPanel.ResumeLayout(false);
			addPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)addPictureBox).EndInit();
			topParentPanel.ResumeLayout(false);
			topParentPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel loadingPanel;
		private Label loadingLabel;
		private PictureBox loadingPictureBox;
		private Panel emptyListPanel;
		private Label emptyListLabel;
		private PictureBox emptyListLogo;
		private TextBox searchTextBox;
		private Panel parentPanel;
		private Panel addPanel;
		private Panel searchPanel;
		private Label seachButtonLabel;
		private Label addLabel;
		private PictureBox addPictureBox;
		private Panel topParentPanel;
		private Panel horSeparatorPanel;
		private PictureBox searchPictureBox;
		private TableLayoutPanel internsTable;
	}
}