using MineCraft_Server_Maneger.Models.Generic;
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
    partial class ExecuteLocateActionForm : Form
    {

        public ExecuteLocateActionFormResult Result { get; private set; }

        private Locate[] locates;
        public ExecuteLocateActionForm(Locate[] locates)
        {
            InitializeComponent();
            this.locates = locates;

            comboBox.Items.AddRange(locates.Select((s) => s.Name).ToArray());
        }

        public class ExecuteLocateActionFormResult
        {
            public Locate Locate { get; set; }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Result = new ExecuteLocateActionFormResult()
            {
                Locate = locates.Where((s) => s.Name == comboBox.SelectedItem.ToString()).Single()
            };

            this.Close();
        }
    }
}
