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
    public ListNode MiddleNode(ListNode head) {
        ListNode slow= head;
        ListNode fast = head;
        while(fast!=null){
            Console.WriteLine(fast.val);
            if(fast.next == null )break;
            slow = slow.next;
            if(fast.next.next == null) break;
            
            fast = fast.next.next;
            
        }
        return slow;
    }
}