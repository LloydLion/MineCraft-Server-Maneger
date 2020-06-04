using MineCraft_Server_Maneger.Models.Generic;
using StandardLibrary.Collections;
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
    partial class ExecuteDifficultyActionForm : Form
    {
        public class ExecuteDifficultyActionFormResult
        { 
            public Difficulty Difficulty { get; set; }
        
        }

        public ExecuteDifficultyActionFormResult Result { get; private set; }

        public ExecuteDifficultyActionForm()
        {
            InitializeComponent();

            comboBox.Items.AddRange(Enum.GetNames(typeof(Difficulty)).Cast<object>().ToArray());
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Result = new ExecuteDifficultyActionFormResult
            {
                Difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), comboBox.Text)
            };

            this.Close();
        }
    }
}
