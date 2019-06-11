using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat
{
    public class Round
    {
        public Character CharacterA { get; }
        public Character CharacterB { get; }
        public Dice.DiceRoll RollA { get; }
        public Dice.DiceRoll RollB { get; }
        public string Description { get; }
        int damage;
        bool AWins = false;
        public Round(Character a, Character b)
        {
            CharacterA = a;
            CharacterB = b;
            RollA = Dice.Roll();
            RollB = Dice.Roll();
            ApplyResults();
            Description = GenerateDescription();
        }

        void ApplyResults()
        {
            var totalA = CharacterA.Strenght + RollA.Result;
            var totalB = CharacterB.Strenght + RollB.Result;
            damage = Math.Abs(totalA - totalB);
            if (totalA < totalB)
            {
                CharacterA.Hurt(damage);
            }
            else if (totalB < totalA)
            {
                AWins = true;
                CharacterB.Hurt(damage);
            }
        }

        string GenerateDescription()
        {
            // return $"{CharacterA.Strenght}+{RollA.Result}, {CharacterB.Strenght}+{RollB.Result}";
            if (CharacterA.Dead)
                return $"{CharacterB.Name} strike down {CharacterA.Name} and emerges victorous!";
            if(CharacterB.Dead)
                return $"{CharacterA.Name} strike down {CharacterB.Name} and emerges victorous!";
            if (damage == 0)
                return $"{CharacterA.Name} and {CharacterB.Name} fight for positions but neither is able to land a strike";
            if (AWins)
                return $"{CharacterA.Name} overpowers {CharacterB.Name}, dealing {damage} damage.";
            return $"{CharacterB.Name} overpowers {CharacterA.Name}, dealing {damage} damage.";
        }
    }
}
