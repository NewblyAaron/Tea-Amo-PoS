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
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Date,
            this.ID,
            this.UnitsSold,
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
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 150;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "Transaction ID";
            this.ID.MinimumWidth = 200;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // UnitsSold
            // 
            this.UnitsSold.HeaderText = "Units Sold";
            this.UnitsSold.MinimumWidth = 10;
            this.UnitsSold.Name = "UnitsSold";
            this.UnitsSold.ReadOnly = true;
            this.UnitsSold.Width = 200;
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
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}
