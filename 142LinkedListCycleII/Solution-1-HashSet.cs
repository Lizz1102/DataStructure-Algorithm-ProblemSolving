public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if (head == null) {
            return null;
        } 
        
        HashSet<ListNode> visitedNodes = new HashSet<ListNode>();
        
        ListNode curr = head;
        
        while (curr != null) {
            if (visitedNodes.Contains(curr)) {
                return curr;
            }
            visitedNodes.Add(curr);
            curr = curr.next;
        }
        return null;
    }
}