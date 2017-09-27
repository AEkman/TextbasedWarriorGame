using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextbasedWarriorGame
{
    class Battle
    {

        // Battleloop - check 2 warriors fighting against eachother until "game over"
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while(true)
            {
                if(GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warriorAAttackAmount = warriorA.Attack();
            double warriorBBlockAmount = warriorB.Block();

            double damageToWarriorB = warriorAAttackAmount - warriorBBlockAmount;

            if (damageToWarriorB > 0)
            {
                warriorB.Health = warriorB.Health - damageToWarriorB;
            }
            else damageToWarriorB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                warriorA.Name,
                warriorB.Name,
                damageToWarriorB);

            Console.WriteLine("{0} Has {1} Health\n",
                warriorB.Name,
                warriorB.Health);
            ;

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorious\n", warriorB.Name, warriorA.Name);

                return "Game Over";
            }
            else return "Fight Again";
        }
    }
}
