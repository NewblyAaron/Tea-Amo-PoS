namespace TeaAmoWFA.Forms
{
    partial class TransactionDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TransactionDetailsList = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyBought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPriceBox = new System.Windows.Forms.TextBox();
            this.TenderBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactionCodeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ChangeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDetailsList)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionDetailsList
            // 
            this.TransactionDetailsList.AllowUserToAddRows = false;
            this.TransactionDetailsList.AllowUserToDeleteRows = false;
            this.TransactionDetailsList.AllowUserToResizeColumns = false;
            this.TransactionDetailsList.AllowUserToResizeRows = false;
            this.TransactionDetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TransactionDetailsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.QtyBought});
            this.TransactionDetailsList.Location = new System.Drawing.Point(12, 61);
            this.TransactionDetailsList.MultiSelect = false;
            this.TransactionDetailsList.Name = "TransactionDetailsList";
            this.TransactionDetailsList.ReadOnly = true;
            this.TransactionDetailsList.RowHeadersVisible = false;
            this.TransactionDetailsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TransactionDetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionDetailsList.Size = new System.Drawing.Size(776, 327);
            this.TransactionDetailsList.TabIndex = 0;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // QtyBought
            // 
            this.QtyBought.HeaderText = "Quantity Bought";
            this.QtyBought.Name = "QtyBought";
            this.QtyBought.ReadOnly = true;
            // 
            // TotalPriceBox
            // 
            this.TotalPriceBox.Enabled = false;
            this.TotalPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceBox.Location = new System.Drawing.Point(642, 394);
            this.TotalPriceBox.Name = "TotalPriceBox";
            this.TotalPriceBox.Size = new System.Drawing.Size(146, 26);
            this.TotalPriceBox.TabIndex = 1;
            // 
            // TenderBox
            // 
            this.TenderBox.Enabled = false;
            this.TenderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenderBox.Location = new System.Drawing.Point(642, 426);
            this.TenderBox.Name = "TenderBox";
            this.TenderBox.Size = new System.Drawing.Size(146, 26);
            this.TenderBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tender";
            // 
            // TransactionCodeLabel
            // 
            this.TransactionCodeLabel.AutoSize = true;
            this.TransactionCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionCodeLabel.Location = new System.Drawing.Point(7, 9);
            this.TransactionCodeLabel.Name = "TransactionCodeLabel";
            this.TransactionCodeLabel.Size = new System.Drawing.Size(236, 29);
            this.TransactionCodeLabel.TabIndex = 3;
            this.TransactionCodeLabel.Text = "Transaction #[num]";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(8, 38);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateLabel.Size = new System.Drawing.Size(149, 20);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Date of Transaction";
            // 
            // ChangeBox
            // 
            this.ChangeBox.Enabled = false;
            this.ChangeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBox.Location = new System.Drawing.Point(642, 458);
            this.ChangeBox.Name = "ChangeBox";
            this.ChangeBox.Size = new System.Drawing.Size(146, 26);
            this.ChangeBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(565, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Change";
            // 
            // TransactionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TransactionCodeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeBox);
            this.Controls.Add(this.TenderBox);
            this.Controls.Add(this.TotalPriceBox);
            this.Controls.Add(this.TransactionDetailsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransactionDetailsForm";
            this.Text = "Transaction Details";
            this.Load += new System.EventHandler(this.TransactionDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDetailsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TransactionDetailsList;
        private System.Windows.Forms.TextBox TotalPriceBox;
        private System.Windows.Forms.TextBox TenderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TransactionCodeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox ChangeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyBought;
    }
}