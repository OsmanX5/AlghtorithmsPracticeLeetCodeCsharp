/**
 * @param {number[]} nums
 * @param {number} n
 * @return {number[]}
 */
var shuffle = function(nums, n) {
    let p=0;
    let res=[]
    let mid = n//2 +1;
    for (let i = 0; i <mid; i++) {
        res[p++] = nums[i];
        res[p++] = nums[mid+i];
    }
    return res;
};