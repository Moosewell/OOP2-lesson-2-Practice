using BankClient.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClient.Models
{
    public class BankAccount : IBankAccount
    {
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public string AccountName { get; set; }
        public float Balance { get; set; }

    }
}
