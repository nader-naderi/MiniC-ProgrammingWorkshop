using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using static System.Formats.Asn1.AsnWriter;

namespace PhoneBook
{
    public partial class PhoneBook : Form
    {
        // temp.
        Person currentPerson;

        /// <summary>
        /// 0
        /// 1
        /// 2
        /// </summary>
        List<Person> personList = new List<Person>();

        private int currentIndex = 0;

        public PhoneBook()
        {
            InitializeComponent();

            string name = "Nader said: \"Hello\"";

            MessageBox.Show(name);

            using (StreamReader streamReader = new StreamReader("C:/Users/Nader Naderi/source/repos/Amouzesh_1/SavedData/phoneBook.json"))
            {
                string data = streamReader.ReadToEnd();

                currentPerson = JsonSerializer.Deserialize<Person>(data);


                for (int i = 0; i < personList.Count; i++)
                {

                }

                streamReader.Close();
            }

            nameTxtBox.Text = currentPerson.Name;
            phoneNumberTxtBox.Text = currentPerson.PhoneNumber;
            jobTxtBox.Text = currentPerson.Job;
            ageTxtBox.Text = currentPerson.Age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentPerson = new Person(nameTxtBox.Text, phoneNumberTxtBox.Text,
                jobTxtBox.Text, ageTxtBox.Text);

            MessageBox.Show(currentPerson.ToString());

            personList.Add(currentPerson);
            currentPerson = null;

            UpdateFields(true);

            StreamWriter textToWrite = new StreamWriter("C:/Users/Nader Naderi/source/repos/Amouzesh_1/SavedData/phoneBook.json");

            for (int i = 0; i < personList.Count; i++)
            {
                string currentObject = JsonSerializer.Serialize(personList[i]);

                textToWrite.Write(currentObject);
            }

            textToWrite.Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            currentIndex++;

            if (currentIndex >= personList.Count)
                currentIndex = 0;

            UpdateFields();
        }


        private void preBtn_Click(object sender, EventArgs e)
        {
            currentIndex--;

            if (currentIndex < 0)
                currentIndex = personList.Count - 1;

            UpdateFields();
        }

        private void UpdateFields(bool delete = false)
        {
            currentPerson = personList[currentIndex];
            nameTxtBox.Text = delete == true ? string.Empty : currentPerson.Name;
            phoneNumberTxtBox.Text = delete == true ? string.Empty : currentPerson.PhoneNumber;
            jobTxtBox.Text = delete == true ? string.Empty : currentPerson.Job;
            ageTxtBox.Text = delete == true ? string.Empty : currentPerson.Age;
        }
    }
}
