using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level2
{
    [TestClass]
    public class ReportNumberOfNegativeValuesTest
    {
        [TestMethod]
        public void report_number_of_negative_values()
        {
            // Returnera en text hur många negativa tal som finns i listan
            Assert.AreEqual("Det finns 2 st negativa tal i listan", ReportNumberOfNegativeValues(new List<int> { 5, 7, -2, 100, -4 }));
            Assert.AreEqual("Det finns 2 st negativa tal i listan", ReportNumberOfNegativeValues_Linqish(new List<int> { 5, 7, -2, 100, -4 }));

            Assert.AreEqual("Jippi! Det finns inga negativa tal i listan", ReportNumberOfNegativeValues(new List<int> { 5, 7, 44, 100, 33 }));
            Assert.AreEqual("Jippi! Det finns inga negativa tal i listan", ReportNumberOfNegativeValues_Linqish(new List<int> { 5, 7, 44, 100, 33 }));

            Assert.AreEqual("Det finns ett negativt tal i listan", ReportNumberOfNegativeValues(new List<int> { 5, 7, -2, 100, 4 }));
            Assert.AreEqual("Det finns ett negativt tal i listan", ReportNumberOfNegativeValues_Linqish(new List<int> { 5, 7, -2, 100, 4 }));
        }

        public string ReportNumberOfNegativeValues(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public string ReportNumberOfNegativeValues_Linqish(List<int> numbers)
        {
            throw new NotImplementedException();
        }

    }
}
