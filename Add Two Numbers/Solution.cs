using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/add-two-numbers/

public class ListNode {
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}

namespace Add_Two_Numbers {
    internal class Solution {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode totalInOrder = new ListNode();
            int remainder = 0;
            ListNode temp = totalInOrder;

            while (l1 != null || l2 != null || remainder != 1) {
                // Ternary operator
                // if l1 is null ? yes val1=0 : no val1 = l1.val
                int val1 = l1 == null ? 0 : l1.val;
                int val2 = l2 == null ? 0 : l2.val;
                int sum = val1 + val2 + remainder;

                if (sum >= 10) {
                    sum %= 10;
                } else {
                    remainder = 0;
                }
                temp.next = new ListNode(sum);
                temp = temp.next;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            return totalInOrder;
        }
    }
}