using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level1
{
    [TestClass]
    public class DivideEachNumberBy100Test
    {

        [TestMethod]
        public void divide_each_number_by_100()
        {
            // Dela alla tal i listan med 100

            var input = new List<int> { 300, 200, -500, 1000 };
            var expected = new List<int> { 3, 2, -5, 10 };
            var result = DivideEachNumberBy100(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void divide_each_number_by_100_linq()
        {
            // Extra: lös det med LINQ

            var input = new List<int> { 300, 200, -500, 1000 };
            var expected = new List<int> { 3, 2, -5, 10 };
            var result = DivideEachNumberBy100_Linq(input);

            CollectionAssert.AreEqual(expected, result);
        }

        public List<int> DivideEachNumberBy100(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i] / 100;
            }
            return numbers;
        }

        public List<int> DivideEachNumberBy100_Linq(List<int> numbers)
        {
            return numbers.Select(num => num / 100).ToList();
        }

    }
}
