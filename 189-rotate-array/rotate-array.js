/**
 * @param {number[]} nums
 * @param {number} k
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var rotate = function(nums, k) {
    k = k %nums.length;
    const cut = nums.slice(nums.length-k,nums.length);
    const first = nums.slice(0,nums.length-k);
    for(let i=0;i<nums.length;i++)
    {
        if(i<cut.length)
            nums[i] = cut[i];
        else
            nums[i] = first[i-cut.length]
    }
};