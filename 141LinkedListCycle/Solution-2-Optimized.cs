// Time: O(n) - Space: O(1)
public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null) {
            return false;
        } 
        
        ListNode slow = head;
        ListNode fast = head; 
        
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
            
            if (slow == fast) {
                return true;
            }
        }
        return false;
    }
}