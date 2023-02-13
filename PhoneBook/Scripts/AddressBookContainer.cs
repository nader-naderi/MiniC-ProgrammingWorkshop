using System.Collections;
using System.Xml.Serialization;

namespace PhoneBook
{
    public class AddressBookContainer : SerializableData
    {
        [XmlIgnore]
        public ArrayList Items = new ArrayList();

        public Address AddAddress()
        {
            Address newAddress = new Address();
            Items.Add(newAddress);
            return newAddress;
        }

        public Address[] Addresses
        {
            get
            {
                Address[] addresses = new Address[Items.Count];
                Items.CopyTo(addresses);
                return addresses;
            }
            set
            {
                Items.Clear();
                if (value != null)
                {
                    foreach (Address address in value)
                    {
                        Items.Add(address);
                    }
                }
            }
        }

    }
}
