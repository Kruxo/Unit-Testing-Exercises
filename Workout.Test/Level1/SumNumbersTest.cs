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
            throw new NotImplementedException();
        }

        public void sum_numbers_invalidinput(int from, int to)
        {
            throw new NotImplementedException();
        }

        public int SumNumbers(int from, int to)
        {
            throw new NotImplementedException();
        }

    }
}
