using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternManagerLibrary
{
	public class AdminModel
	{
        public AdminModel(int Id, string FullName, string Email, bool isConfirmed)
        {
			this.Id = Id;
			this.FullName = FullName;
			this.Email = Email;
			this.isConfirmed = isConfirmed;
        }

		public AdminModel(string FullName, string Email, bool isConfirmed)
		{
			this.FullName = FullName;
			this.Email = Email;
			this.isConfirmed = isConfirmed;
		}
        public int Id { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public bool isConfirmed { get; set; }
	}
}
