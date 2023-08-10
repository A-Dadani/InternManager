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

			string passwordSelectionQuery = @"SELECT `password` FROM admins WHERE email=""" + email + @""";";
			MySqlCommand passwordSelectionCommand = new MySqlCommand(passwordSelectionQuery, connection);
			connection.Open();
			MySqlDataReader passwordReader = passwordSelectionCommand.ExecuteReader();

			// There should only be a single hit, hence the use of if instead of while
			string passwordHash = string.Empty;

			if (passwordReader.Read()) 
			{
				passwordHash = passwordReader.GetString("password");
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

			passwordReader.Close();

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

			GlobalConfig.connectedUser = new AdminModel(Id, fullName, email);

			return new AdminModel(Id, fullName, email);
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

		public List<InternModel> GetInterns()
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

			while (internsReader.Read())
			{
				interns.Add(
					new InternModel(
						internsReader.GetInt32("Id"), 
						internsReader.GetString("first_name"), 
						internsReader.GetString("last_name"),
						DateOnly.FromDateTime(internsReader.GetDateTime("start_date")), 
						DateOnly.FromDateTime(internsReader.GetDateTime("end_date")),
						internsReader.GetString("internship_type"), 
						internsReader.GetString("school"), 
						internsReader.GetString("CNI"),
						internsReader.GetInt32("study_year"), 
						internsReader.GetString("study_branch"), 
						internsReader.GetString("direction_accueil"),
						internsReader.GetString("entite_accueil"), 
						internsReader.GetString("parrain")
					)
				);
			}

			return interns;
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
				throw new Exception("unknown_error");
			}
		}

		public void DeleteIntern(InternModel intern)
		{
			DeleteIntern(intern.Id);
		}
	}
}