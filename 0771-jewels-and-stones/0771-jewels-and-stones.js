/**
 * @param {string} jewels
 * @param {string} stones
 * @return {number}
 */
var numJewelsInStones = function(jewels, stones) {
    return stones.split('').reduce( (res,x) => res +  jewels.includes(x),0)  ;
};