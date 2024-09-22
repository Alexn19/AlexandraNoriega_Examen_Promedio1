using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace AlexandraNoriega_Examen_Promedio1
{
    public class Enemy : Character
    {
        private const string NAME = "Goblin";
        private const int HEALTH = 50;
        private const int DAMAGE = 15;

        public Enemy() : base(NAME, DAMAGE, HEALTH)
        {

        }
        public override void Attack(Character target)
        {
            target.health -= damage;
            Console.WriteLine(name + " Ataca y " + target.name + "  y pierde " + damage + " de vida");
        }
    }
}
