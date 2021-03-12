using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankAPI.Models.Customers.Interfaces;

namespace BankAPI.Models.BankAccounts
{
    public class BankAccount : IBankAccount
    {
        public BankAccount(ICustomer customer, string accountName)
        {
            //Set accountid automaticly
            this.customerId = customer.Id;
            this.accountName = accountName;
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
    }
}