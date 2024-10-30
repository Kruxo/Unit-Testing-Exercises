using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Workout.Test.Level1
{
    [TestClass]
    public class SumNumbersToTest
    {

        [TestMethod]
        [DataRow(1, 1)]
        [DataRow(1 + 2, 2)]
        [DataRow(1 + 2 + 3, 3)]
        [DataRow(1 + 2 + 3 + 4, 4)]

        public void sum_numbers_to(int expected, int input)
        {
            throw new NotImplementedException();
        }

        public void sum_numbers_to_invalid_input(int input)
        {
            throw new NotImplementedException();
        }

        public int SumNumbersTo(int input)
        {
            throw new NotImplementedException();
        }

        public int SumNumbersTo_Recursion(int input)
        {
            throw new NotImplementedException();
        }

        public int SumNumbersTo_OneLineOfCode(int input)
        {
            throw new NotImplementedException();
        }

        public int SumNumbersTo_WithoutLinq(int input)
        {
            throw new NotImplementedException();
        }

    }
}
