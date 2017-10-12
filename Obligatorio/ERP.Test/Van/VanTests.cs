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
        public void CapacityTest()
        {
            van.Capacity = 12;

            Assert.AreEqual(van.Capacity, 12);
        }

        [TestMethod()]
        public void CapacityNotNullTest()
        {
            Assert.IsNotNull(van.Capacity);
        }

        [TestMethod()]
        public void LicensePlateTest()
        {
            van.LicensePlate = "abc1234";

            Assert.AreEqual(van.LicensePlate, "abc1234");
        }

        [TestMethod()]
        public void LicensePlateNotNullTest()
        {
            Assert.IsNotNull(van.LicensePlate);
        }

    }
}