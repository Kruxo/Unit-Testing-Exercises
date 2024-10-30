using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level2
{
    [TestClass]
    public class NearbyElementsTest
    {

        [TestMethod]
        public void nearby_elements()
        {
            // Returnera närliggande elementen i listan. Den första parametern avser index för "mittenelementet".

            CollectionAssert.AreEqual(new List<string> { "c", "d", "e" },
                NearbyElements(3, new List<string> { "a", "b", "c", "d", "e" }));
            CollectionAssert.AreEqual(new List<string> { "a", "b" },
                NearbyElements(0, new List<string> { "a", "b", "c", "d", "e" }));
            CollectionAssert.AreEqual(new List<string> { "d", "e" },
                NearbyElements(4, new List<string> { "a", "b", "c", "d", "e" }));
        }

        [TestMethod]
        public void nearby_elements_invalid_input()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                NearbyElements(-1, new List<string> { "a", "b" })
            );

            Assert.ThrowsException<ArgumentException>(() =>
                NearbyElements(2, new List<string> { "a", "b" })
            );

            Assert.ThrowsException<ArgumentException>(() =>
                NearbyElements(3, new List<string> { "a", "b" })
            );
        }

        public List<string> NearbyElements(int position, List<string> list)
        {
            throw new NotImplementedException();
        }

    }
}
