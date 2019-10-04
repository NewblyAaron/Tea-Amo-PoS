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
    public partial class Products : UserControl
    {
        private readonly Database Db = new Database();

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            GetProducts();
        }

        private void Products_EnabledChanged(object sender, EventArgs e)
        {
            GetProducts();
        }

        private void GetProducts()
        {
            ProductsTable.Rows.Clear();

            var reader = Db.ExecuteReader("SELECT * FROM `teaamoinv`.`dbo.items`");

            while (reader.Read())
            {
                ProductsTable.Rows.Add(reader[0], reader[4], reader[1], reader[2], reader[3]);
            }

            reader.Close();
        }
    }
}
