using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClient.Models.dto
{
    public interface ICustomerRequest
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string SocialSequrityNumber { get; set; }
    }
}
