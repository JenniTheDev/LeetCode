// https://leetcode.com/problems/longest-common-prefix/
using System.Text;

namespace LeetCode
{
    public static class LongestCommonPrefix
    {
        public static Solution Solve { get; } = new();

        public class Solution
        {
            public string FindLongestCommonPrefix(string[] strs)
            {
                if (strs == null || strs.Length == 0) { return String.Empty; }
                if (strs.Length == 1) { return strs[0]; }

                StringBuilder prefix = new StringBuilder();

                Array.Sort(strs); //sort in alphabetical order
                int length = strs[0].Length;
                int size = strs.Length - 1;

                for (int i = 0; i < length; i++)
                {
                    if (strs[0][i] == strs[size][i])
                    {
                        prefix.Append(strs[0][i]);
                    }
                    else
                    {
                        break;
                    }
                }
                return prefix.ToString();
            }
        }
    }
}