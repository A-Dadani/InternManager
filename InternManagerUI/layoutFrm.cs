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
			BubbleHover(logoutPanel, logoutPanel_MouseEnter, logoutPanel_MouseLeave);
			isLoggedOut = false;
		}

		/// <summary>
		/// Bubble the click event to the parent (works on only 1 generation)
		/// </summary>
		/// <param name="parent">The parent panel</param>
		/// <param name="clickBehavior">Function that dictates the behavior - often the Click beavior of the parent</param>
		private void BubbleClick(Panel parent, EventHandler clickBehavior)
		{
			foreach (Control child in parent.Controls)
			{
				child.MouseClick += new MouseEventHandler(clickBehavior);
			}
		}

		/// <summary>
		/// Bubble the Hover event to the parent (works on only 1 generation)
		/// </summary>
		/// <param name="parent">The parent panel</param>
		/// <param name="mouseEnterBehavior">Function that dictates the behavior - often the MouseEnter behavior of the parent</param>
		/// <param name="mouseLeaveBehavior">Function that dictates the behavior - often the MouseLeave behavior of the parent</param>
		private void BubbleHover(Panel parent, EventHandler mouseEnterBehavior, EventHandler mouseLeaveBehavior) 
		{
			foreach (Control child in parent.Controls)
			{
				child.MouseEnter += new EventHandler(mouseEnterBehavior);
				child.MouseLeave += new EventHandler(mouseLeaveBehavior);
			}
		}

		/// <summary>
		/// Darkens and rebrightens color
		/// </summary>
		/// <param name="color">Color to correct.</param>
		/// <param name="correctionFactor">The brightness correction factor. Must be between -1 and 1. 
		/// Negative values produce darker colors.</param>
		/// <returns>
		/// Corrected <see cref="Color"/> structure.
		/// </returns>
		public static Color DarkenRebrighten(Color color, float correctionFactor)
		{
			float red = (float)color.R;
			float green = (float)color.G;
			float blue = (float)color.B;

			if (correctionFactor < 0)
			{
				correctionFactor = 1 + correctionFactor;
				red *= correctionFactor;
				green *= correctionFactor;
				blue *= correctionFactor;
			}
			else
			{
				red /= (1 - correctionFactor);
				green /= (1 - correctionFactor);
				blue /= (1 - correctionFactor);
			}

			return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
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

		private void logoutPanel_MouseEnter(object? sender, EventArgs e)
		{
			logoutPanel.BackColor = DarkenRebrighten(logoutPanel.BackColor, -0.25f);
		}

		private void logoutPanel_MouseLeave(object? sender, EventArgs e)
		{
			logoutPanel.BackColor = DarkenRebrighten(logoutPanel.BackColor, 0.25f);
		}
	}
}
