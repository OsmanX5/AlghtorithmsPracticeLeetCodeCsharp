/**
 * @param {number[]} nums
 * @return {number[]}
 */
var findErrorNums = function(nums) {
    let set= new Set()
    let res =[]
    //
    //
    for(let n of nums){
        if(set.has(n)) res[0]=n;
        set.add(n);
    }
    for(let i=1;i<=nums.length;i++)
        if(!set.has(i)) {
            res[1] = i;
            return res;
    }
    return res
};