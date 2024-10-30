using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level1
{

    [TestClass]
    public class Add100ToEachNumberTest
    {

        [TestMethod]
        public void add_100_to_each_number()
        {
            var input = new List<int> { 5, 15, 23, 200 };
            var expected = new List<int> { 105, 115, 123, 300 };
            var result = Add100ToEachNumber(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void add_100_to_each_number_linq()
        {
            var input = new List<int> { 5, 15, 23, 200 };
            var expected = new List<int> { 105, 115, 123, 300 };
            var result = Add100ToEachNumber_Linq(input);

            CollectionAssert.AreEqual(expected, result);
        }

        public List<int> Add100ToEachNumber(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count(); i++)
            {
                numbers[i] = numbers[i] + 100;
            }
            return numbers;
        }

        public List<int> Add100ToEachNumber_Linq(List<int> numbers)
        {
            //return numbers.Select((num, index) => num + 100).ToList();

            return (from num in numbers
                    select num + 100).ToList();
        }

    }
}
