using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankAPI.Models.Customers.Interfaces;
using BankAPI.Models.dto;

namespace BankAPI.Models.BankAccounts
{
    public class BankAccount : IBankAccount
    {
        public BankAccount(int customerId, string accountName, List<IBankAccount> bankAccountList)
        {
            this.accountId = AutoIncrementId(bankAccountList);
            this.customerId = customerId;
            this.accountName = accountName;
            this.balance = 0;
        }
        public BankAccount(BankAccountRequest bankAccountRequest, List<IBankAccount> bankAccountList)
        {
            this.accountId = AutoIncrementId(bankAccountList);
            this.customerId = bankAccountRequest.CustomerId;
            this.accountName = bankAccountRequest.AccountName;
            this.balance = 0;
        }

        private int accountId { get; set; }
        public int AccountId => accountId;

        private int customerId { get; set; }
        public int CustomerId => customerId;

        private string accountName { get; set; }
        public string AccountName => accountName;

        private float balance { get; set; }
        public float Balance => balance;

        public void RemoveBalance(float amount)
        {
            balance -= amount;
        }
        public void AddBalance(float amount)
        {
            balance += amount;
        }

        private int AutoIncrementId(List<IBankAccount> bankAccountList)
        {
            int ID = 1;
            for (var i = 0; i < bankAccountList.Count - 1; i++)
            {
                if (bankAccountList[i].AccountId == ID)
                {
                    ID++;
                    i = 0;
                }
            }
            return ID;
        }
    }
}