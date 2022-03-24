/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        
        if (head == null) return null;
        
        var slow = head;
        var fast = head;
        
        do {
            
            if (fast == null || fast.next == null) return null;
            
            slow = slow.next;
            fast = fast.next.next;
            
            if (slow == fast) {
                slow = head;
                while (slow != fast) {
                    slow = slow.next;
                    fast = fast.next;
                }
                return slow;
            }
        } while (slow != fast);
        
        return slow;
    }
}
