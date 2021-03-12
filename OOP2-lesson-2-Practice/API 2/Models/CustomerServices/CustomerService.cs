using BankAPI.Models.BankAccounts;
using BankAPI.Models.Customers.Interfaces;
using BankAPI.Models.CustomerServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAPI.Models.CustomerServices
{
    public class CustomerService : ICustomerService
    {
        public List<ICustomer> GetCustomerList()
        {
            throw new NotImplementedException();
        }
        public List<IBankAccount> GetCustomerBankAccounts(ICustomer customer)
        {
            throw new NotImplementedException();
        }
    }
}