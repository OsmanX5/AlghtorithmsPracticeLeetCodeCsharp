/**
 * @param {number[]} nums
 * @return {number}
 */
var arraySign = function(nums) {
    let p = nums.reduce( (res,x) => res*x ,1) 
    if(p>0) return 1;
    else if(p<0) return -1;
    return 0;
};