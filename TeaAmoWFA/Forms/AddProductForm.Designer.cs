namespace TeaAmoWFA
{
    partial class AddProductForm
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
            this.ProductsList = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsList
            // 
            this.ProductsList.AllowUserToAddRows = false;
            this.ProductsList.AllowUserToDeleteRows = false;
            this.ProductsList.AllowUserToResizeColumns = false;
            this.ProductsList.AllowUserToResizeRows = false;
            this.ProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.ItemPrice,
            this.QtyStock,
            this.Category});
            this.ProductsList.Location = new System.Drawing.Point(3, 3);
            this.ProductsList.MultiSelect = false;
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.ReadOnly = true;
            this.ProductsList.RowHeadersVisible = false;
            this.ProductsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsList.Size = new System.Drawing.Size(572, 278);
            this.ProductsList.TabIndex = 0;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "Price";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            // 
            // QtyStock
            // 
            this.QtyStock.HeaderText = "Stock";
            this.QtyStock.Name = "QtyStock";
            this.QtyStock.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Product";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ProductsList);
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 288);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SearchBox);
            this.panel2.Controls.Add(this.CategoryCombo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 64);
            this.panel2.TabIndex = 4;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(126, 31);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(433, 20);
            this.SearchBox.TabIndex = 4;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Items.AddRange(new object[] {
            "All"});
            this.CategoryCombo.Location = new System.Drawing.Point(16, 31);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(104, 21);
            this.CategoryCombo.TabIndex = 3;
            this.CategoryCombo.SelectedIndexChanged += new System.EventHandler(this.CategoryCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(12, 405);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(582, 50);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(606, 463);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddProductForm";
            this.Text = "Add a Product";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}