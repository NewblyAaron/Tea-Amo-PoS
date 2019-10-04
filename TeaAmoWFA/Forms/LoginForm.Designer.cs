namespace TeaAmoWFA
{
    partial class LoginForm
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
            this.title = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.passLbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.loginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(134, 17);
            this.title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(328, 100);
            this.title.TabIndex = 0;
            this.title.Text = "Tea Amo";
            // 
            // loginBox
            // 
            this.loginBox.Controls.Add(this.LoginButton);
            this.loginBox.Controls.Add(this.passLbl);
            this.loginBox.Controls.Add(this.userLbl);
            this.loginBox.Controls.Add(this.passwordBox);
            this.loginBox.Controls.Add(this.usernameBox);
            this.loginBox.Location = new System.Drawing.Point(24, 121);
            this.loginBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginBox.Name = "loginBox";
            this.loginBox.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginBox.Size = new System.Drawing.Size(544, 288);
            this.loginBox.TabIndex = 1;
            this.loginBox.TabStop = false;
            this.loginBox.Text = "Login";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(330, 217);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(6, 10, 6, 6);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(150, 44);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(54, 133);
            this.passLbl.Margin = new System.Windows.Forms.Padding(6, 10, 6, 0);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(106, 25);
            this.passLbl.TabIndex = 1;
            this.passLbl.Text = "Password";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(54, 48);
            this.userLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(110, 25);
            this.userLbl.TabIndex = 1;
            this.userLbl.Text = "Username";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(56, 163);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(420, 31);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(56, 79);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(420, 31);
            this.usernameBox.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(592, 433);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button LoginButton;
    }
}

