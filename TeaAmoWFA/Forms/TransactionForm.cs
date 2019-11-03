using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TeaAmoWFA.Functions;

namespace TeaAmoWFA
{
    public partial class TransactionForm : Form
    {
        private readonly Database Db = new Database();

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            GetTransactionCode();
        }

        // Controls Methods
        private void AddItem_Click(object sender, EventArgs e)
        {
            using AddProductForm Product = new AddProductForm();
            Product.ShowDialog(this);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DialogResult input = new Msg().Question("Confirm action?");

            if (input == DialogResult.Yes)
            {
                ClearButton.Text = "Clear";
                PriceLabel.Text = "Total";

                OrderList.Rows.Clear();
                UnitsBox.Clear();
                TotalPriceBox.Clear();

                PayButton.Enabled = true;
                AddItem.Enabled = true;
                QuantityButton.Enabled = true;
            }
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (OrderList.Rows.Count == 0)
            {
                new Msg().Error("You don't have any orders!");
                return;
            }

            double total = Double.Parse(Regex.Match(TotalPriceBox.Text, @"-?\d+").Value);
            bool isNumber = Double.TryParse(new Msg().Input("Enter tender"), out double tender);

            if (!isNumber)
            {
                MessageBox.Show("Invalid input.");
                return;
            }

            double change = tender - total;

            if (change < 0)
            {
                MessageBox.Show("Insufficient funds.");
                return;
            }

            DialogResult input = new Msg().Question("Confirm transaction?");

            if (input == DialogResult.Yes)
            {
                RecordTransaction(total, tender, change);

                PriceLabel.Text = "Change";
                TotalPriceBox.Text = $"PHP {change}";

                PayButton.Enabled = false;
                AddItem.Enabled = false;
                QuantityButton.Enabled = false;
                ClearButton.Text = "New Transaction";

                GetTransactionCode();
            }
        }

        private void QuantityButton_Click(object sender, EventArgs e)
        {
            if (OrderList.SelectedRows.Count == 0)
            {
                new Msg().Error("No item selected!");
                return;
            }
            
            string input = new Msg().Input($"Enter quantity of {OrderList.SelectedRows[0].Cells[1].Value.ToString()}");

            bool isNumber = Double.TryParse(input, out double qty);

            if (!isNumber)
            {
                    new Msg().Error("Invalid input.");
                    return;
            }

            if (qty <= 0)
            {
                    new Msg().Error("Please enter a positive number.");
                    return;
            }
            OrderList.SelectedRows[0].Cells[2].Value = qty.ToString();

            CalculateSubtotalPrice();
        }

        // Custom Methods
        private void CalculateTotalPrice()
        {
            double total = 0;

            foreach (DataGridViewRow row in OrderList.Rows)
            {
                total += Double.Parse(Regex.Match(row.Cells[4].Value.ToString(), @"-?\d+").Value);
            }

            TotalPriceBox.Text = $"PHP {total.ToString()}";

            CalculateUnits();
        }

        private void CalculateSubtotalPrice()
        {
            double itemPrice, subtotal;
            int qty;

            foreach (DataGridViewRow row in OrderList.Rows)
            {
                itemPrice = Convert.ToDouble(row.Cells[3].Value.ToString());
                qty = Convert.ToInt32(row.Cells[2].Value.ToString());
                subtotal = itemPrice * qty;
                row.Cells[4].Value = "PHP " + subtotal.ToString();
            }

            CalculateTotalPrice();
        }

        private void CalculateUnits()
        {
            int units = 0;

            foreach (DataGridViewRow row in OrderList.Rows)
            {
                units += Convert.ToInt32(row.Cells[2].Value.ToString());
            }

            UnitsBox.Text = units.ToString();
        }

        private void GetTransactionCode()
        {
            int code = Convert.ToInt32(Db.ExecuteScalar("SELECT COUNT(*) FROM `teaamopos`.`transaction_history`").ToString()) + 1;
            TransactionCodeBox.Text = code.ToString();
        }

        private void RecordTransaction(double total, double tender, double change)
        {
            Db.ExecuteNonQuery(
            "INSERT INTO `teaamopos`.`transaction_history`(id, date, total_price, tender, `change`) " +
            $"VALUES ({TransactionCodeBox.Text}, '{DateTime.Now.ToString("yyyy-MM-dd")}', {total}, {tender}, {change})"
            );

            // Put the ordered items in the orderlist
            foreach (DataGridViewRow row in OrderList.Rows)
            {
                Db.ExecuteNonQuery(
                    "INSERT INTO `teaamopos`.`transaction_history_items`(id, item_name, qty_bought, subtotal) " +
                    $"VALUES ({TransactionCodeBox.Text}, '{row.Cells[1].Value.ToString()}', {row.Cells[2].Value.ToString()}, {Regex.Match(row.Cells[4].Value.ToString(), @"-?\d+").Value})"
                    );

                Db.ExecuteNonQuery(
                    "UPDATE `teaamoinv`.`dbo.items` " +
                    $"SET stock = stock - {row.Cells[2].Value.ToString()} " +
                    $"WHERE name = '{row.Cells[1].Value.ToString()}'"
                    );
            }
        }
        public bool GetSelectedProduct(DataGridViewRow selectedRow)
        {
            string id = selectedRow.Cells[0].Value.ToString();
            string name = selectedRow.Cells[1].Value.ToString();
            double price = Convert.ToDouble(selectedRow.Cells[2].Value.ToString());

            foreach (DataGridViewRow row in OrderList.Rows)
            {
                if (row.Cells[0].Value.ToString() == id)
                {
                    new Msg().Error($"You already have {name}!");
                    return false;
                }
            }

            OrderList.Rows.Add(id, name, "1", price, $"PHP {price}");
            OrderList.Rows[OrderList.Rows.Count - 1].Selected = true;

            CalculateSubtotalPrice();
            return true;
        }
    }
}