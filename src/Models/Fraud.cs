using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Fraud
    {
        public IPAddress IpAddress { get; set; }
        public string Host { get; set; }
        public List<DateTime> PreviousLogins { get; set; }
        public bool IsActive { get; set; }
        public bool IsBanned { get; set; }
    }
}
