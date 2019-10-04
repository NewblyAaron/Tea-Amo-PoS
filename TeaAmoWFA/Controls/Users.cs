using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaAmoWFA.Functions;

namespace TeaAmoWFA
{
    public partial class Users : UserControl
    {
        private readonly Database Db = new Database();

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void Users_EnabledChanged(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void GetUsers()
        {
            UsersTable.Rows.Clear();

            var reader = Db.ExecuteReader("SELECT * FROM `teaamoinv`.`dbo.users`");

            while (reader.Read())
            {
                UsersTable.Rows.Add(reader[0], reader[1]);
            }

            reader.Close();
        }
    }
}
