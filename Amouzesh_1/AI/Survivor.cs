using Amouzesh_1;

namespace Amouzesh_1
{
    public class Survivor : Character
    {
        Weapon equipedWeapon;

        public Survivor(string name, Weapon equipedWeapon, float maxHealth) : base(name, maxHealth)
        {
            this.equipedWeapon = equipedWeapon;
        }

        public void EquipWeapon(Weapon desiredWeapon)
        {
            if (equipedWeapon == null)
                Console.WriteLine(desiredWeapon.Name + " Equiped");
            else
                Console.WriteLine(name + " droped the " + equipedWeapon.Name + ", " + desiredWeapon.Name + " Equiped");

            equipedWeapon = desiredWeapon;
        }

        public override void Attack(IDamagable target)
        {
            base.Attack(target);

            if (equipedWeapon != null)
            {
                target.TakeDamage(equipedWeapon.Shoot());
            }
            else
            {
                Console.WriteLine("You have no weapons equiped in your hands");
            }
        }

        public override void Talk()
        {
            Console.WriteLine("I'm a human");
        }
    }
}
