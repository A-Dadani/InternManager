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
		private bool isLoggedOut = true;
		public layoutFrm()
		{
			InitializeComponent();
			if (!GlobalConfig.IsUserAuthenticated())
			{
				MessageBox.Show("Vous n'êtes pas connectés", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				// Kill process if not signed in
				Environment.Exit(0);
			}
			BubbleClick(logoutPanel, logoutPanel_Click);
			isLoggedOut = false;
		}

		/// <summary>
		/// Bubble the click event to the parent (works on only 1 generation)
		/// </summary>
		/// <param name="parent">The parent panel</param>
		private void BubbleClick(Panel parent, EventHandler clickBehavior)
		{
			foreach (var child in parent.Controls)
			{
				switch (child)
				{
					case Label childLabel:
						childLabel.MouseClick += new MouseEventHandler(clickBehavior);
						break;
					case PictureBox childPictureBox:
						childPictureBox.MouseClick += new MouseEventHandler(clickBehavior);
						break;
					default:
						throw new ArgumentException();
				}
			}
		}

		private void layoutFrm_Load(object sender, EventArgs e)
		{

		}

		private void logoutPanel_Click(object? sender, EventArgs e)
		{
			isLoggedOut = true;
			Close();
		}

		private void layoutFrm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				if (isLoggedOut)
				{
					GlobalConfig.logoutUser();
					Owner.Show();
				}
				else
				{
					Application.Exit();
				}
			}
		}
	}
}
