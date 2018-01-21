using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Data.Contracts
{
    interface IAuth
    {
        string HashPassword(string Password);
        bool ValidatePassword(string Password, string hashedPassword);
    }
}
