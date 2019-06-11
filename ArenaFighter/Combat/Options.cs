using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat
{
    public class Options
    {
        public Option OptionA;
        public Option OptionB;

        public class Option
        {
            public string label;
            public Action action;
        }
    }
}
