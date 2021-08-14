using System;

// https://leetcode.com/problems/remove-element/

namespace Remove_Element {
    internal class Solution {

        public int RemoveElement(int[] nums, int val) {
            int arrayLength = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (val == nums[i]) {
                    MoveAllForward(ref nums, i);
                    arrayLength++; // getting one extra, need to step through
                }
            }
            return arrayLength;
        }

        private void MoveAllForward(ref int[] nums, int startPoint) {
            for (int i = startPoint; i < nums.Length - 1; i++) {
                nums[i] = nums[i + 1];
            }
        }
    }
}