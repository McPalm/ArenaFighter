using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter.Combat
{
    public class Character
    {
        public string Name { get; }
        public int Strenght { set; get; }
        public int Health => MaxHealth - Lost;
        public int Lost { private set; get; }
        public int MaxHealth { set; get; }
        public bool Dead => Health <= 0;
        public bool Alive => Health > 0;
        public Action<int> OnChangeHealth;

        public void Hurt(int damage)
        {
            damage = damage < 0 ? 0 : damage;
            Lost += damage;
            Lost = MyMath.Clamp(Lost, 0, MaxHealth);
            OnChangeHealth?.Invoke(Health);
        }

        public void Heal(int damage)
        {
            damage = damage < 0 ? 0 : damage;
            Lost -= damage;
            Lost = MyMath.Clamp(Lost, 0, MaxHealth);
            OnChangeHealth?.Invoke(Health);
        }

        public Character(string name)
        {
            Name = name;
        }
    }
}
