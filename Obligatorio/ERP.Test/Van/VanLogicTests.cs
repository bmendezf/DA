using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.Entities.Van;
using ERP.Data;
using ERP.Logic;

namespace ERP.Test.Van
{
    [TestClass]
    public class VanLogicTests
    {

        Entities.Van.Van van;
        Data.Data aDatabase;
        VanLogic vanLogic;

        [TestInitialize()]
        public void Initialize()
        {
            van = new Entities.Van.Van();
            van.LicensePlate = "abc1234";
            aDatabase = new Data.Data();
            vanLogic = new VanLogic(aDatabase);
        }

        [TestMethod()]
        public void AddVanTrueTest()
        {
            Assert.IsTrue(vanLogic.AddVan(van));
        }

        [TestMethod()]
        public void AddVanFalseTest()
        {
            vanLogic.AddVan(van);

            Assert.IsFalse(vanLogic.AddVan(van)); 
        }

        [TestMethod()]
        public void DeleteVanTest()
        {
            vanLogic.AddVan(van);

            Assert.IsTrue(vanLogic.DeleteVan(van));
        }

        [TestMethod()]
        public void DeleteVanFalseTest()
        {
            Assert.IsFalse(vanLogic.DeleteVan(van));
        }

        [TestMethod()]
        public void GetVanTest()
        {
            vanLogic.AddVan(van);
            Entities.Van.Van recivedVan = vanLogic.GetVan(van);

            Assert.AreEqual(van, recivedVan);
        }

        [TestMethod()]
        public void updateVanTest()
        {
            van.Capacity = 12;
            vanLogic.AddVan(van);
            Entities.Van.Van modifiedVan = new Entities.Van.Van();
            modifiedVan.LicensePlate="abc1234";
            modifiedVan.Capacity = 16;
            vanLogic.UpdateVan(modifiedVan);

            Assert.AreEqual(modifiedVan.Capacity, vanLogic.GetVan(van).Capacity);
        }

        [TestMethod()]
        public void updateVanFalseTest()
        {
            Assert.IsFalse(vanLogic.UpdateVan(van));
        }

        [TestMethod()]
        public void GetAllVansTest()
        {
            vanLogic.AddVan(van);
            int numberOfElements = 1;

            Assert.AreEqual(numberOfElements, vanLogic.GetAllVans().Count);
        }

        [TestMethod()]
        public void getCapacityTest()
        {
            van.Capacity = 15;
            vanLogic.AddVan(van);
            int recivedCapacity = vanLogic.GetVanCapacity(van);

            Assert.AreEqual(15, recivedCapacity);
        }


        [TestMethod()]
        public void getAmountTest()
        {
            ERP.Entities.Van.Van van2 = new ERP.Entities.Van.Van();
            van2.LicensePlate = "aaa1234";
            ERP.Entities.Van.Van van3 = new ERP.Entities.Van.Van();
            van3.LicensePlate = "Bbb1234";

            vanLogic.AddVan(van);
            vanLogic.AddVan(van2);
            vanLogic.AddVan(van3);
            List<Entities.Van.Van> vans = vanLogic.GetAllVans();
            int vansAmount = vanLogic.GetAmountOfVans();

            Assert.AreEqual(3, vansAmount);
        }

    }
}
