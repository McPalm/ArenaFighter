using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat
{
    class ScoreTally
    {
        public int Score { get; }
        public ScoreTally(Career c)
        {
            var points = 0;
            foreach(Battle b in c.Battles)
            {
                if(b.Enemy.Dead)
                    points += b.Enemy.MaxHealth + b.Enemy.Strenght;
            }
            if (c.Player.Alive)
                points += c.Battles.Count;
            Score = points;
        }
    }
}
