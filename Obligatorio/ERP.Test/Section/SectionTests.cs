using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.Entities.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Module.Tests
{
    [TestClass()]
    public class SectionTests
    {
        [TestMethod()]
        public void nameNotNullTest()
        {
            Section aSection = new Section();

            Assert.IsNotNull(aSection.Name);
        }

        [TestMethod()]
        public void descriptionNotNullTest()
        {
            Section aSection = new Section();

            Assert.IsNotNull(aSection.Description);
        }

        [TestMethod()]
        public void actionsNotNullTest()
        {
            Section aSection = new Section();

            Assert.IsNotNull(aSection.Actions);
        }
    }
}