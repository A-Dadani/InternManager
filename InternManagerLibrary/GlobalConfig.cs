using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternManagerLibrary
{
	public static class GlobalConfig
	{
		public static IDataConnection Connection { get; set; } = null;

		public static void InitializeConnection()
		{
			Connection = new SqlConnector();
		}

		private static AdminModel _connectedUser = null;

		public static AdminModel connectedUser { 
			get
			{
				if (_connectedUser == null)
				{
					throw new Exception("not_authenticated");
				}
				return _connectedUser;
			}
			set
			{
				_connectedUser = value;
			}
		}

		public static void logoutUser()
		{
			if (_connectedUser == null) 
			{
				throw new Exception("not_authenticated");
			}
			_connectedUser = null;
		}

		public static bool IsUserAuthenticated() 
		{
			return _connectedUser != null;
		}
	}
}
