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
    public partial class HistoryForm : Form
    {

        // SQL CONNECTION //
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\QUIN\source\repos\TeaAmo\TeaAmo\teamodata.mdf;Integrated Security=True");

        public HistoryForm()
        {
            InitializeComponent();
        }

        // DISABLE THE X BUTTON \\
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        }

        // HISTORY DATABASE \\
        private void historyData()
        {

            // DATA TABLE \\
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from history";
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            historyList.Items.Clear();

            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetString(3).ToString());
                lv.SubItems.Add(reader.GetString(1).ToString());
                lv.SubItems.Add(reader.GetString(2).ToString());
                lv.SubItems.Add(reader.GetInt32(0).ToString());

                historyList.Items.Add(lv);
            }
            reader.Close();
            cmd.Dispose();

        }

        //  FORM LOAD \\
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            // CONNECTION STATE //
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            historyData();
        }

        // BACK BUTTON \\
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm main = new MainForm();
            main.Show();
        }

        // REMOVE ALL HISTORY SAVED \\
        private void allRemoveButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from history";
            command.ExecuteNonQuery();
            historyData();
        }

        // REMOVE AN SINGLE ITEM \\
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (historyList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select an item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(historyList.SelectedItems[0].Text.ToString());
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from history where id='" + id + "'";
            command.ExecuteNonQuery();
            historyData();
        }

        // FIND THE MONTH BY TYPING LETTERS \\
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dateBox.Text != "")
            {
                foreach (ListViewItem item in historyList.Items)
                {
                    if (item.Text.ToLower().Contains(dateBox.Text.ToLower()))
                    {
                        
                        item.BackColor = Color.Yellow;
                    }
                    else
                    {
                        historyList.Items.Remove(item);
                    }
                }
            }
            else
            {
                historyData();
            }

        }

        // DISBALE THE NUMBERS ON THIS DATE BOX \\
        private void dateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
