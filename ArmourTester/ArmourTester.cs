using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing2018;

namespace ArmourTester
{
    [TestClass]
    public class ArmourTester
    {
        [TestMethod]
        public void TestGetLevel_Fail()
        {
            // Arrange
            // name, desc, prot, slot, level
            // maxProt on prot (lähtötaso) ja currentProt on prot josta on vähennetty damage tai jota on korjattu
            Armour ar = new Armour("Hanska", "Kehno", 20, 2, 2);

            // Act
            int lvl = ar.getLevel();

            // Assert
            if (lvl !=2)
            {
              Assert.Fail();
            }
        }

        [TestMethod]
        public void TestGetLevel_Ok()
        {
            // Arrange
            Armour ar = new Armour("Hanska", "Kehno", 20, 2, 2);

            // Act
            int lvl = ar.getLevel();

            // Assert
            Assert.AreEqual(2, lvl);
        }

        [TestMethod]
        public void TestGetSlot_Fail()
        {
            // Arrange
            Armour ar = new Armour("Hanska", "Kehno", 20, 2, 2);

            // Act
            int slot = ar.getSlot();

            // Assert
            if (slot != 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestGetSlot_Ok()
        {
            // Arrange
            Armour ar = new Armour("Hanska", "Kehno", 20, 2, 2);

            // Act
            int slot = ar.getSlot();

            // Assert
            Assert.AreEqual(2, slot);
        }

        [TestMethod]
        public void TestGetCondition_Ok()
        {
            // Arrange
            Armour ar = new Armour("Hanska", "Kehno", 20, 2, 2);

            // Act
            string condition = ar.getCondition();

            // Assert

            Assert.IsNotNull(condition);
        }

        [TestMethod]
        public void TestGetCondition_Fail()
        {
            // Arrange
            Armour ar = new Armour("Hanska", "Kehno", 20, 2, 2);

            // Act
            string condition = ar.getCondition();

            // Assert
            if(condition == null)
            Assert.Fail();
        }

        [TestMethod]
        public void TestGetCondition_RightTextMint()
        {
            // Arrange
            Armour ar = new Armour("Hanska", "Kehno", 20, 2, 2);

            // Act
            string condition = ar.getCondition();

            // Assert

            Assert.AreEqual("Mint", condition);
        }

        [TestMethod]
        public void TestTakeDam_StillOk()
        {
            // Arrange
            Armour ar = new Armour("Hanska", "Kehno", 20, 2, 2);

            // Act
            ar.takeDam(5);
            int condition = ar.getCurProt();

            // Assert

            Assert.AreEqual(15, condition);
        }

        [TestMethod]
        public void TestTakeDam_Destroy()
        {
            // Arrange
            Armour ar = new Armour("Hanska", "Kehno", 20, 2, 2);

            // Act
            ar.takeDam(25);
            string condition = ar.getCondition();

            // Assert

            Assert.AreEqual("Destroyed", condition);
        }

        [TestMethod]
        public void TestRepair()
        {
            // Arrange
            Armour ar = new Armour("Hanska", "Kehno", 20, 2, 2);

            // Act
            ar.takeDam(15);
            ar.repair(5);
            int condition = ar.getCurProt();

            // Assert

            Assert.AreEqual(10, condition);
        }

        [TestMethod]
        public void TestRepair_Fail()
        {
            // Arrange
            Armour ar = new Armour("Hanska", "Kehno", 20, 2, 2);

            // Act
            ar.takeDam(15);
            ar.repair(5);
            int condition = ar.getCurProt();

            // Assert
            if(condition != 10)
            {
                Assert.Fail();
            }
        }
    }
}
