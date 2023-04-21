/**
 * @param {number[]} nums
 * @return {number[]}
 */
var leftRigthDifference = function(nums) {
    let sum = nums.reduce( (sum,x) => sum+x );
    let right = sum;
    let left =0;
    let res = []
    for (let i = 0; i < nums.length; i++) {
        const x = nums[i];
        right -= x;
        res[i] = Math.abs(left-right);
        left+=x;
    }
    return res;
};