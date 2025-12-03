/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function(nums) {
    const n= nums.length;
    for(let i=0;i<n-2;i++){
        let current = nums[i];
        let next = nums[i+1];
        let afterNext = nums[i+2];
        if(current!=next && current!=afterNext){
            continue;
        }
        let count=0;
        for(let j=i+2;j<n;j++){
            if(nums[j] != current)
                break;
            count++;

        }
        //console.log(`cut from${startSpliceIndex} to ${startSpliceIndex+count}`)
        nums.splice(i+2,count)
    }
};