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
		List<InternModel> GetInterns(string searchQuery = null);
		void InsertIntern(InternModel intern);
		void DeleteIntern(int id);
		void DeleteIntern(InternModel intern);
		void CreateSignupRequest(AdminModel adminModel, string password);
		List<AdminModel> GetSignupRequests(string searchQuery = null);
		void DeleteSignupRequest(int id);
		void DeleteSignupRequest(AdminModel admin);
		void ApproveSignupRequest(int id);
		void ApproveSignupRequest(AdminModel admin);
	}
}
