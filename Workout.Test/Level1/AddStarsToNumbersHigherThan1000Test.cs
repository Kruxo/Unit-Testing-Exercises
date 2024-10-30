using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level1
{
    [TestClass]
    public class AddStarsToNumbersHigherThan1000Test
    {

        [TestMethod]
        public void add_stars_to_numbers_higher_than_1000()
        {
            // Lägg till stjärnor runt de tal som är högre än 1000

            List<string> result = AddStarsToNumbersHigherThan1000(new List<int> { 1003, 20, -130, 2040 });
            List<string> expected = new List<string> { "***1003***", "20", "-130", "***2040***" };

            CollectionAssert.AreEqual(expected, result);
        }

        // todo: gör en Linq-lösning

        public List<string> AddStarsToNumbersHigherThan1000(List<int> numbers)
        {
            return numbers.Select(num => num > 1000 ? $"***{num}***" : $"{num}").ToList();
        }

    }
}
