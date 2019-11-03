using System;
using System.Text.RegularExpressions;
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
            var reader = Db.ExecuteReader(
                "SELECT `date`, `transaction_history`.`id`, SUM(`qty_bought`) AS `units_sold`, `total_price` " +
                "FROM `teaamopos`.`transaction_history` " +
                "INNER JOIN `teaamopos`.`transaction_history_items` ON `teaamopos`.`transaction_history`.`id` = `teaamopos`.`transaction_history_items`.`id` " +
                $"WHERE YEARWEEK(`date`, 1) = YEARWEEK('{DateTime.Now.ToString("yyyy-MM-dd")}', 1) " +
                "GROUP BY `transaction_history`.`id`"
                );

            while (reader.Read())
            {
                DateTime datetime = (DateTime) reader[0];
                string date = datetime.ToString("dddd, dd MMMM yyyy");

                SalesTable.Rows.Add(date, reader[1], reader[2], "PHP " + reader[3]);
            }

            reader.Close();

            
            if (!(SalesTable.Rows.Count <= 0))
            {
                GetUnitsAndIncome();
            }
        }

        private void GetUnitsAndIncome()
        {
            int units = 0;
            double income = 0;

            foreach (DataGridViewRow row in SalesTable.Rows)
            {
                units += Convert.ToInt32(row.Cells[2].Value.ToString());
                income += Convert.ToInt32(Regex.Match(row.Cells[3].Value.ToString(), @"-?\d+").Value);
            }

            // Create a row for totals
            SalesTable.Rows.Add("", "TOTAL", units.ToString(), "PHP " + income.ToString());
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
            using TransactionForm transactionForm = new TransactionForm();
            transactionForm.ShowDialog();

            GetSalesList();
        }

        private void SalesTable_DoubleClick(object sender, EventArgs e)
        {
            string selectedItem = SalesTable.SelectedCells[1].Value.ToString();

            if (SalesTable.SelectedCells.Count > 0)
            {
                if (selectedItem == "TOTAL")
                {
                    return;
                }

                int id = Convert.ToInt32(selectedItem);
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