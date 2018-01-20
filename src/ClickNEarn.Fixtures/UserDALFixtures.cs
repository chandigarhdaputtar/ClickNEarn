using System;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Threading.Tasks;
using Helpers;
using Models;
using NUnit.Framework;
using UserProvider;

namespace ClickNEarn.Fixtures
{
    [TestFixture]
    public class UserDALFixtures
    {
        //[Test]
        //public void checkIfUserIsAddedToDb()
        //{
        //    UserDAL client = new UserDAL();
        //    string password = "test123!@#";
        //    var securePassword = password.ToSecureString();
        //    User user = new User()
        //    {
        //        AccountInfo = new Account()
        //        {
        //            Username = "TestAccount",

        //            Password = securePassword
        //        },
        //        PersonalInfo = new Personal()
        //        {
        //            Name = "Test",
        //            Age = 20,
        //            EmailId = "test@test.com"
        //        },
        //        FraudInfo = new Fraud()
        //        {
        //            Host = "Shaantam",
        //            IpAddress = GetLocalIPAddress()
        //        },
        //        CurrentAmount = 50,
        //        TotalAmount = 100,
        //        TotalPayouts = 5,
        //        IsActive = true,
        //        IsBanned = false
        //    };
        //    var addedSuccessfully = client.AddUser(user);
        //    Assert.IsTrue(addedSuccessfully);
        //}

        [Test]
        public void checkIfDataIsRetrieveFromDb()
        {
            UserDAL client = new UserDAL();
            var username = "TestAccount";
            User user = client.GetUser(username);
            Assert.IsNotNull(user);
        }


        public static IPAddress GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
