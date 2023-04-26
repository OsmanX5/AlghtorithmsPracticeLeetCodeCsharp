/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {number[]} nums
 * @return {TreeNode}
 */
var constructMaximumBinaryTree = function(nums) {
    if (nums.length ==0) return null;
    let max = nums.reduce( (res,x) => Math.max(res,x));
    let index = nums.indexOf(max);
    let left = nums.slice(0,index);
    let right =nums.slice(index+1 );    
    let root = new TreeNode(max);
    root.left = constructMaximumBinaryTree(left);
    root.right = constructMaximumBinaryTree(right);
    return root;
};