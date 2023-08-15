using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternManagerUI
{
	public partial class addInternFrm : Form
	{
		public addInternFrm()
		{
			InitializeComponent();
			Helpers.BubbleHover(submitPanel, submitPanel_MouseEnter, submitPanel_MouseLeave);
			Helpers.BubbleClick(submitPanel, submitPanel_Click);
		}

		private void submitPanel_MouseEnter(object? sender, EventArgs e)
		{
			submitPanel.BackColor = Helpers.DarkenRebrighten(submitPanel.BackColor, -0.25f);
		}

		private void submitPanel_MouseLeave(object? sender, EventArgs e)
		{
			submitPanel.BackColor = Helpers.DarkenRebrighten(submitPanel.BackColor, 0.25f);
		}

		private void submitPanel_Click(object? sender, EventArgs e)
		{
		}
	}
}
