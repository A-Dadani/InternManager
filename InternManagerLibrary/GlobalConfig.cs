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
		public static AdminModel connectedUser { get; set; } = null;
	}
}
