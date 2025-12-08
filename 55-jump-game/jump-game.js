/**
 * @param {number[]} nums
 * @return {boolean}
 */
var canJump = function(nums) {
    const n = nums.length;
    let dp = new Map();
    function jump(start){
        if(dp.has(start))
            return dp.get(start);
        
        if(start ==n-1){
            dp.set(start,true);
            return true;
        }
        if( start>=n){
            dp.set(start,false);
            return false;
        }
        const val = nums[start];
        for(let i=1;i<=val;i++){
            if(jump(start+i) ==true){
                dp.set(start,true)
                return true;
            }
        }
        dp.set(start,false)
        return false;
    }
    return jump(0);
};