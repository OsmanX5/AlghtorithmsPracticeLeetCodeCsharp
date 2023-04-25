/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var mergeNodes = function(head) {
    let res =[]
    let temp = head;
    let sum =0;
    while(temp!= null){
        sum+= +temp.val;
        if(temp.val==0 && sum!=0) {
            res.push(sum);
            sum=0;
        }
        temp = temp.next;
    }
    let newHead = new ListNode(0);
    temp = newHead;
    for(let x of res){
        temp.next = new ListNode(x);
        temp = temp.next;
    }
    return newHead.next;
};