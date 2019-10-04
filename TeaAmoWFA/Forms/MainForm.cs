using System;
using System.Windows.Forms;
using TeaAmoWFA.Functions;

namespace TeaAmoWFA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Menu Bar Methods
        private void MinimizeMenu_Clicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitMenu_Clicked(object sender, EventArgs e)
        {
            if (new Msg().Question("Are you sure you want to exit the application?") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Button Methods
        private void SalesButton_Click(object sender, EventArgs e)
        {
            ProductsControl.Enabled = false;
            ProductsControl.Visible = false;

            UsersControl.Enabled = false;
            UsersControl.Visible = false;

            SalesControl.Enabled = true;
            SalesControl.Visible = true;
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            SalesControl.Enabled = false;
            SalesControl.Visible = false;

            UsersControl.Enabled = false;
            UsersControl.Visible = false;

            ProductsControl.Enabled = true;
            ProductsControl.Visible = true;
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            SalesControl.Enabled = false;
            SalesControl.Visible = false;

            ProductsControl.Enabled = false;
            ProductsControl.Visible = false;

            UsersControl.Enabled = true;
            UsersControl.Visible = true;
        }
    }
}