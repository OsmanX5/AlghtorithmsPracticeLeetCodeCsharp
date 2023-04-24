/**
 * @param {number[][]} logs
 * @param {number} k
 * @return {number[]}
 */
var findingUsersActiveMinutes = function(logs, k) {
    const dict = new Map()
    for ( let log of logs){
        let id = log[0]
        let min = log[1]
        if(! (dict.has(id))) dict.set(id,[]);
        if(! (dict.get(id)).includes(min) ) dict.get(id).push(min);
    }
    console.log(dict)
    let res = new Array(k).fill(0)
    for(let [key,val] of dict )
        res[val.length-1]++ ;
    return res;
};