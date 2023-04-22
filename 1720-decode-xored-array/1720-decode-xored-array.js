/**
 * @param {number[]} encoded
 * @param {number} first
 * @return {number[]}
 */
var decode = function(encoded, first) {
    let res= [first];
    encoded.forEach(x => res.push(res[res.length-1] ^ x));
    return res;
};