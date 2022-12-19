namespace Amouzesh_1
{
    public class Weapon
    {
        string name;
        float price;
        int currentBullets;
        int maxBulletsInMagazine;
        float baseDamage = 100;
        float baseSound = 1;

        public string Name { get { return name; } }

        Attachment[] attachments = new Attachment[1] { new Attachment("Silencer", -100, -20) };

        // Attachment
        // Module

        public Weapon(string name, float price, int maxBulletsInMagazine)
        {
            this.name = name;
            this.price = price;
            this.maxBulletsInMagazine = maxBulletsInMagazine;
            this.currentBullets = this.maxBulletsInMagazine;

            baseSound += attachments[0].SoundModifiere;
            baseDamage += attachments[0].DamageModifiere;
        }

        public float Shoot()
        {
            currentBullets--;
            Console.WriteLine(name + " Base Damage is : " + baseDamage);
            Console.WriteLine(name + " Base Sound is : " + baseSound);

            return baseDamage;
        }

        public void Reload()
        {
            currentBullets = maxBulletsInMagazine;

            Console.WriteLine(name + " Reloaded");
        }

        public void MeleeAttack()
        {
            Console.WriteLine("Melee Attack was Performed from the bottom");
        }

        public void Buy()
        {

        }

        public void Sell()
        {

        }
    }
}
