using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level1
{
    [TestClass]
    public class SumNumbersDividedByThreeOrFiveTest
    {
        //DataRow tests with expected output and input limit.
        [TestMethod]
        [DataRow(0, 1)]
        [DataRow(0, 2)]
        [DataRow(3, 3)]
        [DataRow(3, 4)]
        [DataRow(3 + 5, 5)]
        [DataRow(3 + 5 + 6, 6)]
        [DataRow(3 + 5 + 6, 7)]
        [DataRow(3 + 5 + 6, 8)]
        [DataRow(3 + 5 + 6 + 9, 9)]
        [DataRow(3 + 5 + 6 + 9 + 10, 10)]


        public void sum_numbers_divided_by_three_or_five(int expected, int input)
        {
            //Write the test yourself here

            // Act
            int result = SumNumbersDividedByThreeOrFive(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        public int SumNumbersDividedByThreeOrFive(int input)
        {
            int sum = 0;

            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

    }
}
