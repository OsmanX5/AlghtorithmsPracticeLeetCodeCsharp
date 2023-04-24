/**
 * @param {number[]} stones
 * @return {number}
 */
var lastStoneWeight = function(stones) {
    let y,x;
    while(stones.length>1){
        stones = stones.sort( (a,b) => a-b)
        y = stones.pop();
        x = stones.pop();
        if(y!=x) stones.push(y-x); 
    }
    return  (typeof stones[0] !== "undefined") ? stones[0] : 0;
};