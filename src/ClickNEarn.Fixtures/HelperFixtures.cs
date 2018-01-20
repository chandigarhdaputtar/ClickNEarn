using Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ClickNEarn.Fixtures
{
    [TestFixture]
    public class HelperFixtures
    {
        [Test]
        public void CheckIfStringIsConvertedToSecureString()
        {
            var s = "testString";
            var x= s.ToSecureString();
            int len = x.Length;
            Assert.AreEqual(10, len);
            //var y = x.ToNormalString();
        }
        [Test]
        public void CheckIfSecureStringIsConvertedToString()
        {
            var s = "testString";
            var x = s.ToSecureString();
            x.ToNormalString();
            Assert.AreEqual(s.Length, x.Length);
        }
    }
}
