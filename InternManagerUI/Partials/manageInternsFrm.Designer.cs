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
			dataTableLayoutPanel = new TableLayoutPanel();
			SuspendLayout();
			// 
			// dataTableLayoutPanel
			// 
			dataTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			dataTableLayoutPanel.ColumnCount = 8;
			dataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
			dataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
			dataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
			dataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
			dataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
			dataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
			dataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
			dataTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
			dataTableLayoutPanel.Location = new Point(12, 12);
			dataTableLayoutPanel.Name = "dataTableLayoutPanel";
			dataTableLayoutPanel.RowCount = 2;
			dataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			dataTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			dataTableLayoutPanel.Size = new Size(925, 100);
			dataTableLayoutPanel.TabIndex = 0;
			// 
			// manageInternsFrm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(949, 598);
			Controls.Add(dataTableLayoutPanel);
			Name = "manageInternsFrm";
			Text = "manageInternsFrm";
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel dataTableLayoutPanel;
	}
}