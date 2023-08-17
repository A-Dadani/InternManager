using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Configuration;

namespace InternManagerLibrary
{
	internal class SqlConnector : IDataConnection
	{
		// TODO: Find a way to store DB creds in env file
		// TODO: upgrade to stored procedures for better safety
		private string _connectionString = @"datasource=localhost;port=3306;database=intern_manager;username=dev;password=devpass;";

		private string HashPasswordSHA256(string password)
		{
			using (var sha256 = SHA256.Create())
			{
				// Convert the password string to bytes
				byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

				// Compute the hash of the password
				byte[] hashBytes = sha256.ComputeHash(passwordBytes);

				// Convert the hashed bytes to a string representation
				StringBuilder sb = new StringBuilder();
				foreach (byte b in hashBytes)
				{
					sb.Append(b.ToString("x2")); // Convert each byte to a 2-digit hexadecimal representation
				}

				return sb.ToString();
			}
		}

		private bool ValidatePasswordSHA256(string password, string hashedPassword)
		{
			// Hash the entered password using SHA256
			string hashedInputPassword = HashPasswordSHA256(password);

			// Compare the hashed input password with the stored hashed password
			return string.Equals(hashedInputPassword, hashedPassword, StringComparison.OrdinalIgnoreCase);
		}

		public AdminModel Authenticate(string email, string password)
		{
			MySqlConnection connection = new MySqlConnection(_connectionString);

			string authInfoSelectionQuery = @"SELECT `password`, `is_confirmed` FROM admins WHERE email=""" + email + @""";";
			MySqlCommand authInfoSelectionCommand = new MySqlCommand(authInfoSelectionQuery, connection);
			connection.Open();
			MySqlDataReader authInfoReader = authInfoSelectionCommand.ExecuteReader();

			// There should only be a single hit, hence the use of if instead of while
			string passwordHash = string.Empty;
			bool isConfirmed = false;

			if (authInfoReader.Read()) 
			{
				passwordHash = authInfoReader.GetString("password");
				isConfirmed = authInfoReader.GetBoolean("is_confirmed");
			}

			if (string.IsNullOrEmpty(passwordHash))
			{
				connection.Close();
				throw new Exception("failed_auth");
			}

			if (!ValidatePasswordSHA256(password, passwordHash))
			{
				connection.Close();
				throw new Exception("failed_auth");
			}

			if (!isConfirmed)
			{
				connection.Close();
				throw new Exception("not_confirmed");
			}

			authInfoReader.Close();

			string userSelectionQuery = @"SELECT `id`, `full_name` FROM admins WHERE email=""" + email + @""";";
			MySqlCommand userSelectionCommand = new MySqlCommand(userSelectionQuery, connection);
			MySqlDataReader userReader = userSelectionCommand.ExecuteReader();

			int Id;
			string fullName = string.Empty;
			
			if (userReader.Read()) 
			{
				Id = userReader.GetInt32("id");
				fullName = userReader.GetString("full_name");
			}
			else
			{
				//this should never happen
				throw new Exception("unknown_error");
			}
			userReader.Close();
			connection.Close();

			AdminModel connectedUser = new AdminModel(Id, fullName, email, isConfirmed);
			GlobalConfig.connectedUser = connectedUser;

			return connectedUser;
		}

		public int GetAdminCount()
		{
			if (!GlobalConfig.IsUserAuthenticated())
			{
				throw new Exception("not_authenticated");
			}

			MySqlConnection connection = new MySqlConnection(_connectionString);

			string countSelectionQuery = @"SELECT COUNT(*) AS count FROM `admins`";
			MySqlCommand countSelectionCommand = new MySqlCommand(countSelectionQuery, connection);
			connection.Open();
			MySqlDataReader countreader = countSelectionCommand.ExecuteReader();
			if (countreader.Read()) 
			{
				int count = countreader.GetInt32("count");
				connection.Close();
				return count;
			}
            else
            {
				connection.Close();
                 throw new Exception("unknown_error");
            }
		}

		public int GetPFACount()
		{
			if (!GlobalConfig.IsUserAuthenticated())
			{
				throw new Exception("not_authenticated");
			}

			MySqlConnection connection = new MySqlConnection(_connectionString);

			string countSelectionQuery = @"SELECT COUNT(*) AS count FROM `interns` WHERE `internship_type` = 'PFA'";
			MySqlCommand countSelectionCommand = new MySqlCommand(countSelectionQuery, connection);
			connection.Open();
			MySqlDataReader countreader = countSelectionCommand.ExecuteReader();
			if (countreader.Read())
			{
				int count = countreader.GetInt32("count");
				connection.Close();
				return count;
			}
			else
			{
				connection.Close();
				throw new Exception("unknown_error");
			}
		}

		public int GetPFECount()
		{
			if (!GlobalConfig.IsUserAuthenticated())
			{
				throw new Exception("not_authenticated");
			}

			MySqlConnection connection = new MySqlConnection(_connectionString);

			string countSelectionQuery = @"SELECT COUNT(*) AS count FROM `interns` WHERE `internship_type` = 'PFE'";
			MySqlCommand countSelectionCommand = new MySqlCommand(countSelectionQuery, connection);
			connection.Open();
			MySqlDataReader countreader = countSelectionCommand.ExecuteReader();
			if (countreader.Read())
			{
				int count = countreader.GetInt32("count");
				connection.Close();
				return count;
			}
			else
			{
				connection.Close();
				throw new Exception("unknown_error");
			}
		}

		public int GetObservationCount()
		{
			if (!GlobalConfig.IsUserAuthenticated())
			{
				throw new Exception("not_authenticated");
			}

			MySqlConnection connection = new MySqlConnection(_connectionString);

			string countSelectionQuery = @"SELECT COUNT(*) AS count FROM `interns` WHERE `internship_type` = 'Observation'";
			MySqlCommand countSelectionCommand = new MySqlCommand(countSelectionQuery, connection);
			connection.Open();
			MySqlDataReader countreader = countSelectionCommand.ExecuteReader();
			if (countreader.Read())
			{
				int count = countreader.GetInt32("count");
				connection.Close();
				return count;
			}
			else
			{
				connection.Close();
				throw new Exception("unknown_error");
			}
		}

		public List<InternModel> GetInterns(string searchQuery = null)
		{
			if (!GlobalConfig.IsUserAuthenticated())
			{
				throw new Exception("not_authenticated");
			}

			List<InternModel> interns = new List<InternModel>();

			MySqlConnection connection = new MySqlConnection(_connectionString);
			string internsSelectionQuery = @"SELECT * FROM `interns`";
			MySqlCommand internsSelectionCommand = new MySqlCommand(internsSelectionQuery, connection);
			connection.Open();
			MySqlDataReader internsReader = internsSelectionCommand.ExecuteReader();

			string[] searchKeywords = Array.Empty<string>();

			if (searchQuery != null)
			{
				searchKeywords = searchQuery.Split(' ');
			}

			while (internsReader.Read())
			{
				InternModel currIntern = new InternModel(
						internsReader.GetInt32("Id"),
						internsReader.GetString("first_name"),
						internsReader.GetString("last_name"),
						DateOnly.FromDateTime(internsReader.GetDateTime("start_date")),
						DateOnly.FromDateTime(internsReader.GetDateTime("end_date")),
						internsReader.GetString("internship_type"),
						internsReader.GetString("civilite"),
						internsReader.GetString("school"),
						internsReader.GetString("CNI"),
						internsReader.GetInt32("study_year"),
						internsReader.GetString("study_branch"),
						internsReader.GetString("direction_accueil"),
						internsReader.GetString("entite_accueil"),
						internsReader.GetString("parrain")
					);

				string comparableString = currIntern.firstName + " "
					+ currIntern.lastName + " "
					+ currIntern.schoolName + " ";

				switch (currIntern.internshipType)
				{
					case InternModel.InternshipType.PFA:
						comparableString += "PFA"; break;
					case InternModel.InternshipType.PFE:
						comparableString += "PFE"; break;
					case InternModel.InternshipType.Obs:
						comparableString += "observation"; break;
				}

				bool toBeAdded = true;
				if (searchQuery != null)
				{
					foreach (string keyword in searchKeywords)
					{
						if (!comparableString.Contains(keyword, StringComparison.OrdinalIgnoreCase))
						{
							toBeAdded = false;
							break;
						}
					}
				}

				if (!toBeAdded) continue;

				interns.Add(currIntern);
			}

			connection.Close();

			return interns;
		}

		public void InsertIntern(InternModel intern)
		{
			if (!GlobalConfig.IsUserAuthenticated())
			{
				throw new Exception("not_authenticated");
			}

			MySqlConnection connection = new MySqlConnection(_connectionString);

			string internshipTypeStr = string.Empty;
			string civiliteStr = string.Empty;

			switch (intern.internshipType)
			{
				case InternModel.InternshipType.PFE:
					internshipTypeStr = "PFE"; break;
				case InternModel.InternshipType.PFA:
					internshipTypeStr = "PFA"; break;
				case InternModel.InternshipType.Obs:
					internshipTypeStr = "Observation"; break;
				case InternModel.InternshipType.Other:
					internshipTypeStr = "Other"; break;
			}

			switch (intern.civilite)
			{
				case InternModel.Civilite.monsieur:
					civiliteStr = "monsieur"; break;
				case InternModel.Civilite.madame:
					civiliteStr = "madame"; break;
			}

			string insertQuery = @"INSERT INTO `interns` (`first_name`, `last_name`, `start_date`, `end_date`, `internship_type`, `school`, `CNI`, `study_year`, `study_branch`, `direction_accueil`, `entite_accueil`, `parrain`, `civilite`) VALUES ('" 
				+ intern.firstName.Replace("'", "''")  + "', '" 
				+ intern.lastName.Replace("'", "''") + "', '" 
				+ intern.startDate.ToString("yyyy-MM-dd") + "', '" 
				+ intern.endDate.ToString("yyyy-MM-dd") + "', '" 
				+ internshipTypeStr + "', '" 
				+ intern.schoolName.Replace("'", "''") + "', '" 
				+ intern.CNI.ToUpper() + "', '" 
				+ intern.studyYear + "', '" 
				+ intern.studyBranch.Replace("'", "''") + "', '" 
				+ intern.directionAccueil.Replace("'", "''") + "', '" 
				+ intern.entiteAccueil.Replace("'", "''") + "', '" 
				+ intern.parrain.Replace("'", "''") + "', '" 
				+ civiliteStr + "')";

			MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
			connection.Open();
			insertCommand.ExecuteNonQuery();
			connection.Close();
		}

		public void DeleteIntern(int id)
		{
			if (!GlobalConfig.IsUserAuthenticated())
			{
				throw new Exception("not_authenticated");
			}

			MySqlConnection connection = new MySqlConnection(_connectionString);

			string deleteQuery = @"DELETE FROM `interns` WHERE `Id` = " + id.ToString();
			MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
			connection.Open();
			int nDeletedRows = deleteCommand.ExecuteNonQuery();
			if (nDeletedRows == 0)
			{
				connection.Close();
				throw new Exception("unknown_error");
			}
			connection.Close();
		}

		public void DeleteIntern(InternModel intern)
		{
			DeleteIntern(intern.Id);
		}

		public void CreateSignupRequest(AdminModel adminModel, string password)
		{
			MySqlConnection connection = new MySqlConnection(_connectionString);
			string insertQuery = @"INSERT INTO `admins` (`full_name`, `email`, `password`, `is_confirmed`) VALUES ('" 
				+ adminModel.FullName.Replace("'", "''") + "', '" 
				+ adminModel.Email + "', '" 
				+ HashPasswordSHA256(password) + "', '0');";
			MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
			connection.Open();
			insertCommand.ExecuteNonQuery();
			connection.Close();
		}

		public List<AdminModel> GetSignupRequests(string searchQuery = null)
		{
			if (!GlobalConfig.IsUserAuthenticated())
			{
				throw new Exception("not_authenticated");
			}

			List<AdminModel> signupRequests = new List<AdminModel>();

			MySqlConnection connection = new MySqlConnection(_connectionString);
			string requestsSelectionQuery = @"SELECT * FROM `admins` WHERE is_confirmed=false";
			MySqlCommand requestsSelectionCommand = new MySqlCommand(requestsSelectionQuery, connection);
			connection.Open();
			MySqlDataReader requestsReader = requestsSelectionCommand.ExecuteReader();

			string[] searchKeywords = Array.Empty<string>();

			if (searchQuery != null)
			{
				searchKeywords = searchQuery.Split(' ');
			}

			while (requestsReader.Read())
			{
				AdminModel currAdmin = new AdminModel(
						requestsReader.GetString("full_name"),
						requestsReader.GetString("email"),
						requestsReader.GetBoolean("is_confirmed")
					);

				string comparableString = currAdmin.FullName + " " + currAdmin.Email;

				bool toBeAdded = true;
				if (searchQuery != null)
				{
					foreach (string keyword in searchKeywords)
					{
						if (!comparableString.Contains(keyword, StringComparison.OrdinalIgnoreCase))
						{
							toBeAdded = false;
							break;
						}
					}
				}

				if (!toBeAdded) continue;

				signupRequests.Add(currAdmin);
			}

			connection.Close();

			return signupRequests;
		}

		public void DeleteSignupRequest(int id)
		{
			throw new NotImplementedException();
		}

		public void DeleteSignupRequest(AdminModel admin)
		{
			DeleteSignupRequest(admin.Id);
		}

		public void ApproveSignupRequest(int id)
		{
			throw new NotImplementedException();
		}

		public void ApproveSignupRequest(AdminModel admin)
		{
			ApproveSignupRequest(admin.Id);
		}
	}
}