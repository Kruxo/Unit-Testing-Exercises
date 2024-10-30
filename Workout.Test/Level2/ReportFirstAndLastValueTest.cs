using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level2
{
    [TestClass]
    public class ReportFirstAndLastValueTest
    {
        [TestMethod]
        public void report_first_and_last_value()
        {
            // Returnera en text som talar om vilket det första och sista numret är i listan
            string result = ReportFirstAndLastValue(new List<int> { 5, 1000, 2000, 3000, 6 });
            Assert.AreEqual("Första siffran är 5 och sista siffran är 6", result);
        }

        [TestMethod]
        public void report_first_and_last_value_with_one_element()
        {
            string result = ReportFirstAndLastValue(new List<int> { 5 });
            Assert.AreEqual("Första siffran är 5", result);
        }

        [TestMethod]
        public void report_first_and_last_value_with_empty_list()
        {
            Assert.ThrowsException<ArgumentException>(() =>

                ReportFirstAndLastValue(new List<int>())

            );

            Assert.ThrowsException<ArgumentException>(() =>

                ReportFirstAndLastValue(null)

            );
        }

        public string ReportFirstAndLastValue(List<int> numbers)
        {
            throw new NotImplementedException();
        }

    }
}
