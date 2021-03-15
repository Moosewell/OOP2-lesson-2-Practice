using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClient.Models.dto
{
    public interface ITransactionRequest
    {
        int accountId { get; set; }
        float amount { get; set; }
    }
}
