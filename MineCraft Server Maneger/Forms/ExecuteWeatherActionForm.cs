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
    partial class ExecuteWeatherActionForm : Form
    {
        public class ExecuteWeatherActionFormResult
        { 
            public WeatherStade WeatherStade { get; set; }
        
        }

        public ExecuteWeatherActionFormResult Result { get; private set; }

        private Player[] players;

        public ExecuteWeatherActionForm()
        {
            InitializeComponent();

            comboBox.Items.AddRange(Enum.GetNames(typeof(WeatherStade)).Cast<object>().ToArray());
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Result = new ExecuteWeatherActionFormResult
            {
                WeatherStade = (WeatherStade)Enum.Parse(typeof(WeatherStade), comboBox.Text)
            };

            this.Close();
        }
    }
}
