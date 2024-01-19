using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Entity : GameObject
    {
        private HealthSystem healthSystem;

        public Entity()
        {
            Console.WriteLine("Entity Class Constructed");

            healthSystem = new HealthSystem();
        }

        public int GetHealth()
        {
            return healthSystem.health;
        }

        public void SetHealth(int health)
        {
            healthSystem.health = health;
        }
    }
}
