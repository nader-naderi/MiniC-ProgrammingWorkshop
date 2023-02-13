using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class AddressBook : Form
    {
        public AddressBook()
        {
            InitializeComponent();
        }
        
        // Applicaion Programming Interface
        // Cryptography.
        // 09036379299

        private int currentAddressIndex;
        public AddressBookContainer Addressess { get; private set; }
        public Address CurrentAddress { get => Addressess.Items[currentAddressIndex - 1] as Address; }

        int CurrentAddressIndex
        {
            get
            {
                return currentAddressIndex;
            }
            set
            {
                currentAddressIndex = value;
                PopulateFormFromAddress(CurrentAddress);
                lblAddressNumber.Text = currentAddressIndex + " of " + Addressess.Items.Count;
            }
        }

        public string DataFileName => Environment.CurrentDirectory + "\\AddressBook.xml";

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            PopulateAddressFromForm(address);
            string filename = DataFileName;
            address.Save(filename);
            MessageBox.Show("The address was saved to " + filename);
        }

        private void PopulateAddressFromForm(Address address)
        {
            address.FirstName = firstNameTxt.Text;
            address.LastName = lastNameTxt.Text;
            address.CompanyName = companyNameTxt.Text;
            address.AddressOne = addressOneTxt.Text;
            address.AddressTwo = addressTwoTxt.Text;
            address.City = cityTxt.Text;
            address.Region = regionTxt.Text;
            address.PostalCode = postalCodeTxt.Text;
            address.Country = countryTxt.Text;
            address.Email = emailTxt.Text;
        }

        private void PopulateFormFromAddress(Address address)
        {
            firstNameTxt.Text = address.FirstName;
            lastNameTxt.Text = address.LastName;
            companyNameTxt.Text = address.CompanyName;
            addressOneTxt.Text = address.AddressOne;
            addressTwoTxt.Text = address.AddressTwo;
            cityTxt.Text = address.City;
            regionTxt.Text = address.Region;
            postalCodeTxt.Text = address.PostalCode;
            countryTxt.Text = address.Country;
            emailTxt.Text = address.Email;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            Address newAddress = (Address)SerializableData.Load(DataFileName, typeof(Address));
            PopulateFormFromAddress(newAddress);
        }

        private void sendEmailLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("milato" + emailTxt.Text);
        }

        private void AddressBook_Load(object sender, EventArgs e)
        {
            // Polymorphism ... 
            Addressess = (AddressBookContainer)SerializableData.Load(DataFileName,
                typeof(AddressBookContainer));

            if (Addressess.Items.Count == 0)
                Addressess.AddAddress();

            CurrentAddressIndex = 1;
        }

        private void AddressBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateCurrentAddress();
            SaveChanges();
        }

        public void SaveChanges()
        {
            Addressess.Save(DataFileName);
        }

        public void UpdateCurrentAddress()
        {
            PopulateAddressFromForm(CurrentAddress);
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            AddNewAddress();
        }

        public Address AddNewAddress()
        {
            UpdateCurrentAddress();
            Address newAddress = Addressess.AddAddress();
            CurrentAddressIndex = Addressess.Items.Count;
            return newAddress;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            MoveNext();
        }

        private void MoveNext()
        {
            int newIndex = CurrentAddressIndex + 1;
            
            if (newIndex > Addressess.Items.Count)
                newIndex = 1;

            UpdateCurrentAddress();

            CurrentAddressIndex = newIndex;
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            MovePrevious();
        }

        private void MovePrevious()
        {
            int newIndex = CurrentAddressIndex - 1;

            if (newIndex == 0)
                newIndex = Addressess.Items.Count;

            UpdateCurrentAddress();
            CurrentAddressIndex = newIndex;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Address Book", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteAddress(CurrentAddressIndex);
            }
        }

        private void DeleteAddress(int index)
        {
            Addressess.Items.RemoveAt(index - 1);

            if (Addressess.Items.Count == 0)
                Addressess.AddAddress();
            else
                if (index > Addressess.Items.Count)
                    index = Addressess.Items.Count;


            CurrentAddressIndex = index;
        }
    }
}
