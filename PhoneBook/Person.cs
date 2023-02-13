namespace PhoneBook
{
    public class Person
    {
        string name;
        string phoneNumber;
        string job;
        string age;

        public Person(string name, string phoneNumber, string job, string age)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.job = job;
            this.age = age;
        }

        public string Name { get => name; }
        public string PhoneNumber { get => phoneNumber; }
        public string Job { get => job; }
        public string Age { get => age; }

        public override string ToString()
        {
            return "Name: " + name + "phone Number: " + phoneNumber + "Job: " + job + "Age: " + age;
        }
    }
}