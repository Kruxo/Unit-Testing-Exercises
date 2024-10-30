using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level1
{
    [TestClass]
    public class AddStarsTest
    {

        [TestMethod]
        public void add_stars()
        {
            // Lägg till tre stjärnor innan och efter siffran

            List<string> result = AddStars(new List<int> { 1003, 20, -130, 2040 });
            List<string> expected = new List<string> { "***1003***", "***20***", "***-130***", "***2040***" };

            CollectionAssert.AreEqual(expected, result);
        }

        // todo: gör en Linq-lösning

        public List<string> AddStars(List<int> numbers)
        {
            return numbers.Select(num => $"***{num}***").ToList();
        }
    }
}
