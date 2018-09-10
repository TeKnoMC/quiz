using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;

namespace Quiz.Classes
{
    public class User
    {
        private DBconnection database;

        public int StudentID { get; private set; }
        public string FullName { get; private set; }
        public string Username { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public int YearGroup { get; private set; }
        public bool IsTeacher { get; private set; }

        public bool LoggedIn { get; private set; }

        public User(string username, string password)
        {
            database = new DBconnection(ConfigurationManager.AppSettings["connectionString"]);

            Username = username;
            LoggedIn = false;
            int success = ValidatePassword(password);
            if (success == 1) 
            {
                LoggedIn = true;

                success = GetUserDetailsFromDatabase();

                if (success == -1)
                {
                    throw new Exception("Database connection error");
                }
            } 
            else if (success == -1)
            {
                throw new Exception("Database connection error");
            }
        }

        int GetUserDetailsFromDatabase()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Username", Username }
            };

            DataTable dt = database.QueryDatabase_Select("SELECT s.stdID, s.fullName, s.DOB, s.yearGroup, s.teacher FROM Users s WHERE username = @Username", parameters);

            if (dt == null)
            {
                return -1;
            }

            StudentID = Convert.ToInt32(dt.Rows[0]["stdID"]);
            FullName = $"{dt.Rows[0]["fullName"]}".Trim();
            DateOfBirth = Convert.ToDateTime(dt.Rows[0]["DOB"]);
            if (!(dt.Rows[0]["yearGroup"] is DBNull)) YearGroup = Convert.ToInt32(dt.Rows[0]["yearGroup"]);
            IsTeacher = Convert.ToBoolean(dt.Rows[0]["teacher"]);

            return 0;

        }

        int ValidatePassword(string password)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Username", Username }
            };

            DataTable dt = database.QueryDatabase_Select("SELECT s.password FROM Users s WHERE username = @Username", parameters);

            if (dt == null)
            {
                return -1;
            }

            if (password == $"{dt.Rows[0]["password"]}".Trim())
            {
                return 1;
            }

            return 0;
        }

        public int StoreResultsInDatabase(string topic, int score, string difficulty)
        {
            DBconnection database = new DBconnection(ConfigurationManager.AppSettings["connectionString"]);

            string query = @"INSERT INTO Results
                                        (stdID, topic, score, difficulty) 
                                VALUES(@StudentID, @Topic, @Score, @Difficulty)";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@StudentID", StudentID },
                { "@Topic", topic },
                { "@Score", score },
                { "@Difficulty", difficulty }
            };

            return database.QueryDatabase_Insert(query, parameters);
        }

    }
}
