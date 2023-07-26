﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

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
	}
}