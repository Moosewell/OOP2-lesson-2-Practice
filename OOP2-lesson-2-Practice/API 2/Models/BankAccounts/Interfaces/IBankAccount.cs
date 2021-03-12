using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Models.BankAccounts
{
    public interface IBankAccount
    {
        int AccountId { get; }
        int CustomerId { get; }
        string AccountName { get; }
        float Balance { get; }

        void RemoveBalance(float amount);
        void AddBalance(float amount);
    }
}
