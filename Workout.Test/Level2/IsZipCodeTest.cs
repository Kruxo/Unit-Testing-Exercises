using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Workout.Test.Level2
{
    [TestClass]
    public class IsZipCodeTest
    {

        [TestMethod]
        [DataRow("111 11")]
        [DataRow("999 99")]
        [DataRow("234 56")]

        public void a_valid_zipcode(string text)
        {
            throw new NotImplementedException();
        }

        public void not_a_zipcode(string text)
        {
            throw new NotImplementedException();
        }

        public bool IsZipCode(string text)
        {
            throw new NotImplementedException();
        }

    }
}
