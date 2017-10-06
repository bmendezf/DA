﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod()]
        public void AvailabilityNotNullTest()
        {
            Assert.IsNotNull(van.Availability);
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

    }
}