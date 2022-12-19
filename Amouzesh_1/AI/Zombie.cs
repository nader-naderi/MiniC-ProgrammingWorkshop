using Amouzesh_1;

namespace Amouzesh_1
{
    class Zombie : Character
    {
        float biteDamage = 5;

        public Zombie(string name, float maxHealth) : base(name, maxHealth)
        {

        }

        public override void Attack(IDamagable target)
        {
            base.Attack(target);
            Console.WriteLine("Zombie Attacked and bite " + biteDamage);
        }

        public override void Talk()
        {
            Console.WriteLine("I'm a Zombie and hungry");
            Console.WriteLine("agwtywrqweq");
            Console.WriteLine("dgrthjyuq");
        }

		public override string ToString()
		{
            return "Name : " + name;
		}
	}
}
