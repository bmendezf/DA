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

        //[TestMethod()]
        //public void DeleteVanTest()
        //{
        //    Logic.VanLogic.addVan(van);
        //    Logic.VanLogic.deleteVan(van);

        //    List<Entities.Van.Van> vans = ERP.Logic.VanLogic.getAllVans();

        //    Assert.AreEqual(vans.Count, 0);
        //}

        //[TestMethod()]
        //public void updateVanTest()
        //{
        //    van.Capacity = 10;
        //    Logic.VanLogic.addVan(van);
        //    van2.Capacity = 15;
        //    Logic.VanLogic.updateVan(van2);
        //    Entities.Van.Van updatedVan = Logic.VanLogic.getVan(van);

        //    Assert.AreEqual(updatedVan.Capacity, van2.Capacity);
        //}

        //[TestMethod()]
        //public void getCapacityTest()
        //{
        //    van.Capacity = 15;
        //    Logic.VanLogic.addVan(van);
        //    int recivedCapacity = Logic.VanLogic.getCapacity(van);

        //    Assert.AreEqual(15, recivedCapacity);
        //}


        //[TestMethod()]
        //public void getAmountTest()
        //{
        //    van2.LicensePlate = "a";
        //    van3.LicensePlate = "b";
        //    Logic.VanLogic.addVan(van);
        //    Logic.VanLogic.addVan(van2);
        //    Logic.VanLogic.addVan(van3);
        //    List<Entities.Van.Van> vans = Logic.VanLogic.getAllVans();
        //    int vansAmount = Logic.VanLogic.getAmount();

        //    Assert.AreEqual(3, vansAmount);
        //}

    }
}
