/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    let dp = new Map();
    let n=prices.length;
    function sub(startIndex,min){
        const key=`${startIndex}_${min}`;
        if(dp.has(key))
            return dp.get(key)
        let i=startIndex;
        if(i>=n)
            return 0;
        while(prices[i]<=min && i<n-1){
            min = prices[i]
            i++;
        }
        const profit= prices[i]-min;
        //console.log(`local profrit for${i} = ${profit}`)
        const sellResult= profit + sub(i+1,Number.MAX_VALUE);
        const notSellResult= sub(i+1,min);
       // console.log(`Compare at ${startIndex} to sell (${sellResult}) or Not(${notSellResult})`);
        const res= Math.max(sellResult,notSellResult);
        dp.set(key,res)
        return dp.get(key);
    }
    return sub(0,Number.MAX_VALUE)
};