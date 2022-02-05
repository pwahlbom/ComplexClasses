using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClasses
{
        public class Address {
            public string City { get; set; }
            public string Street { get; set; }
            public int Zip { get; set; }

        public Address(string city, string street, int zip) {
            City = city;
            Street = street;
            Zip = zip;
        }
    }

    class Customer
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Billing Address
        public Address BillingAddress { get; set; }
        //public string BillingAddressStreet { get; set; }
        //public string BillingAddreessCity { get; set; }
        //public string BillingAddressZIP { get; set; }

        // Shipping Address
        public Address ShippingAddress { get; set; }
        //public string ShippingAddressStreet { get; set; }
        //public string ShippingAddressCity { get; set; }
        //public string ShippingAddressZIP { get; set; }

        public Customer(string firstName, string lastName, int age, string bCity, string bStreet, int bZip, string sCity, string sStreet, int sZip) {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            BillingAddress = new Address(bCity, bStreet, bZip);
            ShippingAddress = new ComplexClasses.Address(sCity, sStreet, sZip);
        }
        
    }
        class Program
    {
        static void Main(string[] args)
        {
            //method 1: var cust = new Customer("Andrew", "Buttram", 21);
            //method 2: cust.BillingAddress = new Customer.Address ("Santa Maria", "Carolyne Way", 12345);
            //method 2: cust.ShippingAddress = new Address("Santa Philipe", "Carolyne Way", 12345);
            var cust = new Customer("Phil", "Wahlbom", 48, "Ball Ground", "Hightower Lake Trail", 12345, "Canton", "Riverstone Pkwy", 12345);

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(cust.LastName);
            sb.AppendFormat(cust.BillingAddress.City);
            sb.AppendFormat(cust.ShippingAddress.City);
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
