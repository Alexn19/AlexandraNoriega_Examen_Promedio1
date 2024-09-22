using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexandraNoriega_Examen_Promedio1
{
    public class Shadowheart : Character
    {
        private const string NAME = "Shadowheart";
        private const int DAMAGE = 20;
        private const int HEALTH = 80;

        public Shadowheart() : base(NAME, DAMAGE, HEALTH)
        {

        }
        public override void Attack(Character target)
        {
            target.health -= damage;
            Console.WriteLine(name + " Ataca y " + target.name + "  y pierde "+ damage + " de vida");
        }

        public void Healing()
        {
            health += 20;
            Console.WriteLine(name + " ha usado una poción y ha recuperado 20 de vida");
        }

        public void DoNothing()
        {
            Console.WriteLine("Te quedas parado, sin reaccionar");
        }
    }
}
