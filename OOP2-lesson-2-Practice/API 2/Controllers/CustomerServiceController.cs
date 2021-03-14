using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankAPI.Models.BankAccounts;
using BankAPI.Models.CustomerServices.Interfaces;
using BankAPI.Models.dto;

namespace BankAPI.Controllers
{
    public class CusomerServiceController : ApiController
    {
        private readonly ICustomerService customerService;

        public CusomerServiceController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        [Route("api/CustomerService/CreateBankAccount")]
        public IHttpActionResult CreateBankAccount(ICustomerRequest customerRequest)
        {
            customerService.CreateCustomer(customerRequest);
            return Ok();
        }

        [HttpGet]
        [Route("api/CustomerService/GetCustomerList")]
        public IHttpActionResult GetCustomerList()
        {
            return Ok(customerService.GetCustomerList());
        }

        [HttpGet]
        [Route("api/CustomerService/GetCustomerBankAccounts")]
        public IHttpActionResult GetCustomerBankAccounts(int ID, List<IBankAccount> bankAccountList)
        {
            return Ok(customerService.GetCustomerBankAccounts(ID, bankAccountList));
        }

    }
}
