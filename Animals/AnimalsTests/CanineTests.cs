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
    public class CanineTests
    {
        Canine bud = new Canine();

        [TestMethod()]

        public void CanineTest()
        {
            Assert.AreEqual(4, bud.NumLegs);
            Assert.IsTrue(bud.HasFur);
            Assert.AreEqual(bud.Species, "Canis");
            Assert.IsTrue(bud.HasTail);
            Assert.IsFalse(bud.HasOpposableThumb);
        }


        [TestMethod()]
        public void AdoptedTest()
        {
            Assert.IsNull(bud.Owner);
            Human Chris = new Human();
            Chris.FirstName = "Chris";
            bud.Adopted(Chris);
            Assert.IsNotNull(bud.Owner);
            Assert.AreEqual("Chris", bud.Owner.FirstName);

        }

        [TestMethod()]
        public void AdoptedTest1()
        {
            Assert.IsNull(bud.DogName);
            Assert.IsNull(bud.Owner);
            Human Human1 = new Human();
            bud.DogName = "cash";
            Human1.FirstName = "David";
            bud.Adopted(Human1, bud.DogName);
            Assert.IsNotNull(bud.Owner);
            Assert.IsNotNull(bud.DogName);
            Assert.AreEqual("David", bud.Owner.FirstName);
            Assert.AreEqual("cash", bud.DogName);
        }
    }
}
