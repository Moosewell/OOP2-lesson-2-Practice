using BankAPI.Models.BankAccounts;
using BankAPI.Models.BankAccountServices.Interfaces;
using BankAPI.Models.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAPI.Models.BankAccountServices
{
    public class BankAccountService : IBankAccountService
    {
        public BankAccountService()
        {
            ListOfBankAccounts.Add(new BankAccount(1, "Betalningskonto", ListOfBankAccounts));
            ListOfBankAccounts.Add(new BankAccount(2, "Betalningskonto", ListOfBankAccounts));
            ListOfBankAccounts.Add(new BankAccount(3, "Betalningskonto", ListOfBankAccounts));
            ListOfBankAccounts.Add(new BankAccount(4, "Sparkonto", ListOfBankAccounts));
            ListOfBankAccounts.Add(new BankAccount(4, "Betalningskonto", ListOfBankAccounts));
            ListOfBankAccounts.Add(new BankAccount(5, "Betalningskonto", ListOfBankAccounts));
            ListOfBankAccounts.Add(new BankAccount(5, "SparKonto", ListOfBankAccounts));
        }

        public void CreateBankAccount(BankAccountRequest bankAccountRequest)
        {
            ListOfBankAccounts.Add(new BankAccount(bankAccountRequest, ListOfBankAccounts));
        }
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

        List<IBankAccount> ListOfBankAccounts = new List<IBankAccount>();
    }
}