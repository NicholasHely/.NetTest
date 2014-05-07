using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Contacts
    {

        public IList<Contact> ContactsList { get; private set; }
        public Customer Customer { get; set; }

        public Contacts(Customer customer)
        {
            Customer = customer;
            ContactsList = new List<Contact>();
        }

        public Contact this[int index]
        {
            get { return ContactsList[index]; }
            set { ContactsList.Replace(index, value); }
        }

        public void AddContact(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException("Contact cannot be null");
            }

            ContactsList.Add(contact);
        }

        public IEnumerable<Contact> SeachContacts(string name)
        {
            // LINQ here will return an IEnumerable collection of contact
            // actually compiled code 
            // is something like
            // return ContactsList.Where((contact) => contact.Name.StartsWith(name));
            return from contact in ContactsList
                   where contact.Name.StartsWith(name)
                   select contact;
        }


    }
}
