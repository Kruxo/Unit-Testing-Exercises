using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Workout.Test.Level2
{
    [TestClass]
    public class IsPalindromeTest
    {
        [TestMethod]
        [DataRow("abcba")]
        [DataRow("aba")]
        [DataRow("a")]
        [DataRow("")]
        [DataRow("åäöäå")]

        public void is_palindrome(string input)
        {
            throw new NotImplementedException();
        }

        public void is_not_palindrome(string input)
        {
            throw new NotImplementedException();
        }

        public void should_just_allow_swedish_letters(string input)
        {
            throw new NotImplementedException();
        }

        public bool IsPalindrome(string word)
        {
            throw new NotImplementedException();
        }

        public bool IsPalindrome_ForLoop(string word)
        {
            throw new NotImplementedException();
        }

        public bool IsPalindrome_Recursive(string word)
        {
            throw new NotImplementedException();
        }

    }
}
