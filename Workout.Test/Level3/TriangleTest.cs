using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level3
{
    [TestClass]
    public class TriangleTest
    {

        [TestMethod]
        public void triangle()
        {
            Assert.ThrowsException<ArgumentException>(() => Triangle(-1));
            Assert.ThrowsException<ArgumentException>(() => TriangleReversed(-1));
            Assert.ThrowsException<ArgumentException>(() => Triangle(-10));

            {
                var actual = Triangle(0);
                var expected = "";
                Assert.AreEqual(expected, actual);
            }
            {
                var actual = Triangle(1);
                var expected = "*";
                Assert.AreEqual(expected, actual);
            }
            {
                var actual = Triangle(3);
                var expected = "*\n**\n***";
                Assert.AreEqual(expected, actual);
            }
            {
                var actual = Triangle(4);
                var expected = "*\n**\n***\n****";
                Assert.AreEqual(expected, actual);
            }
            {
                var actual = Triangle(4, '+');
                var expected = "+\n++\n+++\n++++";
                Assert.AreEqual(expected, actual);
            }
            {
                var actual = TriangleReversed(4);
                var expected = "****\n***\n**\n*";
                Assert.AreEqual(expected, actual);
            }
        }

        // todo: generisk Triangle-metod (som tar det som är gemensamt med de två följande)

        public string Triangle(int height, char symbol = '*')
        {
            throw new NotImplementedException();
        }

        public string TriangleReversed(int height, char symbol = '*')
        {
            throw new NotImplementedException();
        }

    }
}
