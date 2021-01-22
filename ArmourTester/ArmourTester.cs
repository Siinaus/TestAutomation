using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing2018;

namespace ArmourTester
{
    [TestClass]
    public class ArmourTester
    {
        [TestMethod]
        public void TestGetLevel()
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
        public void TestTakeDam()
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
        public void TestGetCondition()
        {
            // Arrange
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);

            // Act
            string condition = ar.getCondition();

            // Assert

            Assert.IsNotNull(condition);
    
        }
    }
}
