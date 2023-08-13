using InternManagerLibrary;
using System.Globalization;
using InternManagerUI.Partials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cmp;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using SkiaSharp;
using System.IO;

namespace InternManagerUI
{
	public partial class detailedInternViewFrm : Form
	{
		private InternModel intern = default!;
		public detailedInternViewFrm(InternModel intern)
		{
			if (!GlobalConfig.IsUserAuthenticated())
			{
				MessageBox.Show("Vous n'êtes pas connectés", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				// Kill process if not signed in
				Environment.Exit(0);
			}

			InitializeComponent();

			this.intern = intern;
			Text = intern.lastName.ToUpper() + " "
					+ CultureInfo.CurrentCulture.TextInfo.ToTitleCase(intern.firstName.ToLower())
					+ " détails • OCP";
			bigNameLabel.Text = intern.lastName.ToUpper() + " "
					+ CultureInfo.CurrentCulture.TextInfo.ToTitleCase(intern.firstName.ToLower());

			//Fill the fields from the info of the intern passed as argument
			lastNameLabel.Text = intern.lastName.ToUpper();
			firstNameLabel.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(intern.firstName.ToLower());

			switch (intern.civilite)
			{
				case InternModel.Civilite.monsieur:
					civiliteLabel.Text = "Monsieur"; break;
				case InternModel.Civilite.madame:
					civiliteLabel.Text = "Madame"; break;
			}

			CNILabel.Text = intern.CNI;
			ecoleLabel.Text = intern.schoolName;

			switch (intern.studyYear)
			{
				case 1:
					studyYearLabel.Text = "1ère année"; break;
				default:
					studyYearLabel.Text = intern.studyYear.ToString() + "ème année"; break;
			}

			studyBranchLabel.Text = intern.studyBranch;

			switch (intern.internshipType)
			{
				case InternModel.InternshipType.PFA:
					internshipTypeLabel.Text = "Projet Fin d'Année (PFA)";
					break;
				case InternModel.InternshipType.PFE:
					internshipTypeLabel.Text = "Projet Fin d'Études (PFE)";
					break;
				case InternModel.InternshipType.Obs:
					internshipTypeLabel.Text = "Stage d'observation";
					break;
				case InternModel.InternshipType.Other:
					internshipTypeLabel.Text = "Autre";
					break;
			}

			entiteAccueilLabel.Text = intern.entiteAccueil;
			directionAccueilLabel.Text = intern.directionAccueil;
			startYearLabel.Text = intern.startDate.ToString("dd-MM-yyyy");
			endYearLabel.Text = intern.endDate.ToString("dd-MM-yyyy");
			parrainLabel.Text = intern.parrain;

			Helpers.BubbleHover(printPanel, printPanel_MouseEnter, printPanel_MouseLeave);
			Helpers.BubbleHover(deletePanel, deletePanel_MouseEnter, deletePanel_MouseLeave);
			Helpers.BubbleClick(printPanel, printPanel_Click);
			Helpers.BubbleClick(deletePanel, deletePanel_Click);
		}

		private void printPanel_MouseEnter(object? sender, EventArgs e)
		{
			printPanel.BackColor = Helpers.DarkenRebrighten(printPanel.BackColor, -0.25f);
		}

		private void printPanel_MouseLeave(object? sender, EventArgs e)
		{
			printPanel.BackColor = Helpers.DarkenRebrighten(printPanel.BackColor, 0.25f);
		}

		private void deletePanel_MouseEnter(object? sender, EventArgs e)
		{
			deletePanel.BackColor = Helpers.DarkenRebrighten(deletePanel.BackColor, -0.25f);
		}

		private void deletePanel_MouseLeave(object? sender, EventArgs e)
		{
			deletePanel.BackColor = Helpers.DarkenRebrighten(deletePanel.BackColor, 0.25f);
		}

		private void printPanel_Click(object? sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			try
			{
				var document = new ConvocationDocument(intern);
				document.GeneratePdfAndShow();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erreur inconnue, la génération du document n'est pas possible pour le moment. Réessayez ultérieurement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			Cursor = Cursors.Default;
		}

		private void deletePanel_Click(object? sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer l'entrée "
					+ intern.lastName.ToUpper() + " "
					+ CultureInfo.CurrentCulture.TextInfo.ToTitleCase(intern.firstName.ToLower())
					+ "?",
				"Confirmer suppression",
				MessageBoxButtons.OKCancel);

			if (dialogResult == DialogResult.OK)
			{
				GlobalConfig.Connection.DeleteIntern(intern);
				((manageInternsFrm)Owner).RefreshSelf();
				Close();
			}
			return;
		}
	}
}
