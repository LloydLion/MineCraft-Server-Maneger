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
    partial class ExecuteSetBlockActionForm : Form
    {
        public ExecuteSetBlockActionFormResult Result { get; private set; }

        public BlockInfo[] BlockSet { get; private set; }

        public ExecuteSetBlockActionForm(BlockInfo[] blocks)
        {
            InitializeComponent();

            BlockSet = blocks;
            comboBox.Items.AddRange(blocks.Select((s) => (object)s.DisplayName).ToArray());
        }

        public class ExecuteSetBlockActionFormResult
        {
            public (int x, int y, int z) Cords { get; set; }
            public BlockInfo Block { get; set; }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var block = BlockSet.Where((s) => s.DisplayName == comboBox.Text).Single();
            block.Meta = int.Parse(textBoxMeta.Text);

            Result = new ExecuteSetBlockActionFormResult
            {
                Cords = (int.Parse(textBoxX.Text), int.Parse(textBoxY.Text), int.Parse(textBoxZ.Text)),
                Block = block
            };

            this.Close();
        }
    }
}
