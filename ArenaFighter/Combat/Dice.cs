using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat
{
    public class Dice
    {
        static Dice _dice;
        static Dice ADice => _dice ?? new Dice();
        readonly System.Random rng;

        Dice()
        {
            _dice = this;
            rng = new Random(DateTime.Now.Millisecond);
        }

        static public DiceRoll Roll()
        {
            var r = ADice.rng.Next(6) + 1;
            return new DiceRoll(r);
        }


        public class DiceRoll
        {
            public int Result { get; }

            public DiceRoll(int result)
            {
                Result = result;
            }
        }
    }
}
