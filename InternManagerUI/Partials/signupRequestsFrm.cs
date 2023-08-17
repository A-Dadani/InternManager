using InternManagerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
			requestsTable.ColumnCount = 5;
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

			List<AdminModel> interns = new List<AdminModel>();
		}
	}
}
