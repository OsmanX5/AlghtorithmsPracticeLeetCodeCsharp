/**
 * @param {number[]} nums
 * @param {number[]} index
 * @return {number[]}
 */
var createTargetArray = function(nums, index) {
    let n = index.length;
    let res =[]
    for(let i=0;i<n;i++)
        res.splice(index[i] ,0 , nums[i]);
    return res;
};