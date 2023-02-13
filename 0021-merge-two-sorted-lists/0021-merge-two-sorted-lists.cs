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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode res = null;
        ListNode last = null;
        ListNode p1 = list1;
        ListNode p2 = list2;
        while(p1!=null || p2!=null){
            ListNode temp =null;
            
            if(p1 == null){
                temp = new ListNode(p2.val);
                p2 = p2.next;
            }
            else if (p2 == null){
                temp = new ListNode(p1.val);
                p1 = p1.next;
            }
            else{
                if(p1.val <= p2.val){
                    temp = new ListNode(p1.val);
                    p1 = p1.next;
                }
                else{
                    temp = new ListNode(p2.val);
                    p2 = p2.next;
                }
            }
            if(res == null) {res = temp;last = res;}
            else {
                last.next = temp;
                last = last.next; 
            }


        }
                return res;
    }
}