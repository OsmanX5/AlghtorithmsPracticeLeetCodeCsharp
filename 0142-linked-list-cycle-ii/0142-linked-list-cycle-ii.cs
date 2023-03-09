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
        HashSet<ListNode> visited = new();
        ListNode temp = head;
        while(temp!=null){
            if(visited.Contains(temp)) return temp;
            visited.Add(temp);
            temp = temp.next;
        }
        return null;
    }
}