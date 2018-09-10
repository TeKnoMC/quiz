using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Quiz.Classes
{
    class DBconnection
    {
        string ConnectionString;

        public DBconnection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public DataTable QueryDatabase_Select(string query, Dictionary<string, object> parameters = null)
        {
            DataTable table = new DataTable();

            try
            {
                // Create connection to database
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Open connection to database
                    connection.Open();

                    // User param
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> kvp in parameters)
                        {
                            command.Parameters.AddWithValue(kvp.Key, kvp.Value);
                        }
                    }

                    // Execute sql query
                    using (SqlDataReader sdr = command.ExecuteReader())
                    {
                        for (int i = 0; i < sdr.FieldCount; i++)
                        {
                            table.Columns.Add(sdr.GetName(i));
                        }

                        while (sdr.Read())
                        {
                            object[] row = new object[sdr.FieldCount];
                            for (int i = 0; i < row.Length; i++)
                            {
                                row[i] = sdr[sdr.GetName(i)];
                            }
                            table.Rows.Add(row);
                        }
                    }
                }
                return table;
            }
            catch
            {
                return null;
            }
        }

        public int QueryDatabase_Insert(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                // Create new connection to database
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Open connection to database
                    connection.Open();

                    // User param
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> kvp in parameters)
                        {
                            command.Parameters.AddWithValue(kvp.Key, kvp.Value);
                        }
                    }

                    return command.ExecuteNonQuery();
                }
            }
            catch
            {
                return -1;
            }
        }
    }
}
