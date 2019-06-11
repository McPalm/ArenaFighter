using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArenaFighter.Combat;
using ArenaFighter.Controller;

namespace ArenaFighter
{
    public partial class Form1 : Form
    {

        public void Log(string text)
        {
            textLog.Text += text + "\n";
        }

        public void ClearLogs()
        {
            textLog.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new TheGodUIClass(this);
        }

        public void FormatLabels(Character player, Character enemy)
        {
            if (enemy == null)
                enemyLabel.Text = "";
            else
                enemyLabel.Text = $"{enemy.Name} {enemy.Health}/{enemy.MaxHealth}";
            playerLabel.Text = $"{player.Name} {player.Health}/{player.MaxHealth}";
        }
    }
}
