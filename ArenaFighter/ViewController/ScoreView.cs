using ArenaFighter.Combat;
using ArenaFighter.ViewController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaFighter.Controller
{
    public partial class ScoreView : Form
    {
        Career Career { get; set; }
        public ScoreView()
        {
            InitializeComponent();
        }

        public void ShowCarieer(Career career)
        {
            Career = career;
            var tally = new ScoreTally(career);
            CharacterName.Text = career.Player.Name;
            Score.Text = $"SCORE {tally.Score}";
            Show();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Battle_button_Click(object sender, EventArgs e)
        {
            new CareerBrowser().ShowCareer(Career);
        }
    }
}
