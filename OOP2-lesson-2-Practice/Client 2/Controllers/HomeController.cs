using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly string urlCreateBankAccount = "https://localhost:44316/BankAccountService/CreateBankAccount";
        private readonly string urlGetBankAccountList = "https://localhost:44316/BankAccountService/GetBankAccountList";
        private readonly string urlWithdraw = "https://localhost:44316/BankAccountService/Withdraw";
        private readonly string urlDeposit = "https://localhost:44316/BankAccountService/Deposit";
        private readonly string urlCreateCustomer = "https://localhost:44316/CustomerService/CreateCustomer";
        private readonly string urlGetCustomerList = "https://localhost:44316/CustomerService/GetCustomerList";
        private readonly string urlGetCustomerBankAccounts = "https://localhost:44316/GetCustomerBankAccounts";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CreateBankAccount()
        {
            return View("Results");
        }

        public ActionResult GetBankAccountList()
        {
            return View("Results");
        }

        public ActionResult Withdraw()
        {
            return View("Results");
        }

        public ActionResult Deposit()
        {
            return View("Results");
        }
        public ActionResult CreateCustomer()
        {
            return View("Results");
        }
        public ActionResult GetCustomerList()
        {
            return View("Results");
        }
        public ActionResult GetCustomerBankAccounts()
        {
            return View("Results");
        }
    }
}