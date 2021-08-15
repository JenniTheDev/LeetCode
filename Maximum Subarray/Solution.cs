// https://leetcode.com/problems/maximum-subarray/
namespace Maximum_Subarray {
    internal class Solution {

        public int MaxSubArray(int[] nums) {
            int maxSum = int.MinValue; // smallest possible int
            int currentSum = 0;

            for (int i = 0; i < nums.Length; i++) {
                currentSum = 0;
                for (int j = i; j < nums.Length; j++) {
                    currentSum += nums[j];
                    if (currentSum > maxSum) {
                        maxSum = currentSum;
                    }
                }
            }

            return maxSum;
        }
    }
}