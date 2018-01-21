using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Data.Contracts;


namespace BankATMapp.Services
{
    public class ClientService : IBankServices

    {
        public int ClientId { get; set; }
        public int ClientPin { get; set; }
        public int AccountId { get; set; }
        public int AccountNum { get; set; }
        public double Balance { get; set; }
        public double Deposit { get; set; }
        public double Withdrawl { get; set; }
        public double DollarAmt { get; set; }
        public string AccountType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}


