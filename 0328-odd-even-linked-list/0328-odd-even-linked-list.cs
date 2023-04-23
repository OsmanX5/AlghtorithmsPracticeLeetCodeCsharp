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
    public ListNode OddEvenList(ListNode head) {
        if(head==null)return head;
        ListNode firstEven = head.next;
        ListNode LastOdd = null;
        ListNode temp = head;
        while(temp!=null){
            ListNode oddNode = temp;
            ListNode EvenNode = temp.next;
            if(EvenNode == null){
                LastOdd = oddNode;
                break;
            }
            ListNode NextOdd = EvenNode.next;
            if(NextOdd==null){
                LastOdd = oddNode;
                break;
            }
            oddNode.next = NextOdd;
            ListNode NextEven = NextOdd.next;
            EvenNode.next = NextEven;
            temp = NextOdd;
            
        }
        LastOdd.next = firstEven;
        return head;
    }
}