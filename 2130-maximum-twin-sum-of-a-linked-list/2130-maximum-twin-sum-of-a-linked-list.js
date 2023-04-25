/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {number}
 */
var pairSum = function(head) {
    let arr=[]
    let temp = head;
    while(temp!=null){
        arr.push(temp.val);
        temp= temp.next;
    }
    let n = arr.length;
    let res=0;
    for (let i =0;i<n/2;i++)
        res = Math.max(res,arr[i] + arr[n-1-i]);
    return res;
};