using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using Quiz.Classes;

namespace Quiz
{
    public partial class ReportForm : Form
    {
        DBconnection database;

        List<string> NameList;
        List<string> YearGroupList;
        List<string> TopicList;
        List<string> ScoreList;
        List<string> DifficultyList;

        public ReportForm()
        {
            InitializeComponent();

            database = new DBconnection(ConfigurationManager.AppSettings["connectionString"]);

            NameList = new List<string>();
            YearGroupList = new List<string>();
            TopicList = new List<string>();
            ScoreList = new List<string>();
            DifficultyList = new List<string>();
        }

        int GetStudentID()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Username", usernameField.Text }
            };

            DataTable dt = database.QueryDatabase_Select("SELECT s.stdID FROM Users s WHERE username = @Username", parameters);

            if (dt == null)
            {
                return -1;
            }

            return Convert.ToInt32(dt.Rows[0]["stdID"]);
        }

        int GetReportData(int StudentID)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@StudentID", StudentID }
            };

            string query = @"SELECT s.fullName, s.yearGroup, r.topic, r.score, r.difficulty 
                             FROM Users s 
                             INNER JOIN Results r ON s.stdID = r.stdID 
                             WHERE r.stdID = @StudentID";

            DataTable dt = database.QueryDatabase_Select(query, parameters);

            if (dt == null)
            {
                return -1;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NameList.Add($"{dt.Rows[i]["fullName"]}");
                YearGroupList.Add($"{dt.Rows[i]["yearGroup"]}");
                TopicList.Add($"{dt.Rows[i]["topic"]}");
                ScoreList.Add($"{dt.Rows[i]["score"]}");
                DifficultyList.Add($"{dt.Rows[i]["difficulty"]}");
            }
            return 0;
        }

        void GenerateReport_Click(object sender, EventArgs e)
        {
            NameList.Clear();
            YearGroupList.Clear();
            TopicList.Clear();
            ScoreList.Clear();
            DifficultyList.Clear();

            int StudentID = GetStudentID();

            if (StudentID == -1)
            {
                MessageBox.Show("User does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GetReportData(StudentID);

                ReportTable.Rows.Clear();
                for (int i = 0; i < NameList.Count; i++)
                {
                    ReportTable.Rows.Add(new string[5] { NameList[i], YearGroupList[i], TopicList[i], ScoreList[i], DifficultyList[i] });
                }
            }
        }
    }
}
