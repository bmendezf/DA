using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ERP.Test.Van
{
    [TestClass]
    public class VanLogicTests
    {

        Entities.Van.Van van;

        [TestInitialize()]
        public void Initialize()
        {
            van = new Entities.Van.Van();
        }

        [TestMethod()]
        public void AddVanTest()
        {
            Logic.VanLogic.addVan(van);
            Entities.Van.Van recivedVan = ERP.Logic.VanLogic.getVan(van);

            Assert.AreEqual(van, recivedVan);
        }

    }
}
