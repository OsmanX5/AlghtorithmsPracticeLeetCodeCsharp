/**
 * @param {string} n
 * @return {number}
 */
var minPartitions = function(n) {
    return n.split('').reduce((res,c) =>  Math.max(res,c));
};