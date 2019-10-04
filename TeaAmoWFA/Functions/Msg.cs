using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TeaAmoWFA.Functions
{
    class Msg
    {
        private string title = "Tea Amo";

        public void Show(string msg)
        {
            MessageBox.Show(msg, title);
        }

        public void Info(string msg)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Warning(string msg)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Error(string msg)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult Question(string msg)
        {
            return MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public string Input(string msg)
        {
            return Interaction.InputBox(msg, title);
        }
    }
}
