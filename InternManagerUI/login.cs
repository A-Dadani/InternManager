using System.Text.RegularExpressions;

namespace InternManagerUI
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}

		private void emailMaskedTextBox_Enter(object sender, EventArgs e)
		{
			if (emailMaskedTextBox.Text == "Adresse E-mail")
			{
				emailMaskedTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
				emailMaskedTextBox.Text = "";
			}
		}

		private void emailMaskedTextBox_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(emailMaskedTextBox.Text))
			{
				emailMaskedTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#646c77");
				emailMaskedTextBox.Text = "Adresse E-mail";
			}
		}

		private void passwordMaskedTextBox_Enter(object sender, EventArgs e)
		{
			if (passwordMaskedTextBox.Text == "Mot de passe")
			{
				passwordMaskedTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
				passwordMaskedTextBox.PasswordChar = '•';
				passwordMaskedTextBox.Text = "";
			}
		}

		private void passwordMaskedTextBox_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordMaskedTextBox.Text))
			{
				passwordMaskedTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#646c77");
				passwordMaskedTextBox.PasswordChar = '\0';
				passwordMaskedTextBox.Text = "Mot de passe";
			}
		}

		private void login_Shown(object sender, EventArgs e)
		{
			backroundSmallPanel.Focus();
		}

		private void signInButton_Click(object sender, EventArgs e)
		{
			Cursor = System.Windows.Forms.Cursors.WaitCursor;
			string emailRegex = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";

			if (!Regex.IsMatch(emailMaskedTextBox.Text, emailRegex))
			{
				emailWarnLabel.Show();
				Cursor = System.Windows.Forms.Cursors.Default;
				return;
			}
		}
	}
}