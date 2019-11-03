namespace TeaAmo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.historyButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.itemButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(12, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(150, 20);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "Time: 00:00:00 PM";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(279, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(106, 20);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "System Date";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // historyButton
            // 
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.ForeColor = System.Drawing.Color.White;
            this.historyButton.Image = global::TeaAmo.Properties.Resources.report32;
            this.historyButton.Location = new System.Drawing.Point(457, 32);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(165, 125);
            this.historyButton.TabIndex = 2;
            this.historyButton.Text = "Manage History";
            this.historyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.historyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.ForeColor = System.Drawing.Color.White;
            this.categoryButton.Image = global::TeaAmo.Properties.Resources.category32;
            this.categoryButton.Location = new System.Drawing.Point(283, 163);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(165, 125);
            this.categoryButton.TabIndex = 3;
            this.categoryButton.Text = "Manage Categories";
            this.categoryButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.categoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // itemButton
            // 
            this.itemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.itemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemButton.ForeColor = System.Drawing.Color.White;
            this.itemButton.Image = global::TeaAmo.Properties.Resources.items32;
            this.itemButton.Location = new System.Drawing.Point(283, 32);
            this.itemButton.Name = "itemButton";
            this.itemButton.Size = new System.Drawing.Size(165, 125);
            this.itemButton.TabIndex = 1;
            this.itemButton.Text = "Manage Items";
            this.itemButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.itemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemButton.UseVisualStyleBackColor = true;
            this.itemButton.Click += new System.EventHandler(this.itemButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeaAmo.Properties.Resources.coffeeGif;
            this.pictureBox1.Location = new System.Drawing.Point(30, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::TeaAmo.Properties.Resources.remove32;
            this.button1.Location = new System.Drawing.Point(457, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 125);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log out";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(633, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.itemButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tea Amo Inventory System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button itemButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button button1;
    }
}