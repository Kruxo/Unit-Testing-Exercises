using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level3
{
    [TestClass]
    public class CombineListsTest
    {

        [TestMethod]
        public void combine_lists()
        {
            // Slå ihop två listor till en (ett element i taget från vardera lista)

            CollectionAssert.AreEqual(
                new[] { 1, 7, 2, 8, 3, 9 },
                CombineLists(
                    new[] { 1, 2, 3 },
                    new[] { 7, 8, 9 })
            );

            CollectionAssert.AreEqual(
                new[] { 1, 7, 2, 8, 3 },
                CombineLists(
                    new[] { 1, 2, 3 },
                    new[] { 7, 8 })
            );


            CollectionAssert.AreEqual(
                new[] { 1, 7, 2, 3 },
                CombineLists(
                    new[] { 1, 2, 3 },
                    new[] { 7 })
            );

            CollectionAssert.AreEqual(
                new[] { 1, 2, 3 },
                CombineLists(
                    new[] { 1, 2, 3 },
                    new int[] { })
            );

            CollectionAssert.AreEqual(
                new[] { 1, 7, 2, 8, 9 },
                CombineLists(
                    new[] { 1, 2 },
                    new[] { 7, 8, 9 })
            );

            CollectionAssert.AreEqual(
                new[] { 1, 7, 8, 9 },
                CombineLists(
                    new[] { 1 },
                    new[] { 7, 8, 9 })
            );


            CollectionAssert.AreEqual(
                new[] { 7, 8, 9 },
                CombineLists(
                    new int[] { },
                    new[] { 7, 8, 9 })
            );

        }

        // todo: lös med LINQ

        public int[] CombineLists(int[] list1, int[] list2)
        {
            throw new NotImplementedException();
        }

    }
}
