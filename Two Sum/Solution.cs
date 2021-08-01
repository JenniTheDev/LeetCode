using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/two-sum/submissions/

namespace Two_Sum {
    internal class Solution {

        public int[] TwoSum(int[] nums, int target) {
            int[] numSum = new int[2];
            int tempTarget;

            for (int i = 0; i < nums.Length - 1; i++) {
                tempTarget = target;
                tempTarget -= nums[i];
                for (int j = 1; j < nums.Length; j++) {
                    if (i != j) {
                        if (nums[j] == tempTarget) {
                            numSum[0] = i;
                            numSum[1] = j;
                            return numSum;
                        }
                    }
                }
            }

            return numSum;
        }
    }
}