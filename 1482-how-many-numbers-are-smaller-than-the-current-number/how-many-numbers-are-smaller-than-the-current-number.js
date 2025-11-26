/**
 * @param {number[]} nums
 * @return {number[]}
 */
var smallerNumbersThanCurrent = function(nums) {
    let sorted = nums.toSorted( (x,y)=> x-y);
    let map = new Map()
    for(let i=0;i<sorted.length;i++){
        let num = sorted[i]
        if(map.has(num))
            continue;
        else
            map.set(num,i)
    }
    //console.log(map)
    return nums.map(num => map.get(num));
};