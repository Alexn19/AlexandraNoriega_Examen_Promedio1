using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexandraNoriega_Examen_Promedio1
{
    class Program
    {
        static void ShowInterface(Shadowheart jugador, Enemy enemy)
        {
            Console.WriteLine("Tu vida: " + jugador.health + " \n Vida del enemigo: " + enemy.health + " \n ¿Qué harás ? \n 1:Atacar \n 2:Poción \n 3:No hacer nada");
        }
        static void Main(string[] args)
        {
            Shadowheart jugador = new Shadowheart();
            Enemy enemy = new Enemy();
            Console.WriteLine(enemy.name+ " ha aparecido.");
            while (enemy.health > 0 && jugador.health > 0) 
            {
                ShowInterface(jugador, enemy);

                string election = Console.ReadLine();
                switch (election)
                {
                    case "1":
                        jugador.Attack(enemy);
                        break;
                    case "2":
                        jugador.Healing();
                        break;
                    case "3": jugador.DoNothing();
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                enemy.Attack(jugador);
            }
            if (jugador.health > 0)
            {
                Console.WriteLine(jugador.name + " ha derrotado a " + enemy.name);
            }
            else
            {
                Console.WriteLine(enemy.name + " acabó contigo");
            }
        }
    }
}
