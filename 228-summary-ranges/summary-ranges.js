/**
 * @param {number[]} nums
 * @return {string[]}
 */
var summaryRanges = function(nums) {
    const res =[]
    let start = Number.MAX_VALUE;
    function close(start,end)  {
        let toAdd= start===end ? `${start}` : `${start}->${end}`;
        res.push(toAdd);
    } 
    for(let i=0;i<nums.length;i++){
        const current = nums[i];
        const next = nums[i+1];
        if(start===Number.MAX_VALUE)
        {
            start=nums[i]
        }
        if(next=== undefined) continue
        if(next-current >1)
        {
            close(start,current)
            start=Number.MAX_VALUE;
            continue;
        }
    }
    if(start != Number.MAX_VALUE)
        close(start,nums[nums.length-1])
    return res;
};