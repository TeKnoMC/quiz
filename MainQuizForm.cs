using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using Quiz.Classes;
using System.Configuration;

namespace Quiz
{
    public partial class MainQuizForm : Form
    {
        LoginForm mainForm;
        User currentUser;

        List<QuestionCard> listOfQuestionCards;
        int index;
        Random rnd = new Random();
        string difficulty;
        string topic;

        public MainQuizForm(User user, LoginForm login)
        {
            InitializeComponent();

            mainForm = login;
            currentUser = user;

            currentUserLbl.Text = $"Logged in as - {currentUser.FullName} ({currentUser.Username})";

            if (user.IsTeacher)
            {
                TeacherMenu.Visible = true;
                TeacherMenu.Enabled = true;

                BtnStart.Text = "Get Averages";
            }
        }

        // "Start Quiz" button, or "Get Averages" button
        void BtnStart_Click(object sender, EventArgs e)
        {
            if (currentUser.IsTeacher)
            {
                int success = DisplayAverages();
                if (success == -1)
                {
                    MessageBox.Show("Cannot connect to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (success == -2)
                {
                    MessageBox.Show("Please select difficulty and subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                StartQuiz();
            }
        }

        int DisplayAverages()
        {
            List<int> scores = new List<int>();
            string[] output = new string[2];
            DBconnection database = new DBconnection(ConfigurationManager.AppSettings["connectionString"]);

            if (drpdwnDifficulty.Text == "" || drpdwnSubject.Text == "")
            {
                return -2;
            }
            else
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@Topic", drpdwnSubject.Text },
                    { "@Difficulty", drpdwnDifficulty.Text }
                };

                DataTable dt = database.QueryDatabase_Select("SELECT r.score FROM Results r WHERE topic = @Topic AND difficulty = @Difficulty", parameters);

                if (dt == null)
                {
                    return -1;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    scores.Add(Convert.ToInt32(dt.Rows[i]["score"]));
                }

                if (scores.Any())
                {
                    qBox.Lines = new string[2] { $"Average score = {Math.Round(scores.Average())}", $"Highest score = {scores.Max()}" };
                }
                else
                {
                    qBox.Lines = new string[1] { "No records found" };
                }
            }
            return 0;
        }

        void StartQuiz()
        {
            // Create a new list of QuestionCards
            listOfQuestionCards = new List<QuestionCard>();
            index = 0;

            // Create new XmlSerializer to deserialize the xml files for questions
            XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionCard>));

            topic = drpdwnSubject.Text;

            switch (topic)
            {
                case "Computer Science":
                    using (FileStream fs = File.OpenRead("Data/csQuestions.xml"))
                    {
                        // Deserialize xml file to get list of question cards, and order randomly, then select 5
                        listOfQuestionCards = ((List<QuestionCard>)serializer.Deserialize(fs)).OrderBy(x => rnd.Next()).Take(5).ToList();
                    }
                    break;
                case "History":
                    using (FileStream fs = File.OpenRead("Data/histQuestions.xml"))
                    {
                        // Deserialize xml file to get list of question cards, and order randomly, then select 5
                        listOfQuestionCards = ((List<QuestionCard>)serializer.Deserialize(fs)).OrderBy(x => rnd.Next()).Take(5).ToList();
                    }
                    break;
                case "Music":
                    using (FileStream fs = File.OpenRead("Data/musicQuestions.xml"))
                    {
                        // Deserialize xml file to get list of question cards, and order randomly, then select 5
                        listOfQuestionCards = ((List<QuestionCard>)serializer.Deserialize(fs)).OrderBy(x => rnd.Next()).Take(5).ToList();
                    }
                    break;
            }

            if (drpdwnDifficulty.Text != "" && drpdwnSubject.Text != "")
            {
                difficulty = drpdwnDifficulty.Text;

                BtnAnswer.Show();
                rbAnswer1.Show();
                rbAnswer2.Show();

                SetScreen(listOfQuestionCards[0]);
            }
        }

        // Selects answers to be displayed based upon difficulty level
        List<PotentialAnswer> SelectAnswers(List<PotentialAnswer> answers)
        {
            List<PotentialAnswer> finalAnswers = new List<PotentialAnswer>();
            switch (difficulty)
            {
                case "Easy":
                    // Linq statement to shuffle the final answers, and take 2 answers
                    finalAnswers = answers.OrderBy(x => rnd.Next()).Take(2).ToList();
                    // While list doesn't contain the correct answer (ensure we return a list of answers that contains the correct answer)
                    while (!finalAnswers.Any(x => x.Correct))
                    {
                        finalAnswers = answers.OrderBy(x => rnd.Next()).Take(2).ToList();
                    }
                    break;
                case "Medium":
                    // Linq statement to shuffle the final answers, and take 2 answers
                    finalAnswers = answers.OrderBy(x => rnd.Next()).Take(3).ToList();
                    // While list doesn't contain the correct answer (ensure we return a list of answers that contains the correct answer)
                    while (!finalAnswers.Any(x => x.Correct))
                    {
                        finalAnswers = answers.OrderBy(x => rnd.Next()).Take(3).ToList();
                    }
                    break;
                case "Hard":
                    finalAnswers = answers.OrderBy(x => rnd.Next()).ToList();
                    break;
            }
            return finalAnswers;

        }

        // Update screen items
        void SetScreen(QuestionCard qC)
        {
            qBox.Text = qC.Question;

            rbAnswer1.Checked = false;
            rbAnswer2.Checked = false;
            rbAnswer3.Checked = false;
            rbAnswer4.Checked = false;

            List<PotentialAnswer> finalAnswers = SelectAnswers(qC.ListOfPotentialAnswers);

            rbAnswer1.Text = finalAnswers[0].Answer;
            rbAnswer2.Text = finalAnswers[1].Answer;

            if (difficulty == "Medium" || difficulty == "Hard")
            {
                rbAnswer3.Text = finalAnswers[2].Answer;
                rbAnswer3.Show();
            }
            else
            {
                rbAnswer3.Hide();
            }
            if (difficulty == "Hard")
            {
                rbAnswer4.Text = finalAnswers[3].Answer;
                rbAnswer4.Show();
            }
            else
            {
                rbAnswer4.Hide();
            }
        }

        // "Answer question" button
        void BtnAnswer_Click(object sender, EventArgs e)
        {
            // Get the checked button from the panel
            RadioButton checkedButton = pnlRadioButtons.Controls.OfType<RadioButton>().FirstOrDefault(rB => rB.Checked);

            // Set the question cards PlayerAnswer value to the checked button, making sure it isn't null
            if (checkedButton == null)
            {
                listOfQuestionCards[index].PlayerAnswer = "N/A";
            }
            else
            {
                listOfQuestionCards[index].PlayerAnswer = checkedButton.Text;
            }
            

            index++;

            if (index > listOfQuestionCards.Count - 1)
            {
                FinaliseQuiz();
            }
            else
            {
                // Set new set of questions and answers on screen
                SetScreen(listOfQuestionCards[index]);
            }
        }

        // Display score and incorrect answers
        void FinaliseQuiz()
        {
            List<QuestionCard> incorrect = (from x in listOfQuestionCards where x.AnswerCorrect == false select x).ToList();

            // New string array to hold lines for the question box
            string[] strArr = new string[incorrect.Count + 2];

            int score = listOfQuestionCards.Count - incorrect.Count;

            strArr[0] = $"Your score = {score}/{listOfQuestionCards.Count}\n";

            if (incorrect.Count != 0)
            {
                strArr[1] = "Questions you got wrong:\n";

                // Display each incorrect answer 
                for (int i = 2; i < incorrect.Count + 2; i++)
                {
                    strArr[i] = incorrect[i - 2].Question + " -> Your answer was: " + incorrect[i - 2].PlayerAnswer + "\n";
                }
            }


            if (currentUser.StoreResultsInDatabase(topic, score, difficulty) == -1)
            {
                MessageBox.Show("Database connection error, could not store results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            qBox.Lines = strArr;
            BtnAnswer.Hide();
            rbAnswer1.Hide();
            rbAnswer2.Hide();
            rbAnswer3.Hide();
            rbAnswer4.Hide();
        }

        void SwitchUser_Click(object sender, EventArgs e)
        {
            Close();
            mainForm.Show();
        }

        private void GenerateUserReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }
    }
}
