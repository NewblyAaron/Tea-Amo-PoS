namespace TeaAmo
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.historyList = new System.Windows.Forms.ListView();
            this.headerDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.allRemoveButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.allRemoveButton);
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Controls.Add(this.backButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // historyList
            // 
            this.historyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerDate,
            this.headerName,
            this.headerCategory,
            this.headerId});
            this.historyList.FullRowSelect = true;
            this.historyList.GridLines = true;
            this.historyList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.historyList.Location = new System.Drawing.Point(12, 153);
            this.historyList.MultiSelect = false;
            this.historyList.Name = "historyList";
            this.historyList.Size = new System.Drawing.Size(466, 383);
            this.historyList.TabIndex = 2;
            this.historyList.UseCompatibleStateImageBehavior = false;
            this.historyList.View = System.Windows.Forms.View.Details;
            // 
            // headerDate
            // 
            this.headerDate.Text = "Date Added";
            this.headerDate.Width = 200;
            // 
            // headerName
            // 
            this.headerName.Text = "Item Name";
            this.headerName.Width = 150;
            // 
            // headerCategory
            // 
            this.headerCategory.Text = "Item Category";
            this.headerCategory.Width = 150;
            // 
            // headerId
            // 
            this.headerId.Text = "Item ID";
            this.headerId.Width = 130;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(6, 21);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(216, 22);
            this.dateBox.TabIndex = 3;
            this.dateBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.dateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateBox_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(228, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 50);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search items by Month and Day";
            // 
            // allRemoveButton
            // 
            this.allRemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allRemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.allRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allRemoveButton.Image = global::TeaAmo.Properties.Resources.database32;
            this.allRemoveButton.Location = new System.Drawing.Point(6, 21);
            this.allRemoveButton.Name = "allRemoveButton";
            this.allRemoveButton.Size = new System.Drawing.Size(216, 50);
            this.allRemoveButton.TabIndex = 3;
            this.allRemoveButton.Text = "Remove All History";
            this.allRemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.allRemoveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.allRemoveButton.UseVisualStyleBackColor = true;
            this.allRemoveButton.Click += new System.EventHandler(this.allRemoveButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Image = global::TeaAmo.Properties.Resources.remove32;
            this.removeButton.Location = new System.Drawing.Point(228, 21);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(228, 50);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove History";
            this.removeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = global::TeaAmo.Properties.Resources.back32;
            this.backButton.Location = new System.Drawing.Point(6, 77);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(216, 50);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Go Back";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(495, 555);
            this.Controls.Add(this.historyList);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tea Amo Histories";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button allRemoveButton;
        private System.Windows.Forms.ListView historyList;
        private System.Windows.Forms.ColumnHeader headerDate;
        private System.Windows.Forms.ColumnHeader headerName;
        private System.Windows.Forms.ColumnHeader headerCategory;
        private System.Windows.Forms.ColumnHeader headerId;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}