using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level1
{
    [TestClass]
    public class Add70ToEverySecondElementTest
    {

        [TestMethod]
        public void add_70_to_every_second_element()
        {
            // Addera 70 till varannat element i listan

            var input = new List<int> { 1000, 2000, 3000, 4000, 5000 };
            var expected = new List<int> { 1000, 2070, 3000, 4070, 5000 };

            var result = Add70ToEverySecondElement(input);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void add_70_to_every_second_element_linq()
        {
            // Addera 70 till varannat element i listan

            var input = new List<int> { 1000, 2000, 3000, 4000, 5000 };
            var expected = new List<int> { 1000, 2070, 3000, 4070, 5000 };

            var result = Add70ToEverySecondElement_Linq(input);

            CollectionAssert.AreEqual(expected, result);
        }

        public List<int> Add70ToEverySecondElement(List<int> numbers)
        {
            for (int i = 1; i < numbers.Count; i += 2) //Starts at 1 and increments with 2 to skip every other index
            {
                numbers[i] += 70;
            }
            return numbers;

            //This also works
            // for (int i = 0; i < numbers.Count; i++) 
            // {
            //     numbers[i+1] += 70;
            // }
            // return numbers;
        }

        public List<int> Add70ToEverySecondElement_Linq(List<int> numbers)
        {
            numbers = numbers.Select((num, index) => index % 2 != 0 ? num + 70 : num).ToList();
            return numbers;

            /*
            The Select method can be written with a lambda function that provides two arguments:
            The first argument represents each element in the list.
            The second argument is the index of that element in the list.
            
            Here’s what’s happening step-by-step:
            1. .Select((num, index) => ... ): Select iterates over each element in numbers and passes two values to the lambda:
            - num: The value of the current element (e.g., 1000, 2000, etc.)
            - index: The position of the current element in the list (e.g., 0, 1, 2, etc.)
            
            2. index % 2 != 0: We use the index to determine if the element is at an odd position (every second element), where index % 2 != 0 is true.

            3. num + 70 or num: For every element where index % 2 != 0 is true, we add 70 to num; otherwise, we leave num unchanged.

            4. .ToList(): Finally, ToList() collects the transformed elements into a new list, which is returned as the result.
            */
        }

    }
}
