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
			panel1 = new Panel();
			greetingsLabel = new Label();
			logoPictureBox = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(13, 13, 13);
			panel1.Controls.Add(greetingsLabel);
			panel1.Controls.Add(logoPictureBox);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1264, 70);
			panel1.TabIndex = 0;
			// 
			// greetingsLabel
			// 
			greetingsLabel.AutoSize = true;
			greetingsLabel.BackColor = Color.Transparent;
			greetingsLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
			greetingsLabel.ForeColor = Color.White;
			greetingsLabel.Location = new Point(259, 15);
			greetingsLabel.Name = "greetingsLabel";
			greetingsLabel.Size = new Size(117, 40);
			greetingsLabel.TabIndex = 1;
			greetingsLabel.Text = "Bonjour";
			// 
			// logoPictureBox
			// 
			logoPictureBox.BackgroundImage = Properties.Resources.logo_white;
			logoPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
			logoPictureBox.Location = new Point(8, 7);
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
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "layoutFrm";
			Text = "Tableau de bord • OCP";
			Load += layoutFrm_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private PictureBox logoPictureBox;
		private Label greetingsLabel;
	}
}