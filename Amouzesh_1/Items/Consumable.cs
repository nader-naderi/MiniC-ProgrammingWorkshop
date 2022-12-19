
namespace Amouzesh_1
{
    public class Consumable : BaseItem
    {
        public Consumable(string name, string description, int amount) : base(name, description, amount)
        {
        }

        public override void Use()
        {
            base.Use();
            Console.WriteLine(Name + " Consumed. " + Amount + " is left of it.");
        }

        public override void Use(int useAmount)
        {
            base.Use(useAmount);
            Console.WriteLine(Name + " Consumed. " + Amount + " is left of it.");
        }
    }
}
