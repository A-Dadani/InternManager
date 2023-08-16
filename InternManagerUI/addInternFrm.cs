using InternManagerLibrary;
using InternManagerUI.Partials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternManagerUI
{
	public partial class addInternFrm : Form
	{
		public addInternFrm()
		{
			InitializeComponent();
			Helpers.BubbleHover(submitPanel, submitPanel_MouseEnter, submitPanel_MouseLeave);
			Helpers.BubbleClick(submitPanel, submitPanel_Click);
		}

		private void submitPanel_MouseEnter(object? sender, EventArgs e)
		{
			submitPanel.BackColor = Helpers.DarkenRebrighten(submitPanel.BackColor, -0.25f);
		}

		private void submitPanel_MouseLeave(object? sender, EventArgs e)
		{
			submitPanel.BackColor = Helpers.DarkenRebrighten(submitPanel.BackColor, 0.25f);
		}

		private void submitPanel_Click(object? sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			if (!ValidateInputAndShowError())
			{
				return;
			}

			warnLabel.Text = "‎"; // Invisible char

			string civiliteStr = civiliteComboBox.SelectedItem.ToString() ?? ""; // To suppress warning

			InternModel newIntern = new InternModel(
				firstNameTextBox.Text,
				lastNameTextBox.Text,
				DateOnly.FromDateTime(startDatePicker.Value),
				DateOnly.FromDateTime(endDatePicker.Value),
				internshipTypeComboBox.SelectedItem.ToString(),
				civiliteStr.ToLower(),
				schoolTextBox.Text,
				CNITextBox.Text,
				Int32.Parse(studyYearTextBox.Text),
				studyBranchTextBox.Text,
				directionAccueilTextBox.Text,
				entiteAccueilTextBox.Text,
				parrainTextBox.Text
			);

			try
			{ 
				GlobalConfig.Connection.InsertIntern(newIntern);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erreur lors de l'ajout du stagiaire: " + ex.Message , "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Cursor = Cursors.Default;
				Close();
			}

			((manageInternsFrm)Owner).RefreshSelf();
			Cursor = Cursors.Default;
			Close();
		}

		private bool ValidateInputAndShowError()
		{
			bool verdict = false; 

			string CNIRegex = @"^[a-zA-Z0-9]+$";
			string numericRegex = @"^[0-9]+$";

			if (civiliteComboBox.SelectedItem == null)									{ warnLabel.Text = "Veuillez choisir une civilité."; }
			else if (string.IsNullOrEmpty(firstNameTextBox.Text))						{ warnLabel.Text = "Le prénom ne peut pas être vide."; }
			else if (string.IsNullOrEmpty(lastNameTextBox.Text))						{ warnLabel.Text = "Le nom ne peut pas être vide."; }
			else if (string.IsNullOrEmpty(CNITextBox.Text))								{ warnLabel.Text = "Le numéro de la CNI ne peut pas être vide."; }
			else if (!Regex.IsMatch(CNITextBox.Text, CNIRegex))							{ warnLabel.Text = "Le numéro de la CNI ne peut contenir que des caractères alphanumériques."; }
			else if (string.IsNullOrEmpty(schoolTextBox.Text))							{ warnLabel.Text = "Le nom de l'école ne peut pas être vide."; }
			else if (string.IsNullOrEmpty(studyYearTextBox.Text))						{ warnLabel.Text = "L'année d'étude ne peut pas être vide."; }
			else if (!Regex.IsMatch(studyYearTextBox.Text, numericRegex))				{ warnLabel.Text = "L'année d'étude ne peut comporter que des chiffres."; }
			else if (string.IsNullOrEmpty(studyBranchTextBox.Text))						{ warnLabel.Text = "La spécialité ne peut pas être vide."; }
			else if (internshipTypeComboBox.SelectedItem == null)						{ warnLabel.Text = "Veuillez choisir un type de stage."; }
			else if (string.IsNullOrEmpty(entiteAccueilTextBox.Text))					{ warnLabel.Text = "L'entité d'accueil ne peut pas être vide."; }
			else if (string.IsNullOrEmpty(directionAccueilTextBox.Text))				{ warnLabel.Text = "La direction d'accueil ne peut pas être vide."; }
			else if (DateTime.Compare(startDatePicker.Value, endDatePicker.Value) >= 0) { warnLabel.Text = "La date de début de stage doit être plus tôt que sa date de fin."; }
			else if (string.IsNullOrEmpty (parrainTextBox.Text))						{ warnLabel.Text = "Le nom du parrain ne peut pas être vide"; }
			else { verdict = true; }

			return verdict;
		}
	}
}
