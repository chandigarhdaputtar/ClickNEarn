using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Supplier
    {
        public Personal PersonalInfo { get; set; }
        public Account AccountInfo { get; set; }
        public Fraud FraudInfo { get; set; }
        public double AccountBalance { get; set; }
    }
}
