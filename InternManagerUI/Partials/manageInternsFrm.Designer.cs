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
			internsTable = new TableLayoutPanel();
			loadingPanel = new Panel();
			loadingLabel = new Label();
			loadingPictureBox = new PictureBox();
			emptyListPanel = new Panel();
			emptyListLabel = new Label();
			emptyListLogo = new PictureBox();
			searchTextBox = new TextBox();
			magnifyingGlassImage = new PictureBox();
			parentPanel = new Panel();
			loadingPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)loadingPictureBox).BeginInit();
			emptyListPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)emptyListLogo).BeginInit();
			((System.ComponentModel.ISupportInitialize)magnifyingGlassImage).BeginInit();
			parentPanel.SuspendLayout();
			SuspendLayout();
			// 
			// internsTable
			// 
			internsTable.AutoSize = true;
			internsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			internsTable.ColumnCount = 5;
			internsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			internsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			internsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			internsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			internsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			internsTable.Location = new Point(20, 60);
			internsTable.Margin = new Padding(3, 3, 3, 10);
			internsTable.Name = "internsTable";
			internsTable.Padding = new Padding(0, 0, 0, 20);
			internsTable.RowCount = 1;
			internsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			internsTable.Size = new Size(909, 44);
			internsTable.TabIndex = 0;
			internsTable.Visible = false;
			// 
			// loadingPanel
			// 
			loadingPanel.Controls.Add(loadingLabel);
			loadingPanel.Controls.Add(loadingPictureBox);
			loadingPanel.Location = new Point(175, 257);
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
			emptyListPanel.Location = new Point(281, 257);
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
			searchTextBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			searchTextBox.ForeColor = Color.FromArgb(100, 108, 119);
			searchTextBox.Location = new Point(20, 13);
			searchTextBox.Name = "searchTextBox";
			searchTextBox.Size = new Size(553, 35);
			searchTextBox.TabIndex = 3;
			searchTextBox.Text = "Rechercher...";
			searchTextBox.Enter += searchTextBox_Enter;
			searchTextBox.Leave += searchTextBox_Leave;
			// 
			// magnifyingGlassImage
			// 
			magnifyingGlassImage.BackColor = Color.Transparent;
			magnifyingGlassImage.BackgroundImage = Properties.Resources.magnifying_glass_grey;
			magnifyingGlassImage.BackgroundImageLayout = ImageLayout.Stretch;
			magnifyingGlassImage.Location = new Point(543, 20);
			magnifyingGlassImage.Name = "magnifyingGlassImage";
			magnifyingGlassImage.Size = new Size(20, 20);
			magnifyingGlassImage.TabIndex = 4;
			magnifyingGlassImage.TabStop = false;
			// 
			// parentPanel
			// 
			parentPanel.AutoScroll = true;
			parentPanel.Controls.Add(magnifyingGlassImage);
			parentPanel.Controls.Add(searchTextBox);
			parentPanel.Controls.Add(emptyListPanel);
			parentPanel.Controls.Add(loadingPanel);
			parentPanel.Controls.Add(internsTable);
			parentPanel.Dock = DockStyle.Fill;
			parentPanel.Location = new Point(0, 0);
			parentPanel.Margin = new Padding(0);
			parentPanel.Name = "parentPanel";
			parentPanel.Size = new Size(949, 598);
			parentPanel.TabIndex = 5;
			// 
			// manageInternsFrm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(949, 598);
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
			((System.ComponentModel.ISupportInitialize)magnifyingGlassImage).EndInit();
			parentPanel.ResumeLayout(false);
			parentPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel internsTable;
		private Panel loadingPanel;
		private Label loadingLabel;
		private PictureBox loadingPictureBox;
		private Panel emptyListPanel;
		private Label emptyListLabel;
		private PictureBox emptyListLogo;
		private TextBox searchTextBox;
		private PictureBox magnifyingGlassImage;
		private Panel parentPanel;
	}
}