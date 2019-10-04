using System;
using System.Windows.Forms;
using TeaAmoWFA.Forms;

namespace TeaAmoWFA
{
    public partial class Sales : UserControl
    {
        private readonly Database Db = new Database();

        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            GetSalesList();
        }

        private void Sales_EnabledChanged(object sender, EventArgs e)
        {
            GetSalesList();
        }

        private void GetSalesList()
        {
            // Clear the table
            SalesTable.Rows.Clear();

            // Get the transaction history
            var reader = Db.ExecuteReader($"SELECT * FROM `teaamopos`.`transaction_history` WHERE `date` = '{DateTime.Now.ToString("yyyy-MM-dd")}'");
            string date;
            DateTime datetime;

            while (reader.Read())
            {
                datetime = (DateTime)reader[1];
                date = datetime.ToString("dddd, dd MMMM yyyy");

                SalesTable.Rows.Add(reader[0], date, "PHP " + reader[2].ToString());
            }

            reader.Close();

            GetUnitsAndIncome();
        }

        private void GetUnitsAndIncome()
        {
            try
            {
                // Get values
                int UnitsSoldToday = Convert.ToInt32(Db.ExecuteScalar(
                    "SELECT SUM(qty_bought) " +
                    "FROM `teaamopos`.`transaction_history_items` " +
                    "INNER JOIN `teaamopos`.`transaction_history` ON transaction_history_items.id = transaction_history.id " +
                    $"WHERE `date` = '{DateTime.Now.ToString("yyyy-MM-dd")}'"));
                double IncomeToday = Convert.ToDouble(Db.ExecuteScalar(
                    "SELECT SUM(total_price) " +
                    "FROM `teaamopos`.`transaction_history_items` " +
                    "INNER JOIN `teaamopos`.`transaction_history` ON transaction_history_items.id = transaction_history.id " +
                    $"WHERE `date` = '{DateTime.Now.ToString("yyyy-MM-dd")}'"));

                // Put values into textboxes
                SoldUnitsBox.Text = UnitsSoldToday.ToString();
                TotalIncomeBox.Text = "PHP " + IncomeToday.ToString();
            }
            // This only catches if the database returns nothing.
            catch (InvalidCastException)
            {
                SoldUnitsBox.Text = "0";
                TotalIncomeBox.Text = "PHP 0";
            }
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
            using TransactionForm transactionForm = new TransactionForm();
            transactionForm.ShowDialog();

            GetSalesList();
        }

        private void SalesTable_DoubleClick(object sender, EventArgs e)
        {
            if (SalesTable.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(SalesTable.SelectedCells[0].Value.ToString());
                TransactionDetailsForm transactionDetailsForm = new TransactionDetailsForm(id);
                transactionDetailsForm.ShowDialog();
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            using ReportForm report = new ReportForm();
            report.ShowDialog();
        }
    }
}