// https://leetcode.com/problems/merge-two-sorted-lists/

public class ListNode {
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}

namespace Merge_Two_Sorted_Lists {
    internal class Solution {

        public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            ListNode mergedList = new ListNode();
            ListNode temp = mergedList;
            if (l1 == null & l2 == null) { return null; }
            if (l1 == null) { return l2; }
            if (l2 == null) { return l1; }

            while (l1 != null && l2 != null) {
                if (l1.val <= l2.val) {
                    temp.next = l1;
                    l1 = l1.next;
                } else {
                    temp.next = l2;
                    l2 = l2.next;
                }
                temp = temp.next;
            }
            temp.next = l1 == null ? l2 : l1;

            return mergedList.next;
        }
    }
}