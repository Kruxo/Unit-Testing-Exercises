using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level3
{
    [TestClass]
    public class FrameTest
    {

        [TestMethod]
        public void frame_long()
        {
            /*
             
            *********
            * Hello *
            * World *
            * in    *
            * a     *
            * frame *
            *********
             
             */
            string expected = "*********\n* Hello *\n* World *\n* in    *\n* a     *\n* frame *\n*********";
            string actual = Frame("Hello", "World", "in", "a", "frame");
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void frame_one_word()
        {
            /*
             
            *********
            * Hello *
            *********
             
             */
            string expected = "*********\n* Hello *\n*********";
            string actual = Frame("Hello");
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void frame_one_letter()
        {
            /*
             
            *****
            * H *
            *****
             
             */
            string expected = "*****\n* H *\n*****";
            string actual = Frame("H");
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void frame_no_words()
        {
            var expected = "";
            string actual = Frame(new string[] { });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void frame_exceptions()
        {
            Assert.ThrowsException<ArgumentException>(() => Frame(null));
        }

        public string Frame(params string[] rows)
        {
            throw new NotImplementedException();
        }

    }
}
