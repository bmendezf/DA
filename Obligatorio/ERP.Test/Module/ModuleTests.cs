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
    public class ModuleTests
    {
        [TestMethod()]
        public void nameNotNullTest()
        {
            Module aModule = new Module();

            Assert.IsNotNull(aModule.Name);
        }

        [TestMethod()]
        public void descriptionNotNullTest()
        {
            Module aModule = new Module();

            Assert.IsNotNull(aModule.Description);
        }
        [TestMethod()]
        public void actionsNotNullTest()
            Module aModule = new Module();

            Assert.IsNotNull(aModule.Actions);
        }

    }
}