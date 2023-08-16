using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternManagerUI
{
	public partial class signUpFrm : Form
	{
		public signUpFrm()
		{
			InitializeComponent();
		}

		private void firstNameTextBox_Enter(object sender, EventArgs e)
		{
			if (firstNameTextBox.Text == "Prénom")
			{
				firstNameTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
				firstNameTextBox.Text = "";
			}
		}

		private void firstNameTextBox_Leave(object sender, EventArgs e)
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

		private void lastNameTextBox_Leave(object sender, EventArgs e)
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

		private void emailTextBox_Leave(object sender, EventArgs e)
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

		private void passwordTextBox_Leave(object sender, EventArgs e)
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

		private void passwordConfirmTextBox_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordConfirmTextBox.Text))
			{
				passwordConfirmTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#646c77");
				passwordConfirmTextBox.PasswordChar = '\0';
				passwordConfirmTextBox.Text = "Confirmer le mot de passe";
			}
		}
	}
}
