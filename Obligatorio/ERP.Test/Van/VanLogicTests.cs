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
        Entities.Van.Van van2;
        Entities.Van.Van van3;

        [TestInitialize()]
        public void Initialize()
        {
            van = new Entities.Van.Van();
            van2 = new Entities.Van.Van();
            van3 = new Entities.Van.Van();
        }

        [TestMethod()]
        public void AddVanTest()
        {
            Logic.VanLogic.addVan(van);
            Entities.Van.Van recivedVan = ERP.Logic.VanLogic.getVan(van);

            Assert.AreEqual(van, recivedVan);
        }

        [TestMethod()]
        public void AddVanRepeatedTest()
        {
            Logic.VanLogic.addVan(van);
            Logic.VanLogic.addVan(van);

            List<Entities.Van.Van> vans = ERP.Logic.VanLogic.getAllVans();

            Assert.AreEqual(vans.Count, 1);
        }

        [TestMethod()]
        public void DeleteVanTest()
        {
            Logic.VanLogic.addVan(van);
            Logic.VanLogic.deleteVan(van);

            List<Entities.Van.Van> vans = ERP.Logic.VanLogic.getAllVans();

            Assert.AreEqual(vans.Count, 0);
        }

        [TestMethod()]
        public void updateVanTest()
        {
            van.Capacity = 10;
            Logic.VanLogic.addVan(van);
            van2.Capacity = 15;
            Logic.VanLogic.updateVan(van2);
            Entities.Van.Van updatedVan = Logic.VanLogic.getVan(van);

            Assert.AreEqual(updatedVan.Capacity, van2.Capacity);
        }

        [TestMethod()]
        public void getCapacityTest()
        {
            van.Capacity = 14;
            int recivedCapacity = Logic.VanLogic.getCapacity(van);

            Assert.AreEqual(14, recivedCapacity);
        }


        [TestMethod()]
        public void getAmountTest()
        {
            van2.LicensePlate = "a";
            van2.LicensePlate = "b";
            Logic.VanLogic.addVan(van);
            Logic.VanLogic.addVan(van2);
            Logic.VanLogic.addVan(van3);
            int vansAmount = Logic.VanLogic.getAmount();

            Assert.AreEqual(3, vansAmount);
        }

    }
}
