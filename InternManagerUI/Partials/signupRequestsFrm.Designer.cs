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
			label1 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(182, 261);
			label1.Name = "label1";
			label1.Size = new Size(599, 50);
			label1.TabIndex = 0;
			label1.Text = "SIGNUP REQUESTS PLACEHOLDER";
			// 
			// signupRequestsFrm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkRed;
			ClientSize = new Size(949, 598);
			Controls.Add(label1);
			Name = "signupRequestsFrm";
			Text = "signupRequestsFrm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
	}
}