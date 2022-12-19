
namespace Amouzesh_1
{
    public abstract class BaseItem
    {
        public BaseItem(string name, string description, int amount)
        {
            Name = name;
            Description = description;
            Amount = amount;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Amount { get; private set; }
        
        public virtual void Use()
        {
            Amount--;
        }
        public virtual void Use(int useAmount)
        {
            Amount -= useAmount;
        }

        public void Drop()
        {

        }
    }
}
