﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternManagerLibrary
{
	public interface IDataConnection
	{
		AdminModel Authenticate(string  email, string password);
	}
}