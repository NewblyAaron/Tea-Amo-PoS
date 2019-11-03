using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TeaAmoWFA.Functions;

namespace TeaAmoWFA.Forms
{
    public partial class ReportForm : Form
    {
        private readonly Database Db = new Database();

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                FromDate.Value = (DateTime)Db.ExecuteScalar("SELECT MIN(`date`) FROM `teaamopos`.`transaction_history`");
                ToDate.Value = DateTime.Now;
            }
            catch (InvalidCastException)
            {
                FromDate.Value = DateTime.Now;
                ToDate.Value = DateTime.Now;
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            if (!DatesInBetween())
            {
                return;
            }

            ReportTable.Rows.Clear();

            var reader = Db.ExecuteReader(
                "SELECT `date`, `transaction_history`.`id`, item_name, qty_bought, total_price " +
                "FROM `teaamopos`.`transaction_history_items` " +
                "INNER JOIN `teaamopos`.`transaction_history` ON `teaamopos`.`transaction_history_items`.`id` = `teaamopos`.`transaction_history`.`id` " +
                $"WHERE `date` BETWEEN '{FromDate.Value.ToString("yyyy-MM-dd")}' AND '{ToDate.Value.ToString("yyyy-MM-dd")}' " +
                "ORDER BY `transaction_history`.`date` ASC"
                );

            string date;
            DateTime datetime;

            while (reader.Read())
            {
                datetime = (DateTime) reader[0];
                date = datetime.ToString("dddd, dd MMMM yyyy");

                ReportTable.Rows.Add(date, reader[1], reader[2], reader[3], "PHP " + reader[4]);
            }

            reader.Close();

            if (!(ReportTable.Rows.Count <= 0))
            {
                GenerateTotals();
            }
        }

        private void GenerateTotals()
        {
            int units = 0;
            double income = 0;

            foreach (DataGridViewRow row in ReportTable.Rows)
            {
                units += Convert.ToInt32(row.Cells[3].Value.ToString());
                income += Convert.ToInt32(Regex.Match(row.Cells[4].Value.ToString(), @"-?\d+").Value);
            }

            PopularItem.Text = Db.ExecuteScalar("SELECT item_name, SUM(qty_bought) AS qty " +
                "FROM teaamopos.transaction_history_items " +
                "GROUP BY item_name ORDER BY qty DESC"
                ).ToString();
            TotalUnitsBox.Text = units.ToString();
            TotalIncomeBox.Text = "PHP " + income.ToString();
        }

        private bool DatesInBetween()
        {
            if (FromDate.Value >= ToDate.Value)
            {
                new Msg().Error("Dates must be at least one day apart!");

                FromDate.Value = (DateTime) Db.ExecuteScalar("SELECT MIN(`date`) FROM `teaamopos`.`transaction_history`");
                ToDate.Value = DateTime.Now;

                return false;
            }

            return true;
        }

        private void ReportTable_DoubleClick(object sender, EventArgs e)
        {
            if (ReportTable.SelectedCells.Count > 0)
            {
                int id = Convert.ToInt32(ReportTable.SelectedCells[1].Value.ToString());
                TransactionDetailsForm transactionDetailsForm = new TransactionDetailsForm(id);
                transactionDetailsForm.ShowDialog();
            }
        }
    }
}