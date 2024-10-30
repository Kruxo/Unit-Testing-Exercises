using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level2
{
    [TestClass]
    public class AllWordsAreFiveLettersOrLongerTest
    {
        [TestMethod]
        [DataRow(new[] { "abcdef", "friday", "ooooooooo" })]

        public void all_words_are_longer_than_five_letters(string[] input)
        {
            throw new NotImplementedException();
        }

        public void all_words_are_longer_than_five_letters_should_return_false(string[] input)
        {
            throw new NotImplementedException();
        }

        public bool AllWordsAreFiveLettersOrLonger(IEnumerable<string> list)
        {
            throw new NotImplementedException();
        }

        public bool AllWordsAreFiveLettersOrLonger_Linq(IEnumerable<string> list)
        {
            throw new NotImplementedException();
        }

    }
}
