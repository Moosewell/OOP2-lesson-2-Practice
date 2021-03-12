using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankAPI.Models.BankAccountServices.Interfaces;

namespace BankAPI.Controllers
{
    public class BankAccountServiceController : ApiController
    {
        private readonly IBankAccountService bankAccountService;

        public BankAccountServiceController(IBankAccountService bankAccountService)
        {
            this.bankAccountService = bankAccountService;
        }


    }
}
