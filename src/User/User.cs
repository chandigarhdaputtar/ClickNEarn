using Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class User
    {
        public Personal.PersonalInfo PersonalInfo { get; set; }
        public string PhoneNumber { get; set; }
        public double CurrentAmount { get; set; }
        public double TotalEarned { get; set; }
        public int TotalPayouts { get; set; }
        public Account.AccountInfo AccountInfo { get; set; }
        public Fraud.FraudInfo FraudInfo { get; set; }
    }
}
