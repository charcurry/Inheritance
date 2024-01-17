using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Item : GameObject
    {
        public string itemName;

        public Item() 
        {
            Console.WriteLine("Item Class Constructed");
        }
    }
}
