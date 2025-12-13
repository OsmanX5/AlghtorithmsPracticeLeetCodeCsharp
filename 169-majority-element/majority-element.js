/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
    let res = nums[0];
    let counts=new Map();
    nums.forEach(x => {
        if(counts.has(x))
            counts.set(x,counts.get(x)+1)
        else
            counts.set(x,1)
        res = counts.get(res) >counts.get(x)? res : x
       // console.log(res)
    })
    return res;
};