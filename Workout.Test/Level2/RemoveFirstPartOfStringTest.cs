using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level2
{
    [TestClass]
    public class RemoveFirstPartOfStringTest
    {
        [DataRow("abcdefgh", "abc", "defgh")]
        [DataRow("abc", "a", "bc")]
        [DataRow("abc", "xyz", "abc")]
        [DataRow("abc", "xyzzzzzzzzz", "abc")]
        [DataRow("abcdefghabc", "abc", "defghabc")]      // ta bara bort första "abc"
        [DataRow(" abcdefghabc", "abc", " abcdefghabc")] // ta inte bort något
        [TestMethod]
        public void remove_first_part_of_string(string original, string stringToRemove, string expected)
        {
            string actual = RemoveFirstPartOfString(original, stringToRemove);

            Assert.AreEqual(expected, actual);
        }
        
        // todo: lös med regex (utmaning: hantera tecken som behöver escape'as som t.ex parantes)

        public string RemoveFirstPartOfString(string original, string stringToRemove)
        {
            throw new NotImplementedException();
        }

    }
}
