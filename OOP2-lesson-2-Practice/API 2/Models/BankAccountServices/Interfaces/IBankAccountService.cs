
using BankAPI.Models.BankAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Models.BankAccountServices.Interfaces
{
    public interface IBankAccountService
    {
        void Withdraw(float amount, IBankAccount bankAccount);
        void Deposit(float amount, IBankAccount bankAccount);
        bool BalanceToLowForWithdrawl(float amount, IBankAccount bankAccount);
    }
}
