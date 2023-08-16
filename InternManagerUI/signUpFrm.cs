using InternManagerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternManagerUI
{
	public partial class signUpFrm : Form
	{
		bool XClickedClose = true;

		public signUpFrm()
		{
			InitializeComponent();
		}

		private void signUpFrm_Shown(object sender, EventArgs e)
		{
			backroundSmallPanel.Focus();
		}

		private void firstNameTextBox_Enter(object sender, EventArgs e)
		{
			if (firstNameTextBox.Text == "Prénom")
			{
				firstNameTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
				firstNameTextBox.Text = "";
			}
		}

		private void firstNameTextBox_Leave(object? sender, EventArgs? e)
		{
			if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
			{
				firstNameTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#646c77");
				firstNameTextBox.Text = "Prénom";
			}
		}

		private void lastNameTextBox_Enter(object sender, EventArgs e)
		{
			if (lastNameTextBox.Text == "Nom")
			{
				lastNameTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
				lastNameTextBox.Text = "";
			}
		}

		private void lastNameTextBox_Leave(object? sender, EventArgs? e)
		{
			if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
			{
				lastNameTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#646c77");
				lastNameTextBox.Text = "Nom";
			}
		}

		private void emailTextBox_Enter(object sender, EventArgs e)
		{
			if (emailTextBox.Text == "Adresse E-mail")
			{
				emailTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
				emailTextBox.Text = "";
			}
		}

		private void emailTextBox_Leave(object? sender, EventArgs? e)
		{
			if (string.IsNullOrWhiteSpace(emailTextBox.Text))
			{
				emailTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#646c77");
				emailTextBox.Text = "Adresse E-mail";
			}
		}

		private void passwordTextBox_Enter(object sender, EventArgs e)
		{
			if (passwordTextBox.Text == "Mot de passe")
			{
				passwordTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
				passwordTextBox.PasswordChar = '•';
				passwordTextBox.Text = "";
			}
		}

		private void passwordTextBox_Leave(object? sender, EventArgs? e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				passwordTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#646c77");
				passwordTextBox.PasswordChar = '\0';
				passwordTextBox.Text = "Mot de passe";
			}
		}

		private void passwordConfirmTextBox_Enter(object sender, EventArgs e)
		{
			if (passwordConfirmTextBox.Text == "Confirmer le mot de passe")
			{
				passwordConfirmTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
				passwordConfirmTextBox.PasswordChar = '•';
				passwordConfirmTextBox.Text = "";
			}
		}

		private void passwordConfirmTextBox_Leave(object? sender, EventArgs? e)
		{
			if (string.IsNullOrWhiteSpace(passwordConfirmTextBox.Text))
			{
				passwordConfirmTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#646c77");
				passwordConfirmTextBox.PasswordChar = '\0';
				passwordConfirmTextBox.Text = "Confirmer le mot de passe";
			}
		}

		private void signUpButton_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			successMessageLabel.Hide();
			nameWarnLabel.Hide();
			emailWarnLabel.Hide();
			passwordWarnLabel.Hide();
			passwordConfirmationWarnLabel.Hide();

			string emailRegex = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
			bool isCheckFailed = false;

			if (string.IsNullOrEmpty(firstNameTextBox.Text) || firstNameTextBox.Text == "Prénom"
				|| string.IsNullOrEmpty(lastNameTextBox.Text) || lastNameTextBox.Text == "Nom")
			{
				isCheckFailed = true;
				nameWarnLabel.Show();
			}

			if (string.IsNullOrEmpty(emailTextBox.Text) || !Regex.IsMatch(emailTextBox.Text, emailRegex))
			{
				isCheckFailed = true;
				emailWarnLabel.Show();
			}

			if (string.IsNullOrEmpty(passwordTextBox.Text)
				|| passwordTextBox.Text == "Mot de passe"
				|| passwordTextBox.Text == "Confirmer le mot de passe"
				|| passwordTextBox.Text.Length < 8)
			{
				isCheckFailed = true;
				passwordWarnLabel.Show();
			}
			else if (passwordConfirmTextBox.Text != passwordTextBox.Text)
			{
				isCheckFailed = true;
				passwordConfirmationWarnLabel.Show();
			}

			if (isCheckFailed)
			{
				Cursor = Cursors.Default;
				return;
			}

			AdminModel admin = new AdminModel(
				lastNameTextBox.Text.ToUpper() + " "
					+ CultureInfo.CurrentCulture.TextInfo.ToTitleCase(firstNameTextBox.Text.ToLower()),
				emailTextBox.Text, false
			);

			try
			{
				GlobalConfig.Connection.CreateSignupRequest(admin, passwordTextBox.Text);
			}
			catch (Exception ex)
			{
				Cursor = Cursors.Default;
				MessageBox.Show("Erreur lors de la création du compte: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Reset();
				return;
			}

			Reset();
			successMessageLabel.Show();
			Cursor = Cursors.Default;
		}

		private void Reset()
		{
			successMessageLabel.Hide();
			nameWarnLabel.Hide();
			firstNameTextBox.Text = "";
			firstNameTextBox_Leave(null, null);
			lastNameTextBox.Text = "";
			lastNameTextBox_Leave(null, null);
			emailWarnLabel.Hide();
			emailTextBox.Text = "";
			emailTextBox_Leave(null, null);
			passwordWarnLabel.Hide();
			passwordTextBox.Text = "";
			passwordTextBox_Leave(null, null);
			passwordConfirmationWarnLabel.Hide();
			passwordConfirmTextBox.Text = "";
			passwordConfirmTextBox_Leave(null, null);
		}

		private void createRequestLinkLabel_Click(object sender, EventArgs e)
		{
			XClickedClose = false;
			Owner.Show();
			Close();
		}

		private void signUpFrm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (XClickedClose && e.CloseReason != CloseReason.FormOwnerClosing)
			{
				Owner.Close();
			}
		}
	}
}
