using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timespinner_Calculator.Game_Data;

namespace Timespinner_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (orbSelector.SelectedIndex == -1) //If no Orb is selected, select Blue Orb.
            {
                orbSelector.SelectedIndex = 0;
            }
            var baseDamage = GameData.orbBaseDamage[orbSelector.Text];
            var willpower = willpowerInput.Value;
            var level = orbLevelInput.Value;
            var orbDamage = (int)((baseDamage / 2 + willpower / 12 + (baseDamage * willpower) / 16) * (1 + (level - 1) / 100));

            orbDamageOutput.Text = "Orb Damage: " + orbDamage;
        }
    }
}
