namespace InternManagerUI.Partials
{
	partial class signupRequestsFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signupRequestsFrm));
			topParentPanel = new Panel();
			searchPanel = new Panel();
			searchPictureBox = new PictureBox();
			seachButtonLabel = new Label();
			searchTextBox = new TextBox();
			horSeparatorPanel = new Panel();
			parentPanel = new Panel();
			emptyListPanel = new Panel();
			emptyListLabel = new Label();
			emptyListLogo = new PictureBox();
			topParentPanel.SuspendLayout();
			searchPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)searchPictureBox).BeginInit();
			parentPanel.SuspendLayout();
			emptyListPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)emptyListLogo).BeginInit();
			SuspendLayout();
			// 
			// topParentPanel
			// 
			topParentPanel.BackColor = Color.FromArgb(244, 246, 249);
			topParentPanel.Controls.Add(searchPanel);
			topParentPanel.Controls.Add(searchTextBox);
			topParentPanel.Dock = DockStyle.Top;
			topParentPanel.Location = new Point(0, 0);
			topParentPanel.Name = "topParentPanel";
			topParentPanel.Size = new Size(949, 60);
			topParentPanel.TabIndex = 7;
			// 
			// searchPanel
			// 
			searchPanel.BackColor = Color.FromArgb(138, 192, 84);
			searchPanel.Controls.Add(searchPictureBox);
			searchPanel.Controls.Add(seachButtonLabel);
			searchPanel.Location = new Point(747, 13);
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
			// searchTextBox
			// 
			searchTextBox.BackColor = Color.FromArgb(244, 246, 249);
			searchTextBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			searchTextBox.ForeColor = Color.FromArgb(100, 108, 119);
			searchTextBox.Location = new Point(20, 13);
			searchTextBox.Name = "searchTextBox";
			searchTextBox.Size = new Size(721, 35);
			searchTextBox.TabIndex = 3;
			searchTextBox.Text = "Rechercher...";
			searchTextBox.Enter += searchTextBox_Enter;
			searchTextBox.KeyDown += searchTextBox_KeyDown;
			searchTextBox.Leave += searchTextBox_Leave;
			// 
			// horSeparatorPanel
			// 
			horSeparatorPanel.BackColor = Color.FromArgb(100, 108, 119);
			horSeparatorPanel.Dock = DockStyle.Top;
			horSeparatorPanel.Location = new Point(0, 60);
			horSeparatorPanel.Name = "horSeparatorPanel";
			horSeparatorPanel.Size = new Size(949, 2);
			horSeparatorPanel.TabIndex = 8;
			// 
			// parentPanel
			// 
			parentPanel.Controls.Add(emptyListPanel);
			parentPanel.Dock = DockStyle.Fill;
			parentPanel.Location = new Point(0, 62);
			parentPanel.Name = "parentPanel";
			parentPanel.Size = new Size(949, 536);
			parentPanel.TabIndex = 9;
			// 
			// emptyListPanel
			// 
			emptyListPanel.Controls.Add(emptyListLabel);
			emptyListPanel.Controls.Add(emptyListLogo);
			emptyListPanel.Location = new Point(326, 226);
			emptyListPanel.Name = "emptyListPanel";
			emptyListPanel.Size = new Size(296, 84);
			emptyListPanel.TabIndex = 3;
			emptyListPanel.Visible = false;
			// 
			// emptyListLabel
			// 
			emptyListLabel.AutoSize = true;
			emptyListLabel.Font = new Font("Segoe UI Semibold", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
			emptyListLabel.Location = new Point(80, 27);
			emptyListLabel.Name = "emptyListLabel";
			emptyListLabel.Size = new Size(177, 31);
			emptyListLabel.TabIndex = 1;
			emptyListLabel.Text = "La liste est vide.";
			// 
			// emptyListLogo
			// 
			emptyListLogo.BackgroundImage = Properties.Resources.info;
			emptyListLogo.BackgroundImageLayout = ImageLayout.Stretch;
			emptyListLogo.Location = new Point(47, 27);
			emptyListLogo.Name = "emptyListLogo";
			emptyListLogo.Size = new Size(30, 30);
			emptyListLogo.TabIndex = 0;
			emptyListLogo.TabStop = false;
			// 
			// signupRequestsFrm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(949, 598);
			Controls.Add(parentPanel);
			Controls.Add(horSeparatorPanel);
			Controls.Add(topParentPanel);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "signupRequestsFrm";
			Text = "signupRequestsFrm";
			Shown += signupRequestsFrm_Shown;
			topParentPanel.ResumeLayout(false);
			topParentPanel.PerformLayout();
			searchPanel.ResumeLayout(false);
			searchPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)searchPictureBox).EndInit();
			parentPanel.ResumeLayout(false);
			emptyListPanel.ResumeLayout(false);
			emptyListPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)emptyListLogo).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel topParentPanel;
		private Panel searchPanel;
		private PictureBox searchPictureBox;
		private Label seachButtonLabel;
		private TextBox searchTextBox;
		private Panel horSeparatorPanel;
		private Panel parentPanel;
		private Panel emptyListPanel;
		private Label emptyListLabel;
		private PictureBox emptyListLogo;
		private TableLayoutPanel requestsTable;
	}
}