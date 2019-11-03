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
    public partial class ItemForm : Form
    {

        // SQL CONNECTION //
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\QUIN\source\repos\TeaAmo\TeaAmo\teamodata.mdf;Integrated Security=True");

        public ItemForm()
        {
            InitializeComponent();
            idBox.MaxLength = 10;
        }

        // DISABLE THE X CONTROL BUTTON ON WINDOWS FORM \\
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
        private void itemData()
        {
            // DATA TABLE \\
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from items";
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            itemList.Items.Clear();

            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetInt32(0).ToString());
                lv.SubItems.Add(reader.GetString(1).ToString());
                lv.SubItems.Add(reader.GetString(2).ToString());
                lv.SubItems.Add(reader.GetString(3).ToString());
                lv.SubItems.Add(reader.GetString(4).ToString());

                itemList.Items.Add(lv);
            }
            reader.Close();
            cmd.Dispose();
        }

        // CATEGORY DATABASE TO CATEGORY COMBO BOX ITEMS \\
        private void categoryBoxData()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from categories";
            cmd.ExecuteNonQuery();
            SqlDataReader rd;
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string name = rd.GetString(1);

                categoryBox.Items.Add(name);
            }
            rd.Close();
            cmd.Dispose();

        }
        
        // BACK BUTTON \\
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm main = new MainForm();
            main.Show();
        }

        // Form Load \\
        private void ItemForm_Load(object sender, EventArgs e)
        {

            // CONNECTION STATE //
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            itemData();
            categoryBoxData();
            systemDateLabel.Text = DateTime.Now.ToLongDateString();

        }

        // ADD NEW ITEM \\
        private void addButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "" | nameBox.Text == "" | priceBox.Text == "" | stockBox.Text == "" | categoryBox.Text == "")
            {
                MessageBox.Show("Some field are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from items where id='"+ idBox.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into items values('" + idBox.Text + "','" + nameBox.Text + "','" + priceBox.Text + "','" + stockBox.Text + "','" + categoryBox.Text + "')";
                command.ExecuteNonQuery();
                itemData();

                SqlCommand historyCommand = con.CreateCommand();
                historyCommand.CommandType = CommandType.Text;
                historyCommand.CommandText = "insert into history values('"+ idBox.Text +"','"+ nameBox.Text +"','"+ categoryBox.Text +"','"+ systemDateLabel.Text +"')";
                historyCommand.ExecuteNonQuery();

                idBox.Text = null;
                nameBox.Text = null;
                priceBox.Text = null;
                stockBox.Text = null;
            }
            else
            {
                MessageBox.Show("ID cannot be duplicated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        // REMOVE AN ITEM \\
        private void removeButton_Click(object sender, EventArgs e)
        {

            if (itemList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select an item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (idBox.Text == "" | nameBox.Text == "" | priceBox.Text == "" | stockBox.Text == "" | categoryBox.Text == "")
            {
                MessageBox.Show("Some field are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(itemList.SelectedItems[0].Text.ToString());
            SqlCommand command = con.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from items where id='"+ id +"'";
            command.ExecuteNonQuery();
            itemData();

            idBox.Text = null;
            nameBox.Text = null;
            priceBox.Text = null;
            stockBox.Text = null;
        }

        // ITEMLIST MOUSE CLICK \\
        private void itemList_MouseClick(object sender, MouseEventArgs e)
        {
            String id = itemList.SelectedItems[0].SubItems[0].Text;
            String name = itemList.SelectedItems[0].SubItems[1].Text;
            String stock = itemList.SelectedItems[0].SubItems[2].Text;
            String price = itemList.SelectedItems[0].SubItems[3].Text;
            String category = itemList.SelectedItems[0].SubItems[4].Text;

            idBox.Text = id;
            nameBox.Text = name;
            stockBox.Text = stock;
            priceBox.Text = price;
            categoryBox.Text = category;
        }

        // UPDATE BUTTON \\
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (itemList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select an item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (idBox.Text == "" | nameBox.Text == "" | priceBox.Text == "" | stockBox.Text == "" | categoryBox.Text == "")
            {
                MessageBox.Show("One or more fields are empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from items where id='" + idBox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            try
            {
                int id = Convert.ToInt32(itemList.SelectedItems[0].Text.ToString());
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "update items set id='" + idBox.Text + "',name='" + nameBox.Text + "',price='" + priceBox.Text + "',stock='" + stockBox.Text + "',category='" + categoryBox.Text + "' where id=" + id + "";
                command.ExecuteNonQuery();
                itemData();

                idBox.Text = null;
                nameBox.Text = null;
                priceBox.Text = null;
                stockBox.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show("ID Cannot be duplicated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        // MAX ID CAN BE USED for ID TEXTBOX \\
        private void idBox_TextChanged(object sender, EventArgs e)
        {
            
            //idBox.Text = idBox.Text.Remove(idBox.Text.Length - 1);
        }

        // ACCEPTS ONLY NUMBERS FOR ID TEXTBOX \\
        private void idBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        // BUTTON FOR CLEARING TEXTS ON TEXTBOXES \\
        private void clearButton_Click(object sender, EventArgs e)
        {
            idBox.Text = null;
            nameBox.Text = null;
            priceBox.Text = null;
            stockBox.Text = null;
        }

        // SEARCH THE ITEM ID \\
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                foreach (ListViewItem item in itemList.Items)
                {
                    if (item.Text.ToLower().Contains(searchBox.Text.ToLower()))
                    {

                        item.BackColor = Color.Yellow;
                    }
                    else
                    {
                        itemList.Items.Remove(item);
                    }
                }
            }
            else
            {
                itemData();
            }
        }

        // SEARCH BOX ACCEPTS ONLY NUMBERS \\
        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchBox.Text = null;
        }
    }
}
