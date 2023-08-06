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
using System.Drawing.Drawing2D;

namespace InternManagerUI.Partials
{
	public partial class manageInternsFrm : Form
	{
		public manageInternsFrm()
		{
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

			for (int c = 0; c < columns.Length; ++c)
			{
				for (int r = 1; r <= internCount; ++r)
				{
					var lbl = new System.Windows.Forms.Label();
					lbl.Text = (c + r).ToString();
					lbl.Dock = DockStyle.Fill;
					internsTable.Controls.Add(lbl, c, r);
				}
			}
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
