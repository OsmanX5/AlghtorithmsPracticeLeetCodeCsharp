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
    ListNode Head;
    int N;
    public Solution(ListNode head) {
        Head = head;
        ListNode temp = head;
        N=0;
        while(temp!=null){
            temp = temp.next;
            N++;
        }
    }
    
    public int GetRandom() {
        int index =new Random().Next(N);
        int res = Get(index);
        return res;
    }
    public int Get(int index){
        ListNode temp = Head;
        int count =0;
        while(count < index){
            temp = temp.next;
            count++;
        }
        return temp.val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */