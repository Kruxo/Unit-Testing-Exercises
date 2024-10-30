using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level2
{
    [TestClass]
    public class GetEverySecondElementTest
    {

        [TestMethod]
        [DataRow(null, new string[] { }, new[] { "a" })]
        [DataRow(null, new string[] { "b" }, new[] { "a", "b" })]
        [DataRow(null, new string[] { "b" }, new[] { "a", "b", "c" })]
        [DataRow(null, new string[] { "b", "d" }, new[] { "a", "b", "c", "d" })]
        [DataRow(null, new string[] { "b", "d" }, new[] { "a", "b", "c", "d", "e" })]

        public void get_every_second_element(object dummy, string[] expected, string[] input)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetEverySecondElement(string[] strings)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetEverySecondElement_WithYield(string[] strings)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetEverySecondElement_OneLiner(string[] strings)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetEverySecondElement_OneLiner_WithHelpMethod(string[] strings)
        {
            throw new NotImplementedException();
        }

    }
}
