using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level1
{
    [TestClass]
    public class NegateEachNumberTest
    {
        [TestMethod]
        public void negate_each_number()
        {
            // Negera alla tal i listan

            var input = new List<int> { 10, 20, -30, 40 };
            var expected = new List<int> { -10, -20, 30, -40 };
            var result = NegateEachNumber(input);

            CollectionAssert.AreEqual(expected, result);
        }

        // todo: lösning med LINQ

        public List<int> NegateEachNumber(List<int> numbers)
        {
            return numbers.Select(n => n * (-1)).ToList();
        }

    }
}
