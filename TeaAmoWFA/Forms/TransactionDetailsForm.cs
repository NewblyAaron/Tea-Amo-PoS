using System;
using System.Windows.Forms;

namespace TeaAmoWFA.Forms
{
    public partial class TransactionDetailsForm : Form
    {
        private readonly Database Db = new Database();
        private readonly int TransactionId;

        public TransactionDetailsForm(int transactionId)
        {
            InitializeComponent();

            TransactionId = transactionId;
        }

        private void TransactionDetailsForm_Load(object sender, EventArgs e)
        {
            GetDetails();
        }

        private void GetDetails()
        {
            // Transaction ID
            TransactionCodeLabel.Text = "Transaction #" + TransactionId.ToString();

            // Date
            DateTime datetime = (DateTime)Db.ExecuteScalar($"SELECT `date` FROM `teaamopos`.`transaction_history` WHERE `id` = {TransactionId}");
            string date = datetime.ToString("dddd, dd MMMM yyyy");
            DateLabel.Text = date;

            // Items
            var reader = Db.ExecuteReader($"SELECT * FROM `teaamopos`.`transaction_history_items` WHERE `id` = {TransactionId}");

            while (reader.Read())
            {
                TransactionDetailsList.Rows.Add(reader[1], reader[2]);
            }

            reader.Close();

            // Total Price, Tender. and Change
            TotalPriceBox.Text = "PHP " + Db.ExecuteScalar($"SELECT `total_price` FROM `teaamopos`.`transaction_history` WHERE `id` = {TransactionId}").ToString();
            TenderBox.Text = "PHP " + Db.ExecuteScalar($"SELECT `tender` FROM `teaamopos`.`transaction_history` WHERE `id` = {TransactionId}").ToString();
            ChangeBox.Text = "PHP " + Db.ExecuteScalar($"SELECT `change` FROM `teaamopos`.`transaction_history` WHERE `id` = {TransactionId}").ToString();
        }
    }
}