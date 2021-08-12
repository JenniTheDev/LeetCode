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
            ListNode temp = new ListNode();

            while (l1.next != null && l2.next != null) {
                if (l1.val == l2.val) {
                    temp.next = l1.next;
                    l1.next = l2;
                    l2.next = temp;
                }
                if (l1.val < l2.val) {
                    l1.next = temp;
                    l1.next = l2;
                    l2.next = temp;
                }
                if (l1.val > l2.val) {
                    l2.next = temp;
                    l2.next = l1;
                    l1.
                }
            }

            return mergedList;
        }
    }
}