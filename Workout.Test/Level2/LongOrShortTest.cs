using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level2
{
    [TestClass]
    public class LongOrShortTest
    {
        [TestMethod]
        public void long_or_short()
        {
            // Skapa en lista av strängar som meddelar om personen är kort eller lång (över 160cm). Hoppa över orimliga värden

            List<string> result = LongOrShort(new List<int> { 170, 130, 205, -10, 600, 180 });
            List<string> expected = new List<string> { "170cm är långt", "130cm är kort", "205cm är långt", "180cm är långt" };

            CollectionAssert.AreEqual(expected, result);
        }

        // todo: lösning med linq (och yield)

        public List<string> LongOrShort(List<int> heightList)
        {
            throw new NotImplementedException();
        }

    }
}
