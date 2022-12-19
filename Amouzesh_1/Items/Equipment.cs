

namespace Amouzesh_1
{
    public class Equipment : BaseItem
    {
        public Equipment(string name, string description, int amount) : base(name, description, amount)
        {
        }

        public void Wear()
        {
            Console.WriteLine("You weared " + Name);
        }

        public override void Use()
        {
            Wear();
        }

        public override void Use(int useAmount)
        {

        }

    }
}
