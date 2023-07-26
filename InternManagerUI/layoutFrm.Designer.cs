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
			PLACEHOLDER = new Label();
			SuspendLayout();
			// 
			// PLACEHOLDER
			// 
			PLACEHOLDER.AutoSize = true;
			PLACEHOLDER.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
			PLACEHOLDER.Location = new Point(193, 289);
			PLACEHOLDER.Name = "PLACEHOLDER";
			PLACEHOLDER.Size = new Size(852, 86);
			PLACEHOLDER.TabIndex = 0;
			PLACEHOLDER.Text = "PLACEHOLDER AFTER LOGIN";
			// 
			// layoutFrm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(244, 246, 249);
			ClientSize = new Size(1264, 681);
			Controls.Add(PLACEHOLDER);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "layoutFrm";
			Text = "layoutFrm";
			Load += layoutFrm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label PLACEHOLDER;
	}
}