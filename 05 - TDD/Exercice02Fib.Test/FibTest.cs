using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02Fib.Test
{
    [TestClass]
    internal class FibTest
    {
        private Fib _fib;

        private void Setup(int r)
        {
            _fib = new Fib(r);
        }
        [TestMethod]
        public void WhenGetFibSeries_Range1_ThenResultIsNotEmpty()
        {
        // Arrange
            Setup(1);

        // Act
            List<int> results = _fib.GetFibSeries();

            // Assert
            //Assert.IsNotNull(results);
            Assert.AreNotEqual(0, results.Count);
        }

        [TestMethod]
        public void WhenGetFibSeries_IfRange1_ThenResultContains0()
        {
            Setup(1);
            List<int> results = _fib.GetFibSeries();

            CollectionAssert.Contains(results, 0);

            
        }

    }
}
