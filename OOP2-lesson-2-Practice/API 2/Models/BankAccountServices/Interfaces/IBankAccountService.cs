
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
        void CreateBankAccount(IBankAccountRequest bankAccountRequest);
        List<IBankAccount> GetBankAccountList();
        void Withdraw(float amount, int accountId);
        void Deposit(float amount, int accountId);
        bool BalanceToLowForWithdrawl(float amount, IBankAccount bankAccount);
    }
}
