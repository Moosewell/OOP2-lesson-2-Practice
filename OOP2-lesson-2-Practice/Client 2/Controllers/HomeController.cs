using BankClient.Models;
using BankClient.Models.dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Client_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly string urlCreateBankAccount = "https://localhost:44316/api/BankAccountService/CreateBankAccount";
        private readonly string urlGetBankAccountList = "https://localhost:44316/api/BankAccountService/GetBankAccountList";
        private readonly string urlWithdraw = "https://localhost:44316/api/BankAccountService/Withdraw";
        private readonly string urlDeposit = "https://localhost:44316/api/BankAccountService/Deposit";
        private readonly string urlCreateCustomer = "https://localhost:44316/api/CustomerService/CreateCustomer";
        private readonly string urlGetCustomerList = "https://localhost:44316/api/CustomerService/GetCustomerList";
        private readonly string urlGetCustomerBankAccounts = "https://localhost:44316/api/GetCustomerBankAccounts";

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
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(urlGetBankAccountList).Result;
                if (response != null)
                {
                    var jsonString = response.Content.ReadAsStringAsync().Result;
                    var bankAccounts = JsonConvert.DeserializeObject<List<BankAccount>>(jsonString);
                    ViewBag.Message = "List of customers recieved \n";
                    string listAsText = "";
                    foreach (BankAccount account in bankAccounts)
                    {
                        string accountAsText = JsonConvert.SerializeObject(account, Formatting.Indented);
                        listAsText += accountAsText + "\n";
                    }
                    ViewBag.Content = listAsText;
                }
            }
            return View("Results");
        }

        public ActionResult Withdraw()
        {
            return View("Results");
        }

        public ActionResult Deposit(int accountId, float amount)
        {
            using (HttpClient client = new HttpClient())
            {
                TransactionRequest transactionRequest = new TransactionRequest(accountId, amount);
                var transactionRequestString = JsonConvert.SerializeObject(transactionRequest);
                //var stringContent = new StringContent(transactionRequestString, UnicodeEncoding.UTF8, "application/json");
                client.PostAsync(urlDeposit, transactionRequest, new JsonMediaTypeFormatter());
                
            }
            ViewBag.Message = "Deposit has been made";
            return View("Results");
        }
        public ActionResult CreateCustomer()
        {
            return View("Results");
        }
        public ActionResult GetCustomerList()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(urlGetCustomerList).Result;
                if (response != null)
                {
                    var jsonString = response.Content.ReadAsStringAsync().Result;
                    var customers = JsonConvert.DeserializeObject<List<Customer>>(jsonString);
                    ViewBag.Message = "List of customers recieved \n";
                    string listAsText = "";
                    foreach (Customer customer in customers)
                    {
                        string customerAsText = JsonConvert.SerializeObject(customer, Formatting.Indented);
                        listAsText += customerAsText + "\n";
                    }
                    ViewBag.Content = listAsText;
                }
            }
            return View("Results");
        }
        public ActionResult GetCustomerBankAccounts()
        {
            return View("Results");
        }
    }
}