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
using InternManagerUI.Partials;

namespace InternManagerUI
{
	public partial class layoutFrm : Form
	{
		private bool isLoggedOut = true;
		public layoutFrm()
		{
			InitializeComponent();

			//Check if user is authentificated
			if (!GlobalConfig.IsUserAuthenticated())
			{
				MessageBox.Show("Vous n'êtes pas connectés", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				// Kill process if not signed in
				Environment.Exit(0);
			}

			//Bubble the click and hover events to parent panels to simulate buttons
			Helpers.BubbleClick(logoutPanel, logoutPanel_Click);
			Helpers.BubbleHover(logoutPanel, logoutPanel_MouseEnter, logoutPanel_MouseLeave);
			Helpers.BubbleClick(dashboardPanel, dashboardPanel_Click);
			Helpers.BubbleHover(dashboardPanel, dashboardPanel_MouseEnter, dashboardPanel_MouseLeave);
			Helpers.BubbleClick(manageInternsPanel, manageInternsPanel_Click);
			Helpers.BubbleHover(manageInternsPanel, manageInternsPanel_MouseEnter, manageInternsPanel_MouseLeave);
			Helpers.BubbleClick(signupRequestsPanel, signupRequestsPanel_Click);
			Helpers.BubbleHover(signupRequestsPanel, signupRequestsPanel_MouseEnter, signupRequestsPanel_MouseLeave);

			//Set the navigation selector to the correct position
			navigationSelectorPanel.Height = dashboardPanel.Height;
			navigationSelectorPanel.Top = dashboardPanel.Top;
			navigationSelectorPanel.Left = dashboardPanel.Left;
			navigationSelectorPanel.BringToFront();

			//Set titles
			titleLabel.Text = dashboardLabel.Text;
			this.Text = dashboardLabel.Text + " • OCP";

			//Load the content (partial)
			Cursor = Cursors.WaitCursor;
			contentPlaceholderPanel.Controls.Clear();
			dashboardFrm dashboardFrmInst = new dashboardFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			dashboardFrmInst.FormBorderStyle = FormBorderStyle.None;
			contentPlaceholderPanel.Controls.Add(dashboardFrmInst);
			dashboardFrmInst.Show();
			Cursor = Cursors.Default;

			//Set members
			isLoggedOut = false;
		}

		private void layoutFrm_Load(object sender, EventArgs e)
		{

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

		// Logout Panel
		private void logoutPanel_MouseEnter(object? sender, EventArgs e)
		{
			logoutPanel.BackColor = Helpers.DarkenRebrighten(logoutPanel.BackColor, -0.25f);
		}

		private void logoutPanel_MouseLeave(object? sender, EventArgs e)
		{
			logoutPanel.BackColor = Helpers.DarkenRebrighten(logoutPanel.BackColor, 0.25f);
		}

		private void logoutPanel_Click(object? sender, EventArgs e)
		{
			isLoggedOut = true;
			Close();
		}

		//Dashboard Panel
		private void dashboardPanel_MouseEnter(object? sender, EventArgs e)
		{
			dashboardPanel.BackColor = Helpers.BrightenRedarken(dashboardPanel.BackColor, 3.0f);
		}

		private void dashboardPanel_MouseLeave(object? sender, EventArgs e)
		{
			dashboardPanel.BackColor = Helpers.BrightenRedarken(dashboardPanel.BackColor, -3.0f);
		}

		private void dashboardPanel_Click(object? sender, EventArgs? e)
		{
			//Set the navigation selector to the correct position
			navigationSelectorPanel.Height = dashboardPanel.Height;
			navigationSelectorPanel.Top = dashboardPanel.Top;
			navigationSelectorPanel.Left = dashboardPanel.Left;
			navigationSelectorPanel.BringToFront();

			//Set titles
			titleLabel.Text = dashboardLabel.Text;
			this.Text = dashboardLabel.Text + " • OCP";

			//Load the content (partial)
			Cursor = Cursors.WaitCursor;
			contentPlaceholderPanel.Controls.Clear();
			dashboardFrm dashboardFrmInst = new dashboardFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			dashboardFrmInst.FormBorderStyle = FormBorderStyle.None;
			contentPlaceholderPanel.Controls.Add(dashboardFrmInst);
			dashboardFrmInst.Show();
			Cursor = Cursors.Default;
		}

		//Manage Interns Panel
		private void manageInternsPanel_MouseEnter(object? sender, EventArgs e)
		{
			manageInternsPanel.BackColor = Helpers.BrightenRedarken(manageInternsPanel.BackColor, 3.0f);
		}

		private void manageInternsPanel_MouseLeave(object? sender, EventArgs e)
		{
			manageInternsPanel.BackColor = Helpers.BrightenRedarken(manageInternsPanel.BackColor, -3.0f);
		}
		private void manageInternsPanel_Click(object? sender, EventArgs e)
		{
			//Set the navigation selector to the correct position
			navigationSelectorPanel.Height = manageInternsPanel.Height;
			navigationSelectorPanel.Top = manageInternsPanel.Top;
			navigationSelectorPanel.Left = manageInternsPanel.Left;
			navigationSelectorPanel.BringToFront();

			//Set titles
			titleLabel.Text = manageInternsLabel.Text;
			this.Text = manageInternsLabel.Text + " • OCP";

			//Load the content (partial)
			Cursor = Cursors.WaitCursor;
			contentPlaceholderPanel.Controls.Clear();
			manageInternsFrm manageInternsFrmInst = new manageInternsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			manageInternsFrmInst.FormBorderStyle = FormBorderStyle.None;
			contentPlaceholderPanel.Controls.Add(manageInternsFrmInst);
			manageInternsFrmInst.Show();
			Cursor = Cursors.Default;
		}

		private void signupRequestsPanel_MouseEnter(object? sender, EventArgs e)
		{
			signupRequestsPanel.BackColor = Helpers.BrightenRedarken(signupRequestsPanel.BackColor, 3.0f);
		}

		private void signupRequestsPanel_MouseLeave(object? sender, EventArgs e)
		{
			signupRequestsPanel.BackColor = Helpers.BrightenRedarken(signupRequestsPanel.BackColor, -3.0f);
		}

		private void signupRequestsPanel_Click(object? sender, EventArgs e)
		{
			//Set the navigation selector to the correct position
			navigationSelectorPanel.Height = signupRequestsPanel.Height;
			navigationSelectorPanel.Top = signupRequestsPanel.Top;
			navigationSelectorPanel.Left = signupRequestsPanel.Left;
			navigationSelectorPanel.BringToFront();

			//Set titles
			titleLabel.Text = signupRequestsLabel.Text;
			this.Text = signupRequestsLabel.Text + " • OCP";

			//Load the content (partial)
			Cursor = Cursors.WaitCursor;
			contentPlaceholderPanel.Controls.Clear();
			signupRequestsFrm signupRequestsFrmInst = new signupRequestsFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			signupRequestsFrmInst.FormBorderStyle = FormBorderStyle.None;
			contentPlaceholderPanel.Controls.Add(signupRequestsFrmInst);
			signupRequestsFrmInst.Show();
			Cursor = Cursors.Default;
		}
	}
}
