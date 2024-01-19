using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Enemy : Entity
    {
        public int scoreValue;
        public int xpDrop;
        public int goldDrop;

        public Enemy()
        {
            Console.WriteLine("Enemy Class Constructed");
        }
    }
}
