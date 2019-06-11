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
    public partial class CareerBrowser : Form
    {
        public CareerBrowser()
        {
            InitializeComponent();
        }

        List<Battle> battles;

        CombatLog log;

        public void ShowCareer(Career career)
        {
            battles = new List<Battle>();
            foreach (var battle in career.Battles)
            {
                this.battles.Add(battle);
                BattleList.Items.Add(battle.Enemy.Name);
            }
            Show();
        }

        private void BattleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var battle = battles[BattleList.SelectedIndex];
            if (log == null || log.IsDisposed)
                log = new CombatLog();
            log.ShowLog(battle);
        }
    }
}
