using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClient.Models.dto
{
    public class TransactionRequest : ITransactionRequest
    {
        public TransactionRequest(int accountId, float amount)
        {
            this.accountId = accountId;
            this.amount = amount;
        }
        public int accountId { get; set; }
        public float amount { get; set; }
    }
}
