using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level2
{
    [TestClass]
    public class ZipZapBoingTest
    {
        [TestMethod]
        public void zip_zap_boing()
        {
            /*
            Negativa tal => "ZIP"
            Positiva tal => "ZAP"
            Noll         => "BOING"
            */

            List<string> result = ZipZapBoing(new List<int> { 1003, 20, -130, 0, 2040 });
            List<string> expected = new List<string> { "ZAP", "ZAP", "ZIP", "BOING", "ZAP" };

            CollectionAssert.AreEqual(expected, result);
        }

        // todo: lös med LINQ

        public List<string> ZipZapBoing(List<int> numbers)
        {
            throw new NotImplementedException();
        }

    }
}
