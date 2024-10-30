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
            int result = SumNumbersTo(input);
            Assert.AreEqual(expected, result);
        }

        public void sum_numbers_to_invalid_input(int input)
        {
            Assert.ThrowsException<ArgumentException>(() => SumNumbersTo(input));
        }

        public int SumNumbersTo(int input)
        {
            if (input < 1)
                throw new ArgumentException("Input must be greater than 0.");

            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                sum += i;
            }
            return sum;
        }

        public int SumNumbersTo_Recursion(int input)
        {
            if (input < 1)
                throw new ArgumentException("Input must be greater than 0.");

            return input == 1 ? 1 : input + SumNumbersTo_Recursion(input - 1);
        }

        public int SumNumbersTo_OneLineOfCode(int input)
        {
            if (input < 1)
                throw new ArgumentException("Input must be greater than 0.");

            return input * (input + 1) / 2;
        }

        public int SumNumbersTo_WithoutLinq(int input)
        {
            if (input < 1)
                throw new ArgumentException("Input must be greater than 0.");

            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                sum += i;
            }
            return sum;
        }

    }
}
