using BankAPI.Models.BankAccounts;
using BankAPI.Models.BankAccountServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAPI.Models.BankAccountServices
{
    public class BankAccountService : IBankAccountService
    {
        public void Withdraw(float amount, IBankAccount bankAccount)
        {
            if (BalanceToLowForWithdrawl(amount, bankAccount))
                return;

            bankAccount.RemoveBalance(amount);
        }

        public void Deposit(float amount, IBankAccount bankAccount)
        {
            bankAccount.AddBalance(amount);
        }

        public bool BalanceToLowForWithdrawl(float amount, IBankAccount bankAccount)
        {
            return bankAccount.Balance - amount < 0;
        }
    }
}