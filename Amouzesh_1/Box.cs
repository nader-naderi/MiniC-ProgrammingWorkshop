using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amouzesh_1
{
    public class Box : IDamagable
    {
        string name;

        public Box(string name)
        {
            this.name = name;
        }

        public float Health { get; set; } = 100;

        public void Break()
        {
            Console.WriteLine(name + " is Shattered.");
            // Soundeffect 
            // Particle 
        }

        public void TakeDamage(float damage)
        {
            Health -= damage;
            // 
            if (Health <= 0)
            {
                Break();
                Health = 0;
            }
        }
    }
}
