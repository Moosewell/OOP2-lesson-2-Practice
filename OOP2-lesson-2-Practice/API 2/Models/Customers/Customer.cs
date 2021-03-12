using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankAPI.Models.Customers.Interfaces;
using BankAPI.Models.CustomerServices;
using BankAPI.Models.dto;

namespace BankAPI.Models.Customers
{
    public class Customer : ICustomer
    {
        public Customer(string firstName, string lastName, string socialSecurityNumber, List<ICustomer> customerList)
        {
            this.id = AutoIncrementID(customerList);
            this.firstName = firstName;
            this.lastName = lastName;
            this.socialSecurityNumber = socialSecurityNumber;
        }
        public Customer(CustomerRequest customerRequest, List<ICustomer> customerList)
        {
            this.id = AutoIncrementID(customerList);
            this.firstName = customerRequest.FirstName;
            this.lastName = customerRequest.LastName;
            this.socialSecurityNumber = customerRequest.SocialSequrityNumber;
        }

        private int id { get; set; }
        public int Id => id;

        private string firstName { get; set; }
        public string FirstName => firstName;

        private string lastName { get; set; }
        public string LastName => lastName;

        private string socialSecurityNumber { get; set; }
        public string SocialSecurityNumber => socialSecurityNumber;

        private int AutoIncrementID(List<ICustomer> customerList)
        {
            int ID = 1;
            for(var i = 0; i < customerList.Count - 1; i++)
            {
                if (customerList[i].Id == ID)
                {
                    ID++;
                    i = 0;
                }
            }
            return ID;
        }
    }
}