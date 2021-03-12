
using BankAPI.Models.BankAccounts;
using BankAPI.Models.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAPI.Models.BankAccountServices.Interfaces
{
    public interface IBankAccountService
    {
        void CreateBankAccount(BankAccountRequest bankAccountRequest);
        void Withdraw(float amount, IBankAccount bankAccount);
        void Deposit(float amount, IBankAccount bankAccount);
        bool BalanceToLowForWithdrawl(float amount, IBankAccount bankAccount);
    }
}
