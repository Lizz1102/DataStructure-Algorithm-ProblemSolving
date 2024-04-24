public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if (head == null) {
            return null;
        } 
        
        ListNode slow = head;
        ListNode fast = head;
        
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
            
            if (slow == fast) {
                slow = head; // move slow pointer back to head, fast stays at meeting point 
                while (slow != fast) {
                    slow = slow.next;
                    fast = fast.next;
                }
                return slow; // slow and fast meets at the cycle start 
            }
        }
        return null; 
    }
}