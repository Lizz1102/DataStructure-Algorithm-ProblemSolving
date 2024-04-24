// Time: O(n) - Space: O(n)
public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null) {
            return false;
        } 
        
        HashSet<ListNode> visitedNodes = new HashSet<ListNode>();
        
        ListNode curr = head; 
        
        while (curr != null) {
            if (visitedNodes.Contains(curr)) {
                return true;
            }
            visitedNodes.Add(curr);
            curr = curr.next;
        }
        return false;         
    }
}