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
    public class MammalTests
    {
        Mammal mammal1 = new Mammal();

        [TestMethod()]
        public void MammalTest()
        {
            Assert.IsTrue(mammal1.GivesLiveBirth);
            Assert.AreEqual(mammal1.NumChildren, 0);
        }

        [TestMethod()]
        public void GiveBirthTest()
        {
            mammal1.HasOffspring = false;
            Assert.IsFalse(mammal1.HasOffspring);
            mammal1.GiveBirth();
            Assert.IsTrue(mammal1.HasOffspring);
            Assert.AreEqual(mammal1.NumChildren, 1);
        }

        [TestMethod()]
        public void GiveBirthTest1()
        {
            int numBabies = 1;
            mammal1.HasOffspring = false;
            Assert.IsFalse(mammal1.HasOffspring);
            Assert.IsNotNull(numBabies);
            mammal1.GiveBirth();
            Assert.IsTrue(mammal1.HasOffspring);
            Assert.AreEqual(mammal1.NumChildren, numBabies);
        }
    }
}