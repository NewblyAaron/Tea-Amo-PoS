namespace TeaAmoWFA
{
    partial class Products
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsTable = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Products";
            // 
            // ProductsTable
            // 
            this.ProductsTable.AllowUserToAddRows = false;
            this.ProductsTable.AllowUserToDeleteRows = false;
            this.ProductsTable.AllowUserToResizeColumns = false;
            this.ProductsTable.AllowUserToResizeRows = false;
            this.ProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.Category,
            this.ItemName,
            this.Price,
            this.Stock});
            this.ProductsTable.Location = new System.Drawing.Point(3, 40);
            this.ProductsTable.MultiSelect = false;
            this.ProductsTable.Name = "ProductsTable";
            this.ProductsTable.ReadOnly = true;
            this.ProductsTable.RowHeadersVisible = false;
            this.ProductsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsTable.Size = new System.Drawing.Size(794, 557);
            this.ProductsTable.TabIndex = 3;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsTable);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.Products_Load);
            this.EnabledChanged += new System.EventHandler(this.Products_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}
