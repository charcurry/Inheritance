using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");
            Console.WriteLine("-----------------");
            Console.WriteLine();

            Player player = new Player();
            player.SetHealth(10);
            player.position.x = 0;
            player.position.y = 0;

            Enemy enemy = new Enemy();
            enemy.SetHealth(5);
            enemy.position.x = 10;
            enemy.position.y = 10;

            Item item = new Item();
            item.itemName = "Sword";
            item.position.x = 15;
            item.position.y = 15;

            Console.WriteLine("Player Health: " + player.GetHealth());
            Console.WriteLine("Enemy Health: " + enemy.GetHealth());

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
            // test
        }
    }
}
