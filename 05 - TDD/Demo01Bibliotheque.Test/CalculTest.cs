using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01Bibliotheque.Test
{
    [TestClass]
    public class CalculTest
    {
        [TestMethod]
        public void WhenAddition_10_30_Then_40()
        {
            // Arrange
            var calcul = new Calcul();

            // Act
            double result = calcul.Addition(10, 30);

            // Assert
            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void WhenDivision_30_10_Then_3()
        {
            // Arrange 
            var calcul = new Calcul();

            // Act
            double result = calcul.Division(30, 10);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void WhenDivision_30_0_Then_DivideByZeroException()
        {
            // Arrange
            var calcul = new Calcul();
            //var funcToExecute = () => calcul.Division(30, 0);

            // Act et Assert
            Assert.ThrowsException<DivideByZeroException>(() => calcul.Division(30, 0));
        }
    }
}
