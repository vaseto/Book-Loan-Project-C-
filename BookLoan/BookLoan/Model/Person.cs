using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLoanModelLayer
{
    [Serializable]
    class Person
    {
        private string name;
        private string address;
        private string postalCode;
        private string city;
        private string phone;
        private int id;

        public Person(string name, string address, string postalCode, string city, string phone, int id)
        {
            this.name = name;
            this.address = address;
            this.postalCode = postalCode;
            this.city = city;
            this.phone = phone;
            this.id = id;
        }
        public override string ToString()
        {
            return "Person information: Name is: " + "\"" + name + " \", address is: \"" + address
               + " \", postal code is: \"" + postalCode + " \", city is: \"" + city +" \", phone is: \"" + phone + " \", ID is: \"" + id + " \"";
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string PostalCode
        {
            get
            {
                return postalCode;  
            }
            set
            {
                postalCode = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }

}
