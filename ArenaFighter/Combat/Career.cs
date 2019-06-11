using Lexicon.CSharp.InfoGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat
{
    public class Career
    {
        public Character Player { get; }
        public Character Enemy => battle?.Enemy;
        public Battle battle;
        public InfoGenerator InfoGenerator { get; }
        public List<Battle> Battles { get; } = new List<Battle>();

        public Action<Options> OnChange { get; set; }

        public Career(Character player = null)
        {
            if(player == null)
            {
                player = new Character("Rocky")
                {
                    Strenght = 6,
                    MaxHealth = 10,
                };
            }
            InfoGenerator = new InfoGenerator(DateTime.Now.Millisecond);
            Player = player;
        }

        public void StartFight()
        {
            battle = new Battle(Player, RandomEnemy());
            Battles.Add(battle);
        }


        Character RandomEnemy()
        {
            var name = InfoGenerator.NextFullName();
            return new Character(name)
            {
                MaxHealth = Dice.Roll().Result + 3,
                Strenght = Dice.Roll().Result / 2 + 3,
            };
        }
    }
}
