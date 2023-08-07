using InternManagerLibrary;
using System.Globalization;
using InternManagerUI.Partials;
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
	public partial class detailedInternViewFrm : Form
	{
		public detailedInternViewFrm(InternModel intern)
		{
			InitializeComponent();
			Text = intern.lastName.ToUpper() + " "
					+ CultureInfo.CurrentCulture.TextInfo.ToTitleCase(intern.firstName.ToLower())
					+ " détails • OCP";

		}
	}
}
