using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amouzesh_1
{
    public class Door : IInteractable, IDamagable
    {
        bool isOpen = false;
        string name;
        public float Health { get; set; }
        public Door(string name)
        {
            this.name = name;
        }

        public void Interact()
        {
            // Toggle.
            isOpen = !isOpen;

            string state = "";

            if(isOpen)
            {
                state = "Is Open";
            }
            else
                state = "Is Closed";


            Console.WriteLine("We interacted with : " + name + ". now door is : " + state);
        }

        public void TakeDamage(float damage)
        {
            Health -= damage;
        }
    }
}
