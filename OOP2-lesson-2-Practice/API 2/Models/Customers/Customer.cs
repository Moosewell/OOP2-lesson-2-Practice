using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankAPI.Models.Customers.Interfaces;

namespace BankAPI.Models.Customers
{
    public class Customer : ICustomer
    {
        public Customer(string firstName, string lastName, int socialSecurityNumber)
        {
            //automaticly set id
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialSecurityNumber = socialSecurityNumber;
        }

        private int id { get; set; }
        public int Id => id;

        private string firstName { get; set; }
        public string FirstName => firstName;

        private string lastName { get; set; }
        public string LastName => lastName;

        private int socialSecurityNumber { get; set; }
        public int SocialSecurityNumber => socialSecurityNumber;
    }
}