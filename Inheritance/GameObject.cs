using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class GameObject
    {
        public Point2D position;

        public GameObject()
        {
            Console.WriteLine("GameObject Class Constructed");
        }
    }
}
