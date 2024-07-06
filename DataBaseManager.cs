using System.Data;
using System.Data.SqlClient;

namespace cross
{
	public static class DatabaseManager
	{
		private const string connectionString = "Server=KHALID\\SQLEXPRESS;Database=ITI;Integrated Security=True;";

		public static SqlConnection GetConnection()
		{
			return new SqlConnection(connectionString);
		}

		public static List<string> GetDepartmentNames()
		{
			List<string> departmentNames = new List<string>();
			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				SqlCommand command = new SqlCommand("SELECT [Dept_Desc] FROM [dbo].[Department]", connection);
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						departmentNames.Add(reader["Dept_Desc"].ToString());
					}
				}
			}
			return departmentNames;
		}

		public static DataTable GetStudentsByDepartment(string departmentName)
		{
			DataTable studentsTable = new DataTable();
			using (SqlConnection connection = GetConnection())
			{
				connection.Open();
				// Adjusted command text to call a Table-Valued Function
				string commandText = "SELECT * FROM GetStudentsByDepartment(@DeptName)";
				SqlCommand command = new SqlCommand(commandText, connection);
				command.Parameters.AddWithValue("@DeptName", departmentName);
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				adapter.Fill(studentsTable);
			}
			return studentsTable;
		}
	}
}