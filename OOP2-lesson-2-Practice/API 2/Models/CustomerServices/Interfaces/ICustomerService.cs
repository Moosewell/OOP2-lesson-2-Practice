using BankAPI.Models.BankAccounts;
using BankAPI.Models.Customers.Interfaces;
using BankAPI.Models.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAPI.Models.CustomerServices.Interfaces
{
    public interface ICustomerService
    {
        void CreateCustomer(CustomerRequest customerRequest);
        List<ICustomer> GetCustomerList();
        List<IBankAccount> GetCustomerBankAccounts(ICustomer customer, List<IBankAccount> listOfBankAccounts);
    }
}
