using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level2
{
    [TestClass]
    public class Add50ToFirstThreeElementsTest
    {
        [TestMethod]
        public void add_50_to_first_three_elements()
        {
            // Addera 50 till de tre första elementen i listan

            var input = new List<int> { 6, 16, 23, 200, 300 };
            var expected = new List<int> { 56, 66, 73, 200, 300 };
            var result = Add50ToFirstThreeElements(input);
            CollectionAssert.AreEqual(expected, result);

            // Alternativa lösningar:

            CollectionAssert.AreEqual(expected, Add50ToFirstThreeElements_Linq(input));
            CollectionAssert.AreEqual(expected, Add50ToFirstThreeElements_Linq_Oneliner(input));
            CollectionAssert.AreEqual(expected, Add50ToFirstThreeElements_For(input));
            CollectionAssert.AreEqual(expected, Add50ToFirstThreeElements_For_Range(input));
        }

        [TestMethod]
        public void add_50_to_first_three_elements_shortlist()
        {
            // Addera 50 till de tre första elementen i listan

            var input = new List<int> { 6, 16 };
            var expected = new List<int> { 56, 66 };
            var result = Add50ToFirstThreeElements(input);

            CollectionAssert.AreEqual(expected, result);

            // Alternativa lösningar:

            CollectionAssert.AreEqual(expected, Add50ToFirstThreeElements_Linq(input));
            CollectionAssert.AreEqual(expected, Add50ToFirstThreeElements_Linq_Oneliner(input));
            CollectionAssert.AreEqual(expected, Add50ToFirstThreeElements_For(input));
            CollectionAssert.AreEqual(expected, Add50ToFirstThreeElements_For_Range(input));
        }

        public List<int> Add50ToFirstThreeElements(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public List<int> Add50ToFirstThreeElements_For(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public List<int> Add50ToFirstThreeElements_For_Range(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public List<int> Add50ToFirstThreeElements_Linq(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public List<int> Add50ToFirstThreeElements_Linq_Oneliner(List<int> numbers)
        {
            throw new NotImplementedException();
        }

    }
}
