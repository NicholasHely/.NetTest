using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{

   

    class Customer
    {
        private const int UNASSIGNED = -1;

        public int Id { get; private set; }
        public string Name { get; set; }

        public Contacts Contacts { get; private set; }

        public Customer(int id = UNASSIGNED, string name = null)
        {
            Name = name;
            Id = id;
            Contacts = new Contacts(this);

        }

        public void SearchContacts(string name)
        {
            IEnumerable<Contact> contacts = Contacts.SeachContacts(name);
           
            foreach(Contact contact in contacts)
            {
                Console.WriteLine("Contact: {0}", contact.Name);
            }

            Contact contactT = Contacts[0];
        }
    }
}
