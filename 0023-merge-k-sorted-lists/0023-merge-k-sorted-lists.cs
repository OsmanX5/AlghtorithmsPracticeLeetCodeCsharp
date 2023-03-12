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
    public ListNode MergeKLists(ListNode[] lists) {
        PriorityQueue<ListNode,int> queue = new PriorityQueue<ListNode,int>();
        foreach(ListNode list in lists)
            if(list!=null)
                queue.Enqueue(list, list.val);
        
        ListNode Head = new ListNode();
        ListNode tail = Head;
        ListNode CurrentNode;
        while (queue.Count > 0)
        {
            CurrentNode = queue.Dequeue();
            tail.next = new ListNode(CurrentNode.val);
            tail = tail.next;
            if (CurrentNode.next != null)
                queue.Enqueue(CurrentNode.next, CurrentNode.next.val);

        }
        return Head.next;
    }
}