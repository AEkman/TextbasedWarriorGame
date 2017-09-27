using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextbasedWarriorGame
{
    class Warrior
    {

        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // Random generator
        Random random = new Random();

        // Create a warrior
        public Warrior(string name = "Warrior",
            double health = 0,
            double attackMax = 0,
            double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        // Attack method - random generated
        public double Attack()
        {
            return random.Next(1, (int)AttackMax);
        }

        // Block method - random generated

        public double Block()
        {
            return random.Next(1, (int)BlockMax);
        }
    }
}
