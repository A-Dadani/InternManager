using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternManagerLibrary
{
	public interface IDataConnection
	{
		AdminModel Authenticate(string  email, string password);
		int GetAdminCount();
		int GetPFACount();
		int GetPFECount();
		int GetObservationCount();
		List<InternModel> GetInterns();
		void DeleteIntern(int id);
		void DeleteIntern(InternModel intern);
	}
}
