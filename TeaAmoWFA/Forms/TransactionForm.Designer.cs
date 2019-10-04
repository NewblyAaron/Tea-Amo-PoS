namespace TeaAmoWFA
{
    partial class TransactionForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.OrderList = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddItem = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.QuantityButton = new System.Windows.Forms.Button();
            this.TotalPriceBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TransactionCodeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.UnitsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cart";
            // 
            // OrderList
            // 
            this.OrderList.AllowUserToAddRows = false;
            this.OrderList.AllowUserToDeleteRows = false;
            this.OrderList.AllowUserToResizeColumns = false;
            this.OrderList.AllowUserToResizeRows = false;
            this.OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.Qty,
            this.ItemPrice,
            this.SubTotalPrice});
            this.OrderList.Location = new System.Drawing.Point(12, 41);
            this.OrderList.MultiSelect = false;
            this.OrderList.Name = "OrderList";
            this.OrderList.ReadOnly = true;
            this.OrderList.RowHeadersVisible = false;
            this.OrderList.RowHeadersWidth = 82;
            this.OrderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderList.Size = new System.Drawing.Size(644, 612);
            this.OrderList.TabIndex = 12;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ID";
            this.ItemID.MinimumWidth = 40;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            this.ItemID.Width = 40;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 200;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.MinimumWidth = 10;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 200;
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "Item Price";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            this.ItemPrice.Visible = false;
            // 
            // SubTotalPrice
            // 
            this.SubTotalPrice.HeaderText = "Sub-total Price";
            this.SubTotalPrice.MinimumWidth = 10;
            this.SubTotalPrice.Name = "SubTotalPrice";
            this.SubTotalPrice.ReadOnly = true;
            this.SubTotalPrice.Width = 200;
            // 
            // AddItem
            // 
            this.AddItem.BackColor = System.Drawing.Color.Blue;
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem.ForeColor = System.Drawing.Color.White;
            this.AddItem.Location = new System.Drawing.Point(662, 603);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(224, 50);
            this.AddItem.TabIndex = 10;
            this.AddItem.Text = "Add Product";
            this.AddItem.UseVisualStyleBackColor = false;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Red;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(662, 555);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(224, 42);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // QuantityButton
            // 
            this.QuantityButton.BackColor = System.Drawing.Color.Gold;
            this.QuantityButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuantityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityButton.ForeColor = System.Drawing.Color.Black;
            this.QuantityButton.Location = new System.Drawing.Point(662, 507);
            this.QuantityButton.Name = "QuantityButton";
            this.QuantityButton.Size = new System.Drawing.Size(224, 42);
            this.QuantityButton.TabIndex = 10;
            this.QuantityButton.Text = "Quantity";
            this.QuantityButton.UseVisualStyleBackColor = false;
            this.QuantityButton.Click += new System.EventHandler(this.QuantityButton_Click);
            // 
            // TotalPriceBox
            // 
            this.TotalPriceBox.Enabled = false;
            this.TotalPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceBox.Location = new System.Drawing.Point(662, 470);
            this.TotalPriceBox.Name = "TotalPriceBox";
            this.TotalPriceBox.Size = new System.Drawing.Size(226, 31);
            this.TotalPriceBox.TabIndex = 4;
            this.TotalPriceBox.Text = "PHP 0";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.Black;
            this.PriceLabel.Location = new System.Drawing.Point(657, 438);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(73, 29);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Total";
            // 
            // TransactionCodeBox
            // 
            this.TransactionCodeBox.Enabled = false;
            this.TransactionCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionCodeBox.Location = new System.Drawing.Point(662, 41);
            this.TransactionCodeBox.Name = "TransactionCodeBox";
            this.TransactionCodeBox.Size = new System.Drawing.Size(219, 26);
            this.TransactionCodeBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(658, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Transaction Code";
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayButton.ForeColor = System.Drawing.Color.White;
            this.PayButton.Location = new System.Drawing.Point(12, 659);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(874, 50);
            this.PayButton.TabIndex = 10;
            this.PayButton.Text = "Finalize Transaction";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // UnitsBox
            // 
            this.UnitsBox.Enabled = false;
            this.UnitsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitsBox.Location = new System.Drawing.Point(660, 404);
            this.UnitsBox.Name = "UnitsBox";
            this.UnitsBox.Size = new System.Drawing.Size(226, 31);
            this.UnitsBox.TabIndex = 4;
            this.UnitsBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(657, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Units";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(893, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.TransactionCodeBox);
            this.Controls.Add(this.UnitsBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalPriceBox);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.QuantityButton);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.AddItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point-of-Sale";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView OrderList;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button QuantityButton;
        private System.Windows.Forms.TextBox TotalPriceBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox TransactionCodeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotalPrice;
        private System.Windows.Forms.TextBox UnitsBox;
        private System.Windows.Forms.Label label2;
    }
}