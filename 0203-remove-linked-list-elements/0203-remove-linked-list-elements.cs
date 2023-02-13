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
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode temp = head;
        ListNode prev = null;
        while(temp!=null){
            if(temp.val == val){
                if(prev == null) {
                    head = temp.next;
                    temp = temp.next;  
                    continue;
                }
                Console.WriteLine($"founded prev = {prev.val} temp = {temp.val}");
                prev.next = temp.next;
                temp = temp.next;  
                continue;
            }
            prev = temp;
            temp = temp.next;   
        }
        return head;
    }
}