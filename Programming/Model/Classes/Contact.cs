using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class Contact
    {
        private string _phoneNumber;
        private string _name;
        private string _surname;
        private string _email;
        public string PhoneNumber { get;set; }
        public string Name { get;set; }
        public string Email { get; set; }

        public Contact(string phoneNumber, string name, string email)
        { 
            PhoneNumber = phoneNumber;
            Name = name;
            Email = email;
        }
        public Contact() { }
    }
}
