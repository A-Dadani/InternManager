using System.Text.RegularExpressions;
using InternManagerLibrary;

namespace InternManagerUI
{
	public partial class login : Form
	{
		// Add the logos and reveal password button

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
				passwordMaskedTextBox.PasswordChar = '�';
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
			emailWarnLabel.Hide();
			credentialsWarnLabel.Hide();

			Cursor = System.Windows.Forms.Cursors.WaitCursor;
			string emailRegex = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";

			if (!Regex.IsMatch(emailMaskedTextBox.Text.Trim(), emailRegex))
			{
				emailWarnLabel.Show();
				Cursor = System.Windows.Forms.Cursors.Default;
				return;
			}

			try
			{
				GlobalConfig.Connection.Authenticate(emailMaskedTextBox.Text.Trim(), passwordMaskedTextBox.Text);
			}
			catch (Exception ex) 
			{
				if (ex.Message == "failed_auth")
				{
					credentialsWarnLabel.Text = "Email ou mot de passe �rron�";
				}
				else
				{
					credentialsWarnLabel.Text = $"Erreur inconnue: {ex.Message}";
				}
				credentialsWarnLabel.Show();
				Cursor = System.Windows.Forms.Cursors.Default;
			}

			var layoutForm = new layoutFrm();
			layoutForm.Location = Location;
			layoutForm.StartPosition = FormStartPosition.Manual;
			layoutForm.FormClosing += delegate { Close(); };
			layoutForm.Show();
			Hide();
		}
	}
}