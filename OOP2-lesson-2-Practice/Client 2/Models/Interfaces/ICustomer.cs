﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClient.Models.Interfaces
{
    public interface ICustomer
    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
        string SocialSecurityNumber { get; }
    }
}