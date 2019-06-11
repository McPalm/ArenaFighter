using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat
{
    public class Battle
    {
        Character Player { get; }
        public Character Enemy { get; }
        List<string> Log { get; } = new List<string>();
        List<Round> Rounds { get; } = new List<Round>();
        public List<string> GetLog => new List<string>(Log);
        public List<Round> GetRounds => new List<Round>(Rounds);
        public string LastRoundDescription => Log[Log.Count-1];
        public bool FightIsOver { get; private set; } = false;

        public Battle(Character player, Character enemy)
        {
            if (player == null || enemy == null)
                throw new ArgumentNullException();
            Player = player;
            Enemy = enemy;
        }

        public void SimulateRound()
        {
            if (Player.Dead || Enemy.Dead)
                return;
            var round = new Round(Player, Enemy);
            FightIsOver = Player.Dead || Enemy.Dead;
            Rounds.Add(round);
            Log.Add(round.Description);
        }
    }
}
