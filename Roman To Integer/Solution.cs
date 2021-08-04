using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/roman-to-integer/
namespace Roman_To_Integer {
    internal class Solution {

        public int RomanToInt(string s) {
            var romanNumDict = new Dictionary<char, int> {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

            var specialCases = new HashSet<char>() {
                'V', 'X', 'L', 'C', 'D', 'M'
            };

            int total = 0;
            s.ToCharArray();

            for (int i = 0; i < s.Length; i++) {
                if (s[i] == 'I' || s[i] == 'X' || s[i] == 'C') {
                    if (IsAtTheEnd(s.Length, i) == false && IsSpecialCase(s[i + 1], specialCases) == true) {
                        total = romanNumDict[s[i + 1]] - romanNumDict[s[i]];
                        i++; // needs to skip the s[i+1] that was added
                    }
                } else {
                    total = +romanNumDict[s[i]];
                }
            }
            return total;
        }

        private bool IsSpecialCase(char toCheck, HashSet<char> spCases) {
            if (spCases.Contains(toCheck)) {
                return true;
            } else return false;
        }

        private bool IsAtTheEnd(int length, int index) {
            if (length - 1 == index) {
                return true;
            } else return false;
        }
    }
}