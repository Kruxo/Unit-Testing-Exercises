using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Workout.Test.Level1
{
    [TestClass]
    public class SumNumbersTest
    {
        [TestMethod]
        [DataRow(5, 5, 5)]
        [DataRow(5 + 6, 5, 6)]
        [DataRow(3 + 4 + 5 + 6 + 7, 3, 7)]
        [DataRow(-3 + -2 + -1 + 0 + 1 + 2, -3, 2)]

        public void sum_numbers(int expected, int from, int to)
        {
            // Act
            int result = SumNumbers(from, to);

            // Assert
            Assert.AreEqual(expected, result);
        }

        public void sum_numbers_invalidinput(int from, int to)
        {
            Assert.ThrowsException<ArgumentException>(() => SumNumbers(from, to));
        }

        public int SumNumbers(int from, int to)
        {

            if (from > to)
            {
                throw new ArgumentException("The 'from' value cannot be greater than 'to'.");
            }

            int sum = 0;
            for (int i = from; i <= to; i++)
            {
                sum += i;
            }

            return sum;
        }

    }
}
