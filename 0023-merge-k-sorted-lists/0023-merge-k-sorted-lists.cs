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
        for (int i = 0; i < lists.Length; i++)
        {
            if (lists[i] != null)
            {
                queue.Enqueue(lists[i], lists[i].val);
            }
        }
        
        ListNode Head = null;
        ListNode tail = Head;
        while (queue.Count > 0)
        {
            
            ListNode CurrentNode = queue.Dequeue();
           // Console.WriteLine($"Cuerrent Node = {CurrentNode.val}");
            if (Head == null)
            {
                Head = new ListNode(CurrentNode.val);
                tail = Head;
            }
            else
            {
                tail.next = new ListNode(CurrentNode.val);
                tail = tail.next;
            }
            if (CurrentNode.next != null)
            {
                queue.Enqueue(CurrentNode.next, CurrentNode.next.val);
            }
            


        }
        return Head;
    }
}