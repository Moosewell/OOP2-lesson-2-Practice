using BankAPI.Models.BankAccounts;
using BankAPI.Models.Customers;
using BankAPI.Models.Customers.Interfaces;
using BankAPI.Models.CustomerServices.Interfaces;
using BankAPI.Models.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAPI.Models.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        public CustomerService()
        {
            ListOfCustomers.Add(new Customer("Max", "Melander", "0001277335", ListOfCustomers));
            ListOfCustomers.Add(new Customer("Mira", "Melander", "9505243734", ListOfCustomers));
            ListOfCustomers.Add(new Customer("Sara", "Melander", "9704135635", ListOfCustomers));
            ListOfCustomers.Add(new Customer("Carina", "Melander", "6704171255", ListOfCustomers));
            ListOfCustomers.Add(new Customer("Jan", "Melander", "6901119451", ListOfCustomers));
        }
        public void CreateCustomer(ICustomerRequest customerRequest)
        {
            Customer newCustomer = new Customer(customerRequest, ListOfCustomers);
        }
        public List<ICustomer> GetCustomerList()
        {
            return ListOfCustomers;
        }
        public List<IBankAccount> GetCustomerBankAccounts(int customerID, List<IBankAccount> listOfBankAccounts)
        {
            return listOfBankAccounts.Where(o => o.CustomerId == customerID).ToList();
        }

        List<ICustomer> ListOfCustomers = new List<ICustomer>();
    }
}