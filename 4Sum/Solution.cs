using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/4sum/
namespace _4Sum {
    internal class Solution {
        private IList<IList<int>> numsThatSum;
        private int numOne, numTwo, numThree, numFour;

        public IList<IList<int>> FourSum(int[] nums, int target) {
            for (int i = 0; i < nums.Length; i++) {
                for (int j = 1; j < nums.Length - 1; j++) {
                    for (int k = 2; k < nums.Length - 2; k++) {
                        for (int l = 3; l < nums.Length - 3; l++) {
                            if (IsNumbersEqual(nums[i], nums[j], nums[k], nums[l], target) == true) {
                                IList<int> numsToAdd = new List<int>();
                                numsToAdd.Add(nums[i]);
                                numsToAdd.Add(nums[j]);
                                numsToAdd.Add(nums[k]);
                                numsToAdd.Add(nums[l]);
                                numsThatSum.Add(numsToAdd);
                            }
                        }
                    }
                }
            }

            return numsThatSum;
        }

        // if this is true, make list of numbers, add list to list
        private bool IsNumbersEqual(int nOne, int nTwo, int nThree, int nFour, int shouldEqual) {
            return nOne + nTwo + nThree + nFour == shouldEqual;
        }
    }
}