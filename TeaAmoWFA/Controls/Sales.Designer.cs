namespace TeaAmoWFA
{
    partial class Sales
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalesTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SoldUnitsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalIncomeBox = new System.Windows.Forms.TextBox();
            this.ReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesTable
            // 
            this.SalesTable.AllowUserToAddRows = false;
            this.SalesTable.AllowUserToDeleteRows = false;
            this.SalesTable.AllowUserToResizeColumns = false;
            this.SalesTable.AllowUserToResizeRows = false;
            this.SalesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SalesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.TotalPrice});
            this.SalesTable.Location = new System.Drawing.Point(3, 40);
            this.SalesTable.MultiSelect = false;
            this.SalesTable.Name = "SalesTable";
            this.SalesTable.ReadOnly = true;
            this.SalesTable.RowHeadersVisible = false;
            this.SalesTable.RowHeadersWidth = 82;
            this.SalesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalesTable.Size = new System.Drawing.Size(794, 497);
            this.SalesTable.TabIndex = 0;
            this.SalesTable.DoubleClick += new System.EventHandler(this.SalesTable_DoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "Transaction ID";
            this.ID.MinimumWidth = 50;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 200;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date of Transaction";
            this.Date.MinimumWidth = 10;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 10;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 200;
            // 
            // TransactionButton
            // 
            this.TransactionButton.BackColor = System.Drawing.Color.Wheat;
            this.TransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionButton.Location = new System.Drawing.Point(519, 543);
            this.TransactionButton.Name = "TransactionButton";
            this.TransactionButton.Size = new System.Drawing.Size(278, 54);
            this.TransactionButton.TabIndex = 1;
            this.TransactionButton.Text = "New Transaction";
            this.TransactionButton.UseVisualStyleBackColor = false;
            this.TransactionButton.Click += new System.EventHandler(this.TransactionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales";
            // 
            // SoldUnitsBox
            // 
            this.SoldUnitsBox.Enabled = false;
            this.SoldUnitsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldUnitsBox.Location = new System.Drawing.Point(115, 543);
            this.SoldUnitsBox.Name = "SoldUnitsBox";
            this.SoldUnitsBox.Size = new System.Drawing.Size(174, 26);
            this.SoldUnitsBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Units Sold Today";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Today\'s Income";
            // 
            // TotalIncomeBox
            // 
            this.TotalIncomeBox.Enabled = false;
            this.TotalIncomeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalIncomeBox.Location = new System.Drawing.Point(115, 571);
            this.TotalIncomeBox.Name = "TotalIncomeBox";
            this.TotalIncomeBox.Size = new System.Drawing.Size(174, 26);
            this.TotalIncomeBox.TabIndex = 3;
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.Color.Wheat;
            this.ReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(661, 3);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(136, 34);
            this.ReportButton.TabIndex = 1;
            this.ReportButton.Text = "Sales Report";
            this.ReportButton.UseVisualStyleBackColor = false;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalIncomeBox);
            this.Controls.Add(this.SoldUnitsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.TransactionButton);
            this.Controls.Add(this.SalesTable);
            this.Name = "Sales";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.Sales_Load);
            this.EnabledChanged += new System.EventHandler(this.Sales_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.SalesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesTable;
        private System.Windows.Forms.Button TransactionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SoldUnitsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalIncomeBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Button ReportButton;
    }
}
