using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Amouzesh_1
{
    public class Airplane : IDamagable
    {
        protected string name;
        protected float health;

        public Airplane(string name, float health)
        {
            this.name = name;
            this.health = health;
        }

        public float Health { get; set; }

        public void TakeDamage(float damage)
        {
            health -= damage;
            Debug.WriteLine(name + " took " + damage + " Damage, its health now is : " + health);
        }
    }
}
