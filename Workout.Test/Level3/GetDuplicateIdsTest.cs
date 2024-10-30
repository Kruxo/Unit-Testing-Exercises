using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level3
{
    [TestClass]
    public class GetDuplicateIdsTest
    {
        /* Verkligt exempel (från Stena) */

        [DataRow("aa\nbb\n", "")]                   // inga dubbletter
        [DataRow("aa\nbb\naa\naa", "aa")]           // en dubblett, nämligen "aa"
        [DataRow("aa\nbb\nbb\naa\naa", "aa,bb")]    // två dubbletter
        [DataRow("aa;11;22\nbb;77;66\nbb;44;33\naa;22\naa", "aa,bb")]  // två dubbletter (ignorera det efter ;, det är andra kolumner)
        [TestMethod]
        public void get_duplicate_ids(string input, string expectedCommaSeparated)
        {
            string[] expected = expectedCommaSeparated.Split(",", StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> actual = GetDuplicateIds(input);

            CollectionAssert.AreEquivalent(expected, actual.ToArray());

        }

        // todo: alterntiv med Split och LINQ

        public HashSet<string> GetDuplicateIds(string filecontent)
        {
            throw new NotImplementedException();
        }

    }
}
