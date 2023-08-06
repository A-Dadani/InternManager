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
	public partial class dashboardFrm : Form
	{
		private int PFACount = 0;
		private int PFECount = 0;
		private int obsCount = 0;
		private int adminCount = 0;
		public dashboardFrm()
		{
			InitializeComponent();
			try
			{
				PFACount = GlobalConfig.Connection.GetPFACount();
				PFECount = GlobalConfig.Connection.GetPFECount();
				obsCount = GlobalConfig.Connection.GetObservationCount();
				adminCount = GlobalConfig.Connection.GetAdminCount();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erreur fatale: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(0);
			}
			PFACountLabel.Text = PFACount.ToString();
			PFECountLabel.Text = PFECount.ToString();
			obsCountLabel.Text = obsCount.ToString();
			adminCountLabel.Text = adminCount.ToString();
		}
	}
}
