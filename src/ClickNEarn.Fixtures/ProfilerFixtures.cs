using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Profiler;
using System.Diagnostics;

namespace ClickNEarn.Fixtures
{
    [TestFixture]
    public class ProfilerFixtures
    {
        [Test]
        public void CheckIfMethodNameIsRetrievedProperly()
        {
            var currentMethod = MethodProfile.GetCurrentMethod();
            Assert.AreEqual("CheckIfMethodNameIsRetrievedProperly", currentMethod);
        }
        [Test]
        public void CheckIfMethodIsProfiledProperly()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string MethodName = MethodProfile.GetCurrentMethod();
            string ProjectName = MethodProfile.GetProjectName();
            string FileName = MethodProfile.GetFileName();
            string ClassName = MethodProfile.GetClassName(this);
            sw.Stop();
            MethodProfile.Profile(ProjectName, FileName,MethodName,sw);
        }
        [Test]
        public void GetCurrentClassName()
        {
            string ClassName = MethodProfile.GetClassName(this);
        }
    }
}
