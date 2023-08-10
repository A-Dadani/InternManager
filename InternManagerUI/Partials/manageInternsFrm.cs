using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using InternManagerLibrary;
using System.Globalization;

namespace InternManagerUI.Partials
{
	public partial class manageInternsFrm : Form
	{
		private layoutFrm _owner;
		public manageInternsFrm(layoutFrm owner)
		{
			_owner = owner;
			InitializeComponent();
			InitializeTable();
			loadingPanel.Hide();
			internsTable.Show();
		}

		private void manageInternsFrm_Shown(object sender, EventArgs e)
		{
			magnifyingGlassImage.Focus();
		}

		private void InitializeTable()
		{
			List<InternModel> interns = new List<InternModel>();
			try
			{
				interns = GlobalConfig.Connection.GetInterns();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erreur fatale: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(0);
			}
			if (!interns.Any())
			{
				loadingPanel.Hide();
				emptyListPanel.Show();
				return;
			}

			string[] columns = { "Nom et Prénom", "Entité d'accueil", "Année d'étude", "Spécialité", "Détails" };
			int internCount = interns.Count;

			//Set proper heights
			internsTable.RowStyles[0].SizeType = SizeType.Absolute;
			internsTable.RowStyles[0].Height = 45;
			for (int i = 0; i < internCount; ++i)
			{
				++internsTable.RowCount;
				internsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
			}

			//Fill headers
			for (int c = 0; c < columns.Length; ++c)
			{
				var hdrLabel = new System.Windows.Forms.Label();
				hdrLabel.Text = columns[c];
				hdrLabel.Dock = DockStyle.Fill;
				hdrLabel.TextAlign = ContentAlignment.MiddleCenter;
				hdrLabel.Font = new Font(Label.DefaultFont.FontFamily, 15, FontStyle.Bold);
				internsTable.Controls.Add(hdrLabel, c, 0);
			}

			for (int i = 0; i < internCount; ++i)
			{
				string anneeEtudeStr;
				switch (interns[i].studyYear)
				{
					case 1:
						anneeEtudeStr = "1ère année"; break;
					case 2:
						anneeEtudeStr = "2ème année"; break;
					default:
						anneeEtudeStr = interns[i].studyYear.ToString() + "ème année"; break;
				}
				string[] content = { 
					interns[i].lastName.ToUpper() + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(interns[i].firstName.ToLower()), 
					interns[i].entiteAccueil, 
					anneeEtudeStr, 
					interns[i].studyBranch 
				};
				for (int c = 0; c < content.Length; ++c)
				{
					var lbl = new System.Windows.Forms.Label();
					lbl.Text = content[c];
					lbl.Dock = DockStyle.Fill;
					lbl.TextAlign = ContentAlignment.MiddleLeft;
					lbl.Font = new Font(Label.DefaultFont.FontFamily, 12, FontStyle.Regular);
					internsTable.Controls.Add(lbl, c, i + 1);
				}

				//Details button
				var linkLbl = new System.Windows.Forms.LinkLabel();
				linkLbl.Text = "Plus de détails";
				linkLbl.Dock = DockStyle.Fill;
				linkLbl.TextAlign = ContentAlignment.MiddleCenter;
				linkLbl.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);

				int localIndex = i;
				linkLbl.LinkClicked += delegate { 
					detailedInternViewFrm childForm = new detailedInternViewFrm(interns[localIndex]);
					AddOwnedForm(childForm);
					childForm.Show();
				};

				internsTable.Controls.Add(linkLbl, content.Length, i + 1);
			}
		}

		public void RefreshSelf()
		{
			_owner.RefreshManageInterns();
		}

		private void searchTextBox_Enter(object sender, EventArgs e)
		{
			if (searchTextBox.Text == "Rechercher...")
			{
				searchTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#000000");
				searchTextBox.Text = "";
			}
		}

		private void searchTextBox_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchTextBox.Text))
			{
				searchTextBox.ForeColor = System.Drawing.ColorTranslator.FromHtml("#646c77");
				searchTextBox.Text = "Rechercher...";
			}
		}
	}
}
