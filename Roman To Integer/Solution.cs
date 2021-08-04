using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/roman-to-integer/
namespace Roman_To_Integer {
    internal class Solution {

        public int RomanToInt(string s) {
            readonly var romanNums = new Dictionary<char, int> {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

            // int total = 0;
            s.ToCharArray();

            int prevNum = romanNums[s[s.Length - 1]];
            int total = prevNum;
            for (int i = s.Length - 2; i >= 0; i--) {
                if (romanNums[s[i]] < prevNum) {
                    total -= romanNums[s[i]];
                } else {
                    total += romanNums[s[i]];
                }
                prevNum = romanNums[s[i]];
            }
            return total;
        }
    }
}