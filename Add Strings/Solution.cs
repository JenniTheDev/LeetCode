using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Strings {
    internal class Solution {

        public string AddStrings(string num1, string num2) {
            StringBuilder total = new StringBuilder();
            int i = num1.Length - 1;
            int j = num2.Length - 1;
            int carry = 0;

            while (i >= 0 || j >= 0 || carry > 0) {
                int digitI = i >= 0 ? num1[i--] - '0' : 0;
                int digitJ = j >= 0 ? num2[j--] - '0' : 0;
                int sum = (digitI + digitJ + carry) % 10;
                total.Append(sum);
                carry = (digitI + digitJ + carry) / 10;
            }

            return new string(total.ToString().Reverse().ToArray());
        }
    }
}