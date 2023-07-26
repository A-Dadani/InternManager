using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternManagerLibrary;

namespace InternManagerUI
{
	public partial class layoutFrm : Form
	{
		public layoutFrm()
		{
			InitializeComponent();
			try
			{
				greetingsLabel.Text = $"Bonjour {GlobalConfig.connectedUser.FullName}";
			}
			catch (Exception ex)
			{
				string msg = $"Erreur inconnue: {ex.Message}";
				if (ex.Message == "not_authenticated")
				{
					msg = "Vous n'êtes pas connectés";
				}
				MessageBox.Show(msg, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				// Kill process if not signed in
				Environment.Exit(0);
			}
		}

		private void layoutFrm_Load(object sender, EventArgs e)
		{

		}
	}
}
