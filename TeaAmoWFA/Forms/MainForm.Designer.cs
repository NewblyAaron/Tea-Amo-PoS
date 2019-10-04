namespace TeaAmoWFA
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsersButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MinimizeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.SalesControl = new TeaAmoWFA.Sales();
            this.ProductsControl = new TeaAmoWFA.Products();
            this.UsersControl = new TeaAmoWFA.Users();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.UsersButton);
            this.panel1.Controls.Add(this.SalesButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ProductsButton);
            this.panel1.Location = new System.Drawing.Point(13, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 216);
            this.panel1.TabIndex = 0;
            // 
            // UsersButton
            // 
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.ForeColor = System.Drawing.Color.White;
            this.UsersButton.Location = new System.Drawing.Point(8, 157);
            this.UsersButton.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(160, 46);
            this.UsersButton.TabIndex = 1;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesButton.ForeColor = System.Drawing.Color.White;
            this.SalesButton.Location = new System.Drawing.Point(8, 49);
            this.SalesButton.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(160, 46);
            this.SalesButton.TabIndex = 1;
            this.SalesButton.Text = "Sales";
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // ProductsButton
            // 
            this.ProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsButton.ForeColor = System.Drawing.Color.White;
            this.ProductsButton.Location = new System.Drawing.Point(8, 103);
            this.ProductsButton.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(160, 46);
            this.ProductsButton.TabIndex = 1;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.UseVisualStyleBackColor = true;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tea Amo";
            // 
            // ExitMenu
            // 
            this.ExitMenu.ForeColor = System.Drawing.Color.White;
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(26, 22);
            this.ExitMenu.Text = "X";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Clicked);
            // 
            // MinimizeMenu
            // 
            this.MinimizeMenu.ForeColor = System.Drawing.Color.White;
            this.MinimizeMenu.Name = "MinimizeMenu";
            this.MinimizeMenu.Size = new System.Drawing.Size(24, 22);
            this.MinimizeMenu.Text = "_";
            this.MinimizeMenu.Click += new System.EventHandler(this.MinimizeMenu_Clicked);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenu,
            this.MinimizeMenu});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // SalesControl
            // 
            this.SalesControl.Location = new System.Drawing.Point(202, 36);
            this.SalesControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SalesControl.Name = "SalesControl";
            this.SalesControl.Size = new System.Drawing.Size(800, 600);
            this.SalesControl.TabIndex = 5;
            // 
            // ProductsControl
            // 
            this.ProductsControl.Enabled = false;
            this.ProductsControl.Location = new System.Drawing.Point(202, 36);
            this.ProductsControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ProductsControl.Name = "ProductsControl";
            this.ProductsControl.Size = new System.Drawing.Size(800, 600);
            this.ProductsControl.TabIndex = 6;
            this.ProductsControl.Visible = false;
            // 
            // UsersControl
            // 
            this.UsersControl.Enabled = false;
            this.UsersControl.Location = new System.Drawing.Point(202, 36);
            this.UsersControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UsersControl.Name = "UsersControl";
            this.UsersControl.Size = new System.Drawing.Size(800, 600);
            this.UsersControl.TabIndex = 7;
            this.UsersControl.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1012, 644);
            this.Controls.Add(this.SalesControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.ProductsControl);
            this.Controls.Add(this.UsersControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem MinimizeMenu;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Label label1;
        private Sales SalesControl;
        private Products ProductsControl;
        private Users UsersControl;
    }
}