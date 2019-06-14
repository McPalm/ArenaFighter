using Lexicon.CSharp.InfoGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat.RPG
{

    public class CharacterBuilder
    {
        static private InfoGenerator _gen;
        static protected InfoGenerator Generator
        {
            get
            {
                if (_gen == null)
                    _gen = new InfoGenerator(DateTime.Now.Millisecond);
                return _gen;
            }
        }

        protected CharacterData data = new CharacterData();

        static public implicit operator Character(CharacterBuilder b)
        {
            if (string.IsNullOrWhiteSpace(b.data.name))
                b.Name.IsRandom();
            return new Character(b.data.name)
            {
                MaxHealth = b.data.maxHP,
                Strenght = b.data.str,
            };
        }

        public CharacterAttributeBuilder Attributes => new CharacterAttributeBuilder(data);
        public CharacterNameBuilder Name => new CharacterNameBuilder(data);
        public class CharacterData
        {
            internal string name = "";
            internal int maxHP = 10;
            internal int str = 6;
        }
    }

    public class CharacterNameBuilder : CharacterBuilder
    {
        public CharacterNameBuilder(CharacterData data)
        {
            this.data = data;
        }

        public CharacterNameBuilder Is(string name)
        {
            data.name = name;
            return this;
        }

        public CharacterNameBuilder IsRandom()
        {
            data.name = Generator.NextFullName();
            return this;
        }
    }

    public class CharacterAttributeBuilder : CharacterBuilder
    {
        public CharacterAttributeBuilder(CharacterData data)
        {
            this.data = data;
        }

        public CharacterAttributeBuilder StrenghtIs(int str)
        {
            data.str = str;
            return this;
        }

        public CharacterAttributeBuilder MaxHealthIs(int hp)
        {
            data.maxHP = hp;
            return this;
        }
    }

}
