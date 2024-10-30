using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level2
{
    [TestClass]
    public class CalculateTest
    {

        [TestMethod]
        public void compute_sequence()
        {
            // Beräkna summan eller produkten på talen

            Assert.AreEqual(1 + 2 + 3 + 4 + 5, Calculate(5, ComputeMethod.Sum));
            Assert.AreEqual(1 * 2 * 3 * 4 * 5, Calculate(5, ComputeMethod.Product));

            Assert.AreEqual(1 + 2 + 3, Calculate(3, ComputeMethod.Sum));
            Assert.AreEqual(1 * 2 * 3, Calculate(3, ComputeMethod.Product));

            Assert.AreEqual(1, Calculate(1, ComputeMethod.Sum));
            Assert.AreEqual(1, Calculate(1, ComputeMethod.Product));

            Assert.ThrowsException<ArgumentException>(() => Calculate(0, ComputeMethod.Sum));
            Assert.ThrowsException<ArgumentException>(() => Calculate(0, ComputeMethod.Product));
            Assert.ThrowsException<ArgumentException>(() => Calculate(-1, ComputeMethod.Sum));
            Assert.ThrowsException<ArgumentException>(() => Calculate(-1, ComputeMethod.Product));
        }

        public enum ComputeMethod
        {
            Unknown, // representerar framtida enum's. För att få full testcoverage
            Sum, 
            Product
        }

        [TestMethod]
        public void unknown_compute_method_should_give_exception()
        {
            Assert.ThrowsException<NotImplementedException>(() => Calculate(4, ComputeMethod.Unknown));
        }

        public int Calculate(int toNumber, ComputeMethod sum)
        {
            throw new NotImplementedException();
        }

    }
}
