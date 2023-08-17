using InternManagerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternManagerUI.Partials
{
	public partial class signupRequestsFrm : Form
	{
		private layoutFrm _owner;
		public signupRequestsFrm(layoutFrm owner)
		{
			InitializeComponent();
			_owner = owner;

			Helpers.BubbleClick(searchPanel, searchPanel_Click);
			Helpers.BubbleHover(searchPanel, searchPanel_MouseEnter, searchPanel_MouseLeave);
			RefreshTable(null);
		}

		private void RefreshTable(string? searchQuery)
		{
			emptyListPanel.Hide();
			parentPanel.Controls.Remove(requestsTable);
			if (requestsTable != null)
			{
				requestsTable.Dispose();
				requestsTable = null;
			}

			requestsTable = new TableLayoutPanel();

			#region Setting up requestsTable properties
			// 
			// requestsTable
			// 
			requestsTable.Visible = false;
			requestsTable.AutoSize = true;
			requestsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			requestsTable.ColumnCount = 4;
			requestsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			requestsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			requestsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			requestsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			requestsTable.Location = new Point(20, 13);
			requestsTable.Margin = new Padding(3, 3, 3, 10);
			requestsTable.Name = "requestsTable";
			requestsTable.Padding = new Padding(0, 0, 0, 20);
			requestsTable.RowCount = 1;
			requestsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			requestsTable.Size = new Size(909, 44);
			requestsTable.TabIndex = 0;
			parentPanel.Controls.Add(requestsTable);
			#endregion

			List<AdminModel> signupRequests = new List<AdminModel>();

			try
			{
				if (searchQuery != null)
				{
					signupRequests = GlobalConfig.Connection.GetSignupRequests(searchQuery);
				}
				else
				{
					signupRequests = GlobalConfig.Connection.GetSignupRequests();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erreur fatale: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(0);
			}

			if (!signupRequests.Any())
			{
				emptyListPanel.Show();
				return;
			}

			string[] columns = { "Nom et Prénom", "E-mail", "Approuver", "Supprimer" };
			int requestsCount = signupRequests.Count;

			//Set proper heights
			requestsTable.RowStyles[0].SizeType = SizeType.Absolute;
			requestsTable.RowStyles[0].Height = 45;
			for (int i = 0; i < requestsCount; ++i)
			{
				++requestsTable.RowCount;
				requestsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
			}

			//Fill headers
			for (int c = 0; c < columns.Length; ++c)
			{
				var hdrLabel = new System.Windows.Forms.Label();
				hdrLabel.Text = columns[c];
				hdrLabel.Dock = DockStyle.Fill;
				hdrLabel.TextAlign = ContentAlignment.MiddleCenter;
				hdrLabel.Font = new Font(Label.DefaultFont.FontFamily, 15, FontStyle.Bold);
				requestsTable.Controls.Add(hdrLabel, c, 0);
			}

			for (int i = 0; i < requestsCount; ++i)
			{

				string[] content = {
					signupRequests[i].FullName,
					signupRequests[i].Email
				};

				for (int c = 0; c < content.Length; ++c)
				{
					var lbl = new System.Windows.Forms.Label();
					lbl.Text = content[c];
					lbl.Dock = DockStyle.Fill;
					lbl.TextAlign = ContentAlignment.MiddleLeft;
					lbl.Font = new Font(Label.DefaultFont.FontFamily, 12, FontStyle.Regular);
					requestsTable.Controls.Add(lbl, c, i + 1);
				}

				int localIndex = i;

				//Approve button
				var approveLinkLabel = new System.Windows.Forms.LinkLabel();
				approveLinkLabel.Text = "Approuver";
				approveLinkLabel.Dock = DockStyle.Fill;
				approveLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
				approveLinkLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
				approveLinkLabel.LinkColor = System.Drawing.ColorTranslator.FromHtml("#4b89da");
				approveLinkLabel.VisitedLinkColor = System.Drawing.ColorTranslator.FromHtml("#4b89da");
				approveLinkLabel.LinkClicked += delegate
				{
					DialogResult res = MessageBox.Show("Êtes-vous sûr de vouloir approuver la demande de " + signupRequests[localIndex].FullName + "?",
						"Confirmation",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Exclamation);

					if (res == DialogResult.Yes)
					{
						try
						{
							GlobalConfig.Connection.ApproveSignupRequest(signupRequests[localIndex]);
						}
						catch (Exception ex)
						{
							MessageBox.Show("Erreur fatale: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
							Environment.Exit(0);
						}

						RefreshSelf();
					}
				};


				//Delete button
				var deleteLinkLabel = new System.Windows.Forms.LinkLabel();
				deleteLinkLabel.Text = "Supprimer";
				deleteLinkLabel.Dock = DockStyle.Fill;
				deleteLinkLabel.TextAlign = ContentAlignment.MiddleCenter;
				deleteLinkLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
				deleteLinkLabel.LinkColor = System.Drawing.ColorTranslator.FromHtml("#e8563f");
				deleteLinkLabel.VisitedLinkColor = System.Drawing.ColorTranslator.FromHtml("#e8563f");
				deleteLinkLabel.LinkClicked += delegate
				{
					DialogResult res = MessageBox.Show("Êtes-vous sûr de vouloir supprimer la demande de " + signupRequests[localIndex].FullName + "?",
						"Confirmation",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Exclamation);

					if (res == DialogResult.Yes)
					{
						try
						{
							GlobalConfig.Connection.DeleteSignupRequest(signupRequests[localIndex]);
						}
						catch (Exception ex)
						{
							MessageBox.Show("Erreur fatale: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
							Environment.Exit(0);
						}
						RefreshSelf();
					}
				};

				requestsTable.Controls.Add(approveLinkLabel, content.Length, i + 1);
				requestsTable.Controls.Add(deleteLinkLabel, content.Length + 1, i + 1);
			}
			requestsTable.Show();
		}

		private void RefreshSelf()
		{
			_owner.RefreshSignUpRequests();
		}

		private void searchPanel_Click(object? sender, EventArgs e)
		{
			if (searchTextBox.Text == "Rechercher..." || string.IsNullOrEmpty(searchTextBox.Text))
			{
				RefreshTable(null);
			}
			else
			{
				RefreshTable(searchTextBox.Text.Trim());
			}
		}

		private void searchPanel_MouseEnter(object? sender, EventArgs e)
		{
			searchPanel.BackColor = Helpers.DarkenRebrighten(searchPanel.BackColor, -0.25f);
		}

		private void searchPanel_MouseLeave(object? sender, EventArgs e)
		{
			searchPanel.BackColor = Helpers.DarkenRebrighten(searchPanel.BackColor, 0.25f);
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

		private void signupRequestsFrm_Shown(object sender, EventArgs e)
		{
			searchPanel.Focus();
		}

		private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				searchPanel_Click(this, new EventArgs());
			}
		}
	}
}
