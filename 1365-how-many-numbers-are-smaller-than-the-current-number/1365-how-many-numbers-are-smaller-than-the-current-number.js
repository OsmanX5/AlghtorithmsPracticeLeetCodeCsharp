/**
 * @param {number[]} nums
 * @return {number[]}
 */
var smallerNumbersThanCurrent = function(nums) {
    let res =[];
    for (let i = 0; i < nums.length; i++) {
        const current = nums[i];
        res[i] = nums.filter(x => x<current).length;
    }
    return res;
};