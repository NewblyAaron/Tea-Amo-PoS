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
            FromDate.Value = (DateTime) Db.ExecuteScalar("SELECT MIN(`date`) FROM `teaamopos`.`transaction_history`");
            ToDate.Value = DateTime.Now;
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
                "SELECT `item_name`, SUM(`qty_bought`), SUM(`subtotal`) AS `item_sales` " +
                "FROM `teaamopos`.`transaction_history_items` " +
                "JOIN `teaamoinv`.`dbo.items` ON `teaamopos`.`transaction_history_items`.`item_name` = `teaamoinv`.`dbo.items`.`name` " +
                "JOIN `teaamopos`.`transaction_history` ON `teaamopos`.`transaction_history_items`.`id` = `teaamopos`.`transaction_history`.`id` " +
                $"WHERE `teaamopos`.`transaction_history`.`date` BETWEEN '{FromDate.Value.ToString("yyyy-MM-dd")}' AND '{ToDate.Value.ToString("yyyy-MM-dd")}' " +
                "GROUP BY `item_name` ORDER BY `item_sales` DESC");

            while (reader.Read())
            {
                ReportTable.Rows.Add(reader[0], reader[1], "PHP " + reader[2]);
            }

            reader.Close();

            int units = 0;
            double income = 0;

            foreach (DataGridViewRow row in ReportTable.Rows)
            {
                units += Convert.ToInt32(row.Cells[1].Value.ToString());
                income += Convert.ToInt32(Regex.Match(row.Cells[2].Value.ToString(), @"-?\d+").Value);
            }

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
    }
}