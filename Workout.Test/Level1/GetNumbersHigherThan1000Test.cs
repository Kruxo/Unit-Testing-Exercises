using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level1
{
    [TestClass]
    public class GetNumbersHigherThan1000Test
    {

        [TestMethod]
        public void get_numbers_higher_than_1000()
        {
            // Filtrera ut de tal som är högre än 1000

            var input = new List<int> { 1005, 6, 77, 200000, 666 };
            var expected = new List<int> { 1005, 200000 };
            var result = GetNumbersHigherThan1000(input);

            CollectionAssert.AreEqual(expected, result);
        }


        [TestMethod]
        public void get_numbers_higher_than_1000_linq()
        {
            // Filtrera ut de tal som är högre än 1000

            var input = new List<int> { 1005, 6, 77, 200000, 666 };
            var expected = new List<int> { 1005, 200000 };
            var result = GetNumbersHigherThan1000_Linq(input);

            CollectionAssert.AreEqual(expected, result);
        }

        public List<int> GetNumbersHigherThan1000(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public List<int> GetNumbersHigherThan1000_Linq(List<int> numbers)
        {
            throw new NotImplementedException();
        }

    }
}
