using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Tests
{
    [TestClass()]
    public class HumanTests
    {
        Human human2 = new Human();

        [TestMethod()]
        public void HumanTest()
        {
            Assert.AreEqual(2, human2.NumLegs);
            Assert.IsFalse(human2.HasFur);
            Assert.AreEqual(human2.Species, "Homosapien");
            Assert.IsFalse(human2.HasTail);
            Assert.IsTrue(human2.HasOpposableThumb);
            Assert.AreEqual(human2.MaritalStatus, 'S');
        }

        [TestMethod()]
        public void GetMarriedTest()
        {
            Assert.AreEqual(human2.MaritalStatus, 'S');
            human2.GetMarried();
            Assert.AreEqual(human2.MaritalStatus, 'M');
        }

        [TestMethod()]
        public void GetMarriedTest1()
        {

            Assert.IsNull(human2.FirstName);
            Assert.IsNull(human2.LastName);

            human2.FirstName = "Chris";
            human2.LastName = "Newby";
            human2.GetMarried();

            Assert.AreEqual(human2.FirstName, "Chris");
            Assert.AreEqual(human2.LastName, "Newby");
            Assert.AreEqual(human2.MaritalStatus, 'M');

            Assert.IsNotNull(human2.FirstName);
            Assert.IsNotNull(human2.LastName);
        }

        [TestMethod()]
        public void GetSingleTest()
        {
            human2.GetMarried();
            Assert.AreEqual(human2.MaritalStatus, 'M');
            human2.GetSingle();
            Assert.AreEqual(human2.MaritalStatus, 'S');
        }

        [TestMethod()]
        public void GetSingleTest1()
        {
            Assert.IsNull(human2.FirstName);
            Assert.IsNull(human2.LastName);

            human2.FirstName = "Chris";
            human2.LastName = "Newby";

            human2.GetMarried();

            Assert.AreEqual(human2.FirstName, "Chris");
            Assert.AreEqual(human2.LastName, "Newby");
            Assert.AreEqual(human2.MaritalStatus, 'M');

            human2.GetSingle();

            Assert.AreEqual(human2.FirstName, "Chris");
            Assert.AreEqual(human2.LastName, "Newby");
            Assert.AreEqual(human2.MaritalStatus, 'S');

            Assert.IsNotNull(human2.FirstName);
            Assert.IsNotNull(human2.LastName);
        }
    }
}