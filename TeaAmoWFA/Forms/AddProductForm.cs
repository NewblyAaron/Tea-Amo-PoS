using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaAmoWFA.Functions;
using Microsoft.VisualBasic;

namespace TeaAmoWFA
{
    public partial class AddProductForm : Form
    {
        private readonly Database Db = new Database();

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            CategoryCombo.SelectedIndex = 0;
            GetProducts();
            GetCategories();
        }

        private void GetProducts()
        {
            ProductsList.Rows.Clear();

            string sql = "SELECT * FROM `teaamoinv`.`dbo.items`";

            // If the selected category is not "All"
            if (CategoryCombo.SelectedIndex != 0)
            {
                sql = $"SELECT * FROM `teaamoinv`.`dbo.items` WHERE `category` = '{CategoryCombo.SelectedItem.ToString()}'";
            }

            // If search box is not empty
            if (!String.IsNullOrEmpty(SearchBox.Text))
            {
                // If the selected category is "All"
                if (CategoryCombo.SelectedIndex == 0)
                {
                    sql += $" WHERE `name` LIKE '{SearchBox.Text}%'";
                    // sql = "SELECT * FROM items WHERE name LIKE 'input%'
                }
                else
                {
                    sql += $" AND `name` LIKE '{SearchBox.Text}%'";
                    // sql = "SELECT * FROM items WHERE category = selectedCategory AND name LIKE 'input%'
                }
            }

            // SQL Execution
            var reader = Db.ExecuteReader(sql);

            while (reader.Read())
            {
                ProductsList.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
            }

            reader.Close();
        }

        private void GetCategories()
        {
            var reader = Db.ExecuteReader("SELECT * FROM `teaamoinv`.`dbo.categories`");

            while (reader.Read())
            {
                CategoryCombo.Items.Add(reader[1]);
            }

            reader.Close();
        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProducts();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            GetProducts();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TransactionForm PoSForm = (TransactionForm) this.Owner;

            DataGridViewRow row = ProductsList.SelectedRows[0];

            if (!PoSForm.GetSelectedProduct(row))
            {
                return;
            }

            this.Close();
        }
    }
}
