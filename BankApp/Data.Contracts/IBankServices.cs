using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Data.Contracts
{
    public interface IBankServices
    {
        int ClientId  { get; set; }
        int ClientPin { get; set; }
        int AccountId { get; set; }
        int AccountNum { get; set; }
        string AccountType { get; set; }
        double Balance { get; set; }
        double Deposit { get; set; }
        double Withdrawl { get; set; }
        double DollarAmt { get; set; }
       


    }
}
