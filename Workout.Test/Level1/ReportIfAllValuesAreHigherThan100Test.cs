using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level1
{
    [TestClass]
    public class ReportIfAllValuesAreHigherThan100Test
    {
        [TestMethod]
        public void high_numbers()
        {
            var input = new List<int> { 5000, 101, 2000 };
            Assert.AreEqual("Alla nummer är högre än 100", ReportIfAllValuesAreHigherThan100(input));
        }

        [TestMethod]
        public void some_low_number()
        {
            var input = new List<int> { 5000, 100, 2000 };
            Assert.AreEqual("Något nummer är lägre än (eller lika med) 100", ReportIfAllValuesAreHigherThan100(input));
        }

        [TestMethod]
        public void shouldnt_allow_empty_list()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                ReportIfAllValuesAreHigherThan100(new List<int> { })
            );
        }

        [TestMethod]
        public void shouldnt_allow_null()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                ReportIfAllValuesAreHigherThan100(null)
            );
        }

        public string ReportIfAllValuesAreHigherThan100(List<int> numbers)
        {
            //Checks if the list is null or empty
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("List cannot be null or empty.");
            }

            //Checks if all numbers are greater than 100

            return numbers.All(num => num > 100) ? "Alla nummer är högre än 100" : "Något nummer är lägre än (eller lika med) 100";

            // if (numbers.All(num => num > 100))
            // {
            //     return "Alla nummer är högre än 100";
            // }
            // else
            // {
            //     return "Något nummer är lägre än (eller lika med) 100";
            // }
        }

    }
}
