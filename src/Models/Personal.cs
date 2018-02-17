using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Constants.ModelConstants;

namespace Models
{
    public class Personal
    {
        public Name Name { get; set; }
        public string EmailId { get; set; }
        public int Age { get; set; }
        public Gender gender { get; set; }
        public DateTime JoinDate { get; set; }
        public string PhoneNumber { get; set; } //might be null in case of supplier
    }
}
