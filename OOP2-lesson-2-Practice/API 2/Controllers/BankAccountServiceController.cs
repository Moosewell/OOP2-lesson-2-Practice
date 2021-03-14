using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankAPI.Models.BankAccountServices.Interfaces;
using BankAPI.Models.BankAccountServices;
using BankAPI.Models.dto;
using BankAPI.Models.BankAccounts;

namespace BankAPI.Controllers
{
    public class BankAccountServiceController : ApiController
    {
        private readonly IBankAccountService bankAccountService;

        public BankAccountServiceController(IBankAccountService bankAccountService)
        {
            this.bankAccountService = bankAccountService;
        }

        [HttpGet]
        [Route("api/BankAccountService/CreateBankAccount")]
        public IHttpActionResult CreateBankAccount(IBankAccountRequest bankAccountRequest)
        {
            bankAccountService.CreateBankAccount(bankAccountRequest);
            return Ok();
        }

        [HttpGet]
        [Route("api/BankAccountService/GetBankAccountList")]
        public IHttpActionResult GetBankAccountList()
        {
            return Ok(bankAccountService.GetBankAccountList());
        }

        [HttpGet]
        [Route("api/BankAccountService/Withdraw")]
        public IHttpActionResult Withdraw(float amount, BankAccount bankAccount)
        {
            bankAccountService.Withdraw(amount, bankAccount);
            return Ok();
        }

        [HttpGet]
        [Route("api/BankAccountService/Deposit")]
        public IHttpActionResult Deposit(float amount, BankAccount bankAccount)
        {
            bankAccountService.Deposit(amount, bankAccount);
            return Ok();
        }



    }
}
