using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternManagerLibrary
{
	public class InternModel
	{
		public enum InternshipType
		{
			PFE,
			PFA,
			Obs,
			Other
		}

        public InternModel(
			int Id, 
			string firstName, 
			string lastName,
			DateOnly startDate, 
			DateOnly endDate, 
			string internshipType,
			string schoolName, 
			string CNI, 
			int studyYear, 
			string studyBranch, 
			string directionAccueil,
			string entiteAccueil, 
			string parrain)
        {
            this.Id = Id;
			this.firstName = firstName;
			this.lastName = lastName;
			this.startDate = startDate;
			this.endDate = endDate;
			this.schoolName = schoolName;
			this.CNI = CNI;
			this.studyYear = studyYear;
			this.studyBranch = studyBranch;
			this.directionAccueil = directionAccueil;
			this.entiteAccueil = entiteAccueil;
			this.parrain = parrain;

			switch (internshipType)
			{
				case "PFE":
					this.internshipType = InternshipType.PFE; break;
				case "PFA":
					this.internshipType = InternshipType.PFA; break;
				case "Observation":
					this.internshipType = InternshipType.Obs; break;
				default:
					this.internshipType = InternshipType.Other; break;
			}
        }

        public int Id { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set;}
		public DateOnly startDate { get; set; }
		public DateOnly endDate { get; set; }
		public InternshipType internshipType { get; set; }
		public string schoolName { get; set; }
		public string CNI { get; set; }
		public int studyYear { get; set; }
		public string studyBranch { get; set; }
		public string directionAccueil { get; set; }
		public string entiteAccueil { get; set; }
		public string parrain { get; set; }
	}
}
