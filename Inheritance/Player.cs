using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Player : Entity
    {
        public int xp;
        public int level;
        public int score;
        public int gold;

        public Player()
        {
            Console.WriteLine("Player Class Constructed");
        }
    }
}
