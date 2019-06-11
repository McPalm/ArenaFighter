using ArenaFighter.Combat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaFighter.ViewController
{
    public partial class CombatLog : Form
    {
        public CombatLog()
        {
            InitializeComponent();
        }

        public void ShowLog(Battle battle)
        {
            var sb = new StringBuilder();
            foreach (var line in battle.GetLog)
            {
                sb.Append(line).Append('\n');
            }
            textBox.Text = sb.ToString();
            Show();
        }

    }
}
