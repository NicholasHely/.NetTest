using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Contact
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public Customer Customer { get; private set; }
        
        private Contact(int id, String name, Customer customer)
        {
            Id = id;
            Name = name;
            Customer = customer;
        }
    }
}
