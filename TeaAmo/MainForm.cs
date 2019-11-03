using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeaAmo
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
        }

        // DISABLE THE X BUTTON ON WINOWS FORM \\
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // SYSTEM TIME AND DATE \\
            timer1.Start();
            timeLabel.Text = "Time: " + DateTime.Now.ToLongTimeString();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            
        }
        
        // Timer for System Time \\
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = "Time: " + DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        // ITEM BUTTON \\
        private void itemButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ItemForm items = new ItemForm();
            items.Show();
        }

        // CATEGORY BUTTON \\
        private void categoryButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CategoryForm category = new CategoryForm();
            category.Show();
        }

        // HISTORY BUTTON \\
        private void historyButton_Click(object sender, EventArgs e)
        {
            this.Close();
            HistoryForm history = new HistoryForm();
            history.Show();
        }

        // CLOSE BUTTON  \\
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Exit application now?", "Tea Amo Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }

        }
    }
}
