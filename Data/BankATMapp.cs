using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    public class BankATMapp
    {
        public int ClientId { get; set; }
        public int ClientPin { get; set; }
        public int AccountId { get; set; }
        public int AccountNum { get; set; }
        public double Balance { get; set; }
        public double Deposit { get; set; }
        public double Withdrawl { get; set; }
        public double DollarAmt { get; set; }
    }
}
