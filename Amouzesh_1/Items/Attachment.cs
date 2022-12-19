namespace Amouzesh_1
{
    public class Attachment
    {
        string name;

        public float SoundModifiere { get; private set; }
        public int DamageModifiere { get; private set; }

        public Attachment(string name, float soundModifiere, int damageModifiere)
        {
            this.name = name;
            SoundModifiere = soundModifiere;
            DamageModifiere = damageModifiere;
        }
    }
}
