using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BankApp;

namespace BankATMapp.Services
{

    public class AuthService
    {
        public bool VerifyCustomer(int accountNum, int pinNum)
        {
            using (var ctx = new BankATMAppEntities())
            {
                var query =
                from a in ctx.Accounts
                where a.AccountNumber == accountNum
                select a;

                var account = query.Single();

                return pinNum == account.PIN;
            }
        }
    }

}
