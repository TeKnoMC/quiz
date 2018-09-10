using System;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Quiz.Classes;

namespace Quiz
{
    public partial class RegisterNewAccountForm : Form
    {
        public RegisterNewAccountForm()
        {
            InitializeComponent();
        }

        int CalculateYearGroup(int age, DateTime dob)
        {
            int yearGroup = age - 5;
            DateTime birthday = dob.AddYears(age);

            if (DateTime.Now.Month > 8)
            {
                birthday = birthday.AddYears(1);
            }

            if (birthday > DateTime.Now)
            {
                yearGroup += 1;
            }

            return yearGroup;
        }

        void WarnUser(string message)
        {
            MessageBox.Show(message, "Failed to create account", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        bool ValidateAccount()
        {
            if (!Regex.IsMatch(fullName.Text, @"^[a-zA-Z ]+$") || fullName.Text.Length < 3) {
                WarnUser("Your name must not contain non-alphabetic characters, or be under 3 characters in length");
                return false;
            }
            else if (!Regex.IsMatch(password.Text, @"^[a-zA-Z0-9_]+$") || password.Text.Length < 8)
            {
                WarnUser("Password may only contain alpha-numeric characters or an underscore, and must be longer than 7 characters");
                return false;
            }
            else if (password.Text != passwordConfirm.Text)
            {
                WarnUser("Password and confirmation did not match");
                return false;
            }
            return true;
        }

        void BtnRegister_Click(object sender, EventArgs e)
        {
            // Ensure password and confirmation match
            if (ValidateAccount())
            {
                // Calculate age from DateTime:
                DateTime today = DateTime.Today;
                int age = today.Year - dateOfBirth.Value.Year;                  // Get difference in years
                if (dateOfBirth.Value.Date > today.AddYears(-age)) age--;       // Decrement age incase no birthday this year

                // Create username (first three letters of name, plus age, e.g. Aid15)
                string username = fullName.Text.ToLower().Substring(0, 3) + age.ToString();

                DBconnection database = new DBconnection(ConfigurationManager.AppSettings["connectionString"]);

                string query = @"INSERT INTO Users
                                        (fullName, username, DOB, yearGroup, password, teacher) 
                                VALUES(@StudentName, @Username, @DOB, @YearGroup, @Password, 0)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@StudentName", fullName.Text },
                    { "@Username", username },
                    { "@DOB", dateOfBirth.Value.Date },
                    { "@YearGroup", CalculateYearGroup(age, dateOfBirth.Value.Date) },
                    { "@Password", password.Text }
                };

                int success = database.QueryDatabase_Insert(query, parameters);

                if (success == -1)
                {
                    MessageBox.Show("Database connection error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Your username is " + username + ", use this to login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
        }
    }
}
