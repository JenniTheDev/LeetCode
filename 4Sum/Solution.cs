using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Sum {
    class Solution {
        IList<IList<int>> numsThatSum;
        int numOne, numTwo, numThree, numFour;

        public IList<IList<int>> FourSum(int[] nums, int target) {

            for (int i = 0; i < nums.Length; i++) {
                // maybe subtract a number from the target, then another number, and eliminate numbers that are larger then the remainder of the target?
                // loop through all possibilities of 4 number groups and brute force it
            }
            // when the four numbers are equal, put in a list and add to the numsThatSum

            return numsThatSum;
        }

        private bool IsNumbersEqual(int nOne, int nTwo, int nThree, int nFour, int shouldEqual) {
            return nOne + nTwo + nThree + nFour == shouldEqual;

        }
    }
}
