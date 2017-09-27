using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextbasedWarriorGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Warrior maximus = new Warrior("Maximus", 1000, 140, 60);
            Warrior ceasar = new Warrior("Ceasar", 1000, 120, 80);

            Battle.StartFight(maximus, ceasar);

            Console.ReadLine();
        }
    }
}
