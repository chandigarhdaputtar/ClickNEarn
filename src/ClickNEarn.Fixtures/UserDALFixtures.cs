using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Threading.Tasks;
using Constants;
using Helpers;
using Models;
using MongoDB.Bson;
using NUnit.Framework;
using UserProvider;

namespace ClickNEarn.Fixtures
{
    [TestFixture]
    public class UserDALFixtures
    {
        [Test]
        public void checkIfUserIsAddedToDb()
        {
            UserDAL client = new UserDAL();
            string password = "test123!@#";
            var securePassword = password.ToSecureString();
            User user = new User()
            {
                AccountInfo = new Account()
                {
                    Username = "TestAccount",
                    AcceptedTermsOfService = true,
                    EmailId = "test@test.com",
                    IsEmailVerified = true,
                    IsPhoneNumberVerified = true,
                    PhoneNumber = "7009600251",
                    Password = securePassword
                },
                PersonalInfo = new Personal()
                {
                    Name = new Name()
                    {
                        FirstName = "testFirst",
                        LastName = "testLast",
                        MiddleName = "testMiddle",
                        title = ModelConstants.Title.Mr
                    },
                    Age = 20,
                    EmailId = "test@test.com"
                },
                FraudInfo = new Fraud()
                {
                    Host = "Shaantam",
                    IsActive = true,
                    IsBanned = false,
                    PreviousLogins = new List<DateTime>(),
                    IpAddress = GetLocalIPAddress()
                },
                AgeGroup = ModelConstants.AgeGroup.Adult,
                Money = new Money()
                {
                    CurrentBalance = 5.25,
                    TotalEarned = 15.75,
                    TotalPayoutAmount = 10.50
                },
                TotalPayouts = 2,
                _id = ObjectId.GenerateNewId()
            };
            user.FraudInfo.PreviousLogins.Add(DateTime.Now);
            var addedSuccessfully = client.AddUser(user);
            Assert.IsTrue(addedSuccessfully);
        }

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
