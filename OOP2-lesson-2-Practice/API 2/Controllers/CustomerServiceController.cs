using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BankAPI.Models.CustomerServices.Interfaces;

namespace BankAPI.Controllers
{
    public class CusomerServiceController : ApiController
    {
        private readonly ICustomerService customerService;

        public CusomerServiceController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }


    }
}
