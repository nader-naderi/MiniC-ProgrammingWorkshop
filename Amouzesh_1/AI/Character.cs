using System.Diagnostics;

using static System.Net.Mime.MediaTypeNames;

namespace Amouzesh_1
{
    public abstract class Character : IDamagable
    {
        protected string type;
        protected string name;
        protected float baseDamage = 10;
        protected float health;
        protected float maxHealth = 100;
        
        private BaseItem[] items = new BaseItem[4];

        private int currentSelectedItem = 3;

        private static int howManyTimesWeMadeYou;

        public float Health { get { return health; } set { health = value; } }

        public Character(string name, float maxHealth)
        {
            this.name = name;
            this.maxHealth = maxHealth;
            howManyTimesWeMadeYou++;
        }

        public virtual void Attack(IDamagable target)
        {
            Console.WriteLine("You Performed Attack");
            Console.WriteLine("Attack hard");
        }

        public abstract void Talk();

        public static int ShowBuildTime()
        {
            return howManyTimesWeMadeYou;
        }

        public void AddItem(BaseItem item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                    items[i] = item;
            }

            Console.WriteLine("item " + item.Name + " has been added to the inventory.");
        }

        public void RemoveItem(BaseItem item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == item)
                    items[i] = null;
            }

            Console.WriteLine("you removed " + item.Name);
        }

        public void UseItem(int desiredItem = -1)
        {
            if(desiredItem  >= 0)
                currentSelectedItem = desiredItem;

            for (int i = 0; i < items.Length; i++)
            {
                if (currentSelectedItem == i)
                    items[i].Use();
            }
        }

        public void TakeDamage(float damage)
        {
            Health -= damage;
            Console.WriteLine(name + " took " + damage + " Damage, its health now is : " + health);
        }

        public void Interact(IInteractable toInteract)
        {
            toInteract.Interact();
        }
    }
}