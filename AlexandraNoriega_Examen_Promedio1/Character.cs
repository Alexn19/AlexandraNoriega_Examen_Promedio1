using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexandraNoriega_Examen_Promedio1
{
    public abstract class Character
    {
        public string name;
        public int damage;
        public int health;
        public Character(string name, int damage, int health)
        {
            this.name = name;
            this.damage = damage;
            this.health = health;
        }

        public abstract void Attack(Character target);

        public void TakeDamage(int damage)
        {
            health = health - damage;
        }
    }
}
