using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft_Server_Maneger.Forms
{
    partial class ExecuteSayActionForm : Form
    {
        public ExecuteSayActionFormResult Result { get; private set; }

        public ExecuteSayActionForm()
        {
            InitializeComponent();
        }

        public class ExecuteSayActionFormResult
        {
            public string Message { get; set; }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Result = new ExecuteSayActionFormResult() { Message = textBox.Text };
            this.Close();
        }
    }
}
