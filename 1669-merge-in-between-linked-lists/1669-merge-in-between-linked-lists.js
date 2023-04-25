/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} list1
 * @param {number} a
 * @param {number} b
 * @param {ListNode} list2
 * @return {ListNode}
 */
var mergeInBetween = function(list1, a, b, list2) {
    let i=1;
    let temp = list1
    let start;
    while(i<=b) {
        if(i == a)start = temp;
        temp = temp.next;
        i+=1;
    }
    start.next = list2;
    let tail2= list2;
    while(tail2.next!=null)tail2=tail2.next;
    tail2.next = temp.next;
    return list1;
    
};