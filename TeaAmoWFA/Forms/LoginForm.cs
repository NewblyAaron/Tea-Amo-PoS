using System;
using System.Windows.Forms;
using TeaAmoWFA.Functions;

namespace TeaAmoWFA
{
    public partial class LoginForm : Form
    {
        private readonly Database Db = new Database();

        int attempt = 0;

        public LoginForm()
        {
            InitializeComponent();

            this.AcceptButton = LoginButton;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            int userExist = Convert.ToInt32(Db.ExecuteScalar($"SELECT COUNT(*) FROM `teaamoinv`.`dbo.users` WHERE Username='{usernameBox.Text}' AND Password='{passwordBox.Text}'"));

            if (userExist > 0)
            {
                new Msg().Info($"Welcome, {usernameBox.Text}!");
                this.DialogResult = DialogResult.OK; // Login OK!
            }
            else
            {
                new Msg().Error("Username or password incorrect.");

                if (++attempt >= 3)
                {
                    new Msg().Warning("Intruder alert! This application will now exit.");
                    Application.Exit();
                }
            }
        }
    }
}