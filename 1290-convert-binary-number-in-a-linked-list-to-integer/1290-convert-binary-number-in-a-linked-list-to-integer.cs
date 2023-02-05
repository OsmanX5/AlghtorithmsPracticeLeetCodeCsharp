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
    public int GetDecimalValue(ListNode head) {
        string s  ="";
        ListNode temp = head;
        while(temp!=null){
            s+= temp.val.ToString();
            temp = temp.next;
        }
        return Convert.ToInt32(s,2);
    }
}