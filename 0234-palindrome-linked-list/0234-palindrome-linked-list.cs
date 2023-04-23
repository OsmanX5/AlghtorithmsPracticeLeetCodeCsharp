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
    public bool IsPalindrome(ListNode head) {
        ListNode middle = FindLinkedListMiddle(head);
        ListNode head2 = length%2==0 ? middle : middle.next;
        Console.WriteLine("mid ={0}",middle.val);
        head = ReverseLinkedList(head,middle);
        ListNode temp1= head;
        ListNode temp2 =head2;
        PrintLinkedList(head);
        PrintLinkedList(head2);
        while(temp1!=null && temp2 !=null){
            if(temp1.val!=temp2.val) return false;
            temp1=temp1.next;
            temp2=temp2.next;
        }
        return true;
    }
    int length =0;
    public ListNode FindLinkedListMiddle(ListNode head) {
        if (head == null) return null;
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null) {
            length += 2;
            slow = slow.next;
            fast = fast.next.next;
        }
        if (fast != null) {
            length++;
        }
        return slow;
    }
    
    public ListNode ReverseLinkedList(ListNode head, ListNode stop) {
        ListNode prev = null;
        ListNode current = head;

        while (current != null && current != stop) {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
    public void PrintLinkedList(ListNode head) {
    ListNode current = head;
    
    while (current != null) {
        Console.Write(current.val + " ");
        current = current.next;
    }
    
    Console.WriteLine();
    }
}