using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeaAmo
{
    public partial class Form1 : Form
    {
        // SQL CONNECTION //
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\QUIN\source\repos\TeaAmo\TeaAmo\teamodata.mdf;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // CONNECTION STATE //
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

        }

        // WHEN BUTTON IS PRESSED THE USER WILL GO TO NEXT WINDOWS FORM IF THE USERNAME AND PASSWORD ARE CORRECCT \\
        private void logButton_Click(object sender, EventArgs e)
        {

            int i = 0;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where username='"+ usernameBox.Text +"' and password='"+ passwordBox.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("Username and Password does not matched!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Hide();
                MainForm ken = new MainForm();
                ken.Show();
            }

        }
        
    }
}
