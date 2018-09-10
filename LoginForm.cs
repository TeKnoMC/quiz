using System;
using System.Windows.Forms;
using Quiz.Classes;

namespace Quiz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        void BtnSignIn_Click(object sender, EventArgs e)
        {
            User user = new User(username.Text, password.Text);

            if (user.LoggedIn)
            {
                username.Text = "";
                password.Text = "";

                MainQuizForm mainQuiz = new MainQuizForm(user, this);
                mainQuiz.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Log in was unsuccessful", "Failed to login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void RegisterNew_Click(object sender, EventArgs e)
        {
            RegisterNewAccountForm registerNewAccount = new RegisterNewAccountForm();
            registerNewAccount.ShowDialog();
        }
    }
}
