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
    public ListNode ReverseList(ListNode head) {
        
        return helper(head,null);
    }
    public ListNode helper(ListNode x,ListNode parent){ 
        if(x==null) return null;
        if(x.next==null){
            x.next = parent;
            return x;
        }
        
        ListNode theNext = new ListNode(x.next.val,x.next.next);
        x.next = parent;
        return helper(theNext,x);
    }
}