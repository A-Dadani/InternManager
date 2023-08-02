using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternManagerLibrary
{
	internal class InternModel
	{
		public enum InternshipType
		{
			PFE,
			PFA,
			Obs,
			Other
		}
		public int Id { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set;}
		public DateOnly startDate { get; set; }
		public DateOnly endDate { get; set; }
		public InternshipType internshipType { get; set; }
		public string schoolName { get; set; }
		public string CNI { get; set; }
		public int study_year { get; set; }
		public string study_branch { get; set; }
		public string directionAccueil { get; set; }
		public string entiteAccueil { get; set; }
		public string parrain { get; set; }
	}
}
