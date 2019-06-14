using ArenaFighter.Combat.RPG;
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
        public List<Battle> Battles { get; } = new List<Battle>();

        public Action<Options> OnChange { get; set; }

        public Career(Character player = null)
        {
            if(player == null)
            {
                player = new CharacterBuilder()
                    .Name.IsRandom()
                    .Attributes.StrenghtIs(6)
                    .MaxHealthIs(10);
            }
            Player = player;
        }

        public void StartFight()
        {
            battle = new Battle(Player, RandomEnemy());
            Battles.Add(battle);
        }


        Character RandomEnemy()
        {
            return new CharacterBuilder()
                .Name.IsRandom()
                .Attributes.StrenghtIs(Dice.Roll().Result / 2 + 3)
                .MaxHealthIs(Dice.Roll().Result + 3);
        }
    }
}
