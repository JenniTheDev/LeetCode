using System;

// https://leetcode.com/problems/remove-element/

namespace Remove_Element {
    internal class Solution {

        public int RemoveElement(int[] nums, int val) {
            int j = 0;
            if (nums == null || nums.Length == 0)
                return 0;

            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == val) {
                    continue;
                } else {
                    nums[j] = nums[i];
                    j++;
                }
            }
            return j;
        }
    }
}