using System;
using Xunit;
using LeetCode;
using System.Collections.Generic;

namespace LeetCodeTests
{
    public class EasyLeetCodeTests
    {
        [Theory]
        [MemberData(nameof(LongestCommonPrefixData))]
        public void LongestCommonPrefixTest(string[] strArray, string expected)
        {
            Assert.Equal(expected, LongestCommonPrefix.Solve.FindLongestCommonPrefix(strArray));
        }

        public static IEnumerable<object[]> LongestCommonPrefixData()
        {
            yield return new object[] { new string[] { "flower", "flow", "flight" }, "fl" };
            yield return new object[] { new string[] { "dog", "racecar", "car" }, string.Empty };
            yield return new object[] { new string[] { "flower", "flower", "flower", "flower" }, "flower" };
            yield return new object[] { Array.Empty<string>(), string.Empty };
            yield return new object[] { new string[] { "frog" }, "frog" };
            yield return new object[] { new string[] { "aca", "cba" }, String.Empty };
            yield return new object[] { new string[] { "", "" }, string.Empty };
            yield return new object[] { new string[] { "cir", "car" }, "c" };
            yield return new object[] { new string[] { "reflower", "flow", "flight" }, string.Empty };
        }

        [Theory]
        [MemberData(nameof(ValidParenthesesData))]
        public void ValidParenthesesTest(bool expected, string s)
        {
            Assert.Equal(expected, ValidParentheses.Solve.IsValid(s));
        }

        public static IEnumerable<object[]> ValidParenthesesData()
        {
            yield return new object[] { true, "()" };
            yield return new object[] { true, "()[]{}" };
            yield return new object[] { false, "(]" };
        }

        [Theory]
        [MemberData(nameof(RomanToIntData))]
        public void RomanToIntTest(int expected, string s)
        {
            Assert.Equal(expected, RomanToInteger.Solve.RomanToInt(s));
        }

        public static IEnumerable<object[]> RomanToIntData()
        {
            yield return new object[] { 3, "III" };
            yield return new object[] { 58, "LVIII" };
            yield return new object[] { 1994, "MCMXCIV" };
        }
    }
}