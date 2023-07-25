using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternManagerLibrary
{
	public class AdminModel
	{
        public AdminModel(int Id, string FullName, string Email)
        {
			this.Id = Id;
			this.FullName = FullName;
			this.Email = Email;
        }

		public AdminModel(string FullName, string Email)
		{
			this.FullName = FullName;
			this.Email = Email;
		}
        public int Id { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
	}
}
