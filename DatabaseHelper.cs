using MySql.Data.MySqlClient;
using System;

namespace Student_CRUD_System
{
    public static class DatabaseHelper
    {
        private const string ConnectionString =
            "Server=localhost;Database=studentcrudb;Uid=root;Pwd=root;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public static string GenerateStudentID()
        {
            int year = DateTime.Now.Year;
            int nextNumber = 1;

            using (var conn = GetConnection())
            {
                conn.Open();

                string checkSql = "SELECT LastNumber FROM StudentIDCounter WHERE Year = @year";
                using (var cmd = new MySqlCommand(checkSql, conn))
                {
                    cmd.Parameters.AddWithValue("@year", year);
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        nextNumber = Convert.ToInt32(result) + 1;
                        string updateSql = "UPDATE StudentIDCounter SET LastNumber = @num WHERE Year = @year";
                        using (var update = new MySqlCommand(updateSql, conn))
                        {
                            update.Parameters.AddWithValue("@num", nextNumber);
                            update.Parameters.AddWithValue("@year", year);
                            update.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insertSql = "INSERT INTO StudentIDCounter (Year, LastNumber) VALUES (@year, 1)";
                        using (var insert = new MySqlCommand(insertSql, conn))
                        {
                            insert.Parameters.AddWithValue("@year", year);
                            insert.ExecuteNonQuery();
                        }
                    }
                }
            }

            return $"{year}-{nextNumber:D4}";
        }
    }
}