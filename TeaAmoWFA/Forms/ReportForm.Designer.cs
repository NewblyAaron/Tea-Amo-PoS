namespace TeaAmoWFA.Forms
{
    partial class ReportForm
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
            this.ReportTable = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitsSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.TotalIncomeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalUnitsBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportTable
            // 
            this.ReportTable.AllowUserToAddRows = false;
            this.ReportTable.AllowUserToDeleteRows = false;
            this.ReportTable.AllowUserToResizeColumns = false;
            this.ReportTable.AllowUserToResizeRows = false;
            this.ReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ReportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.UnitsSold,
            this.Income});
            this.ReportTable.Location = new System.Drawing.Point(12, 41);
            this.ReportTable.MultiSelect = false;
            this.ReportTable.Name = "ReportTable";
            this.ReportTable.RowHeadersVisible = false;
            this.ReportTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ReportTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReportTable.Size = new System.Drawing.Size(532, 539);
            this.ReportTable.TabIndex = 0;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            // 
            // UnitsSold
            // 
            this.UnitsSold.HeaderText = "Units Sold";
            this.UnitsSold.Name = "UnitsSold";
            // 
            // Income
            // 
            this.Income.HeaderText = "Income Gained";
            this.Income.Name = "Income";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.ForeColor = System.Drawing.Color.White;
            this.GenerateButton.Location = new System.Drawing.Point(550, 136);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(202, 31);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate Report";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // TotalIncomeBox
            // 
            this.TotalIncomeBox.Enabled = false;
            this.TotalIncomeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalIncomeBox.Location = new System.Drawing.Point(550, 549);
            this.TotalIncomeBox.Name = "TotalIncomeBox";
            this.TotalIncomeBox.Size = new System.Drawing.Size(202, 31);
            this.TotalIncomeBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sales Report";
            // 
            // FromDate
            // 
            this.FromDate.Location = new System.Drawing.Point(550, 64);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(202, 20);
            this.FromDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "To";
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(550, 110);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(202, 20);
            this.ToDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(546, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Income";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Units Sold";
            // 
            // TotalUnitsBox
            // 
            this.TotalUnitsBox.Enabled = false;
            this.TotalUnitsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalUnitsBox.Location = new System.Drawing.Point(550, 492);
            this.TotalUnitsBox.Name = "TotalUnitsBox";
            this.TotalUnitsBox.Size = new System.Drawing.Size(202, 31);
            this.TotalUnitsBox.TabIndex = 3;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(764, 592);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.TotalUnitsBox);
            this.Controls.Add(this.TotalIncomeBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportForm";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox TotalIncomeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalUnitsBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitsSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income;
    }
}