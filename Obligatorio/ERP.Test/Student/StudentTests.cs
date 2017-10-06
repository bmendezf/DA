﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ERP.Entities.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Entities.Student.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void NameTest()
        {
            Student student = new Student();
            student.Name = "Juan";

            Assert.Equals(student.Name, "Juan");
        }
    }


}