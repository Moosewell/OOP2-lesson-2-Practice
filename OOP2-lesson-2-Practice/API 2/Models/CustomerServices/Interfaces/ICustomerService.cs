using BankAPI.Models.BankAccounts;
using BankAPI.Models.Customers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAPI.Models.CustomerServices.Interfaces
{
    public interface ICustomerService
    {
        List<ICustomer> GetCustomerList();
        List<IBankAccount> GetCustomerBankAccounts(ICustomer customer);
    }
}
