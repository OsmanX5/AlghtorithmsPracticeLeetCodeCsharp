/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    let min=Number.MAX_VALUE;
    let res=0;
    prices.forEach(x =>{
        if(x<min)
            min =x;
        else
            res = Math.max(res,x-min);
    });
    return res;
};