/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int n1 = 0;
        int remainder = 0;

        ListNode lp1 = l1; // Copy
        ListNode lp2 = l2;
        ListNode retNode = new ListNode(); // Return ListNode
        ListNode lp3 = retNode; // Copy of Return ListNode

        while (lp1 != null && lp2 != null) { // Until one list reaches null
            n1 = lp1.val + lp2.val + remainder;

            remainder = n1 / 10;

            lp3.val = n1 % 10;

            lp1 = lp1.next;
            lp2 = lp2.next;
            if (lp1 != null || lp2 != null || remainder != 0)
                lp3.next = new ListNode();
            lp3 = lp3.next;
        }

        // Continue if one list is longer
        while (lp1 != null) {
            n1 = lp1.val + remainder;

            remainder = n1 / 10;

            lp3.val = n1 % 10;

            lp1 = lp1.next;
            if (lp1 != null || remainder != 0)
                lp3.next = new ListNode();
            lp3 = lp3.next;
        }

        while (lp2 != null) {
            n1 = lp2.val + remainder;

            remainder = n1 / 10;

            lp3.val = n1 % 10;

            lp2 = lp2.next;
            if (lp2 != null || remainder != 0)
                lp3.next = new ListNode();
            lp3 = lp3.next;
        }

        if (remainder != 0) {
            lp3.val = remainder;
        }

        return retNode;
    }
}