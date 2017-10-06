using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.Entities.Van;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Van.Tests
{
    [TestClass()]
    public class VanTests
    {

        Van van;

        [TestInitialize()]
        public void initialize()
        {
            van = new Van();
        }

        [TestMethod()]
        public void AvailabilityTest()
        {
            van.Availability = true;

            Assert.AreEqual(van.Availability, true);
        }
    }
}