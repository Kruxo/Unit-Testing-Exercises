using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level1
{
    [TestClass]
    public class MultiplyAllByTest
    {

        [TestMethod]
        public void multiply_all_by_a_number()
        {
            //  Multiplicera alla tal i listan med factor 
            var expected = new List<double> { 1200, 314, 5000, 9900 };
            var input = new List<double> { 12, 3.14, 50, 99 };
            CollectionAssert.AreEqual(expected, MultiplyAllBy(100, input));

            Assert.ThrowsException<ArgumentException>(() =>
                MultiplyAllBy(3, null)
            );
        }

        [TestMethod]
        public void multiply_all_by_a_number_linq()
        {
            var expected = new List<double> { 1200, 314, 5000, 9900 };
            var input = new List<double> { 12, 3.14, 50, 99 };
            CollectionAssert.AreEqual(expected, MultiplyAllBy_Linq(100, input));

            Assert.ThrowsException<ArgumentException>(() =>
                MultiplyAllBy_Linq(3, null)
            );
        }

        public List<double> MultiplyAllBy(int factor, List<double> numbers)
        {

            if (numbers == null)
            {
                throw new ArgumentException("The list of numbers cannot be null.");
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = factor * numbers[i];
            }
            return numbers;
        }

        public List<double> MultiplyAllBy_Linq(int factor, List<double> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException("The list of numbers cannot be null.");
            }

            return numbers.Select(num => num * factor).ToList();
        }

    }
}
