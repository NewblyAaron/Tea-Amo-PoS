namespace TeaAmoWFA
{
    partial class Users
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
            this.UsersTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Users";
            // 
            // UsersTable
            // 
            this.UsersTable.AllowUserToAddRows = false;
            this.UsersTable.AllowUserToDeleteRows = false;
            this.UsersTable.AllowUserToResizeColumns = false;
            this.UsersTable.AllowUserToResizeRows = false;
            this.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UsersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Username});
            this.UsersTable.Location = new System.Drawing.Point(3, 40);
            this.UsersTable.MultiSelect = false;
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.ReadOnly = true;
            this.UsersTable.RowHeadersVisible = false;
            this.UsersTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UsersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersTable.Size = new System.Drawing.Size(794, 557);
            this.UsersTable.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersTable);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.Users_Load);
            this.EnabledChanged += new System.EventHandler(this.Users_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UsersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
    }
}
