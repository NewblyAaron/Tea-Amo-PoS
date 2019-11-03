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
    public partial class CategoryForm : Form
    {

        // SQL CONNECTION //
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\QUIN\source\repos\TeaAmo\TeaAmo\teamodata.mdf;Integrated Security=True");

        public CategoryForm()
        {
            InitializeComponent();
        }

        // DISABLE THE X BUTTON ON WINOWS FORM \\
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        }

        // ITEM DATABASE \\
        private void categoryListData()
        {
            // DATA TABLE \\
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from categories";
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            categoryList.Items.Clear();

            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetInt32(0).ToString());
                lv.SubItems.Add(reader.GetString(1).ToString());

                categoryList.Items.Add(lv);
            }
            reader.Close();
            cmd.Dispose();

        }

        // FORM LOAD \\
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            categoryListData();
        }

        // BACK BUTTON \\
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form = new MainForm();
            form.Show();
        }

        // ADD NEW BUTTON \\
        private void addButton_Click(object sender, EventArgs e)
        {

            if (nameBox.Text == "")
            {
                MessageBox.Show("Some field are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into categories values('"+ nameBox.Text +"')";
            command.ExecuteNonQuery();
            categoryListData();
            nameBox.Text = null;

        }

        // REMOVE AN CATEGORY \\
        private void removeButton_Click(object sender, EventArgs e)
        {

            if (categoryList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select an item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nameBox.Text == "")
            {
                MessageBox.Show("Some field are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(categoryList.SelectedItems[0].Text.ToString());
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from categories where id='" + id + "'";
            command.ExecuteNonQuery();
            categoryListData();
            nameBox.Text = null;

        }

        // LISTVIEW MOUSE CLICK FUNCTION \\
        private void categoryList_MouseClick(object sender, MouseEventArgs e)
        {
            String name = categoryList.SelectedItems[0].SubItems[1].Text;

            nameBox.Text = name;
        }

        // UPDATE CATEGORY \\
        private void updateButton_Click(object sender, EventArgs e)
        {

            if (categoryList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select an item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nameBox.Text == "")
            {
                MessageBox.Show("Some field are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(categoryList.SelectedItems[0].Text.ToString());
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update categories set name='" + nameBox.Text + "' where id="+ id +"";
            command.ExecuteNonQuery();
            categoryListData();
            nameBox.Text = null;

        }
    }
}
