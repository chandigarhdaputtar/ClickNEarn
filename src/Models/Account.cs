using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Account
    {
        public string Username { get; set; }
        public SecureString Password { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool AcceptedTermsOfService { get; set; }
        public bool? IsPhoneNumberVerified { get; set; }  //null for supplier
    }
}
