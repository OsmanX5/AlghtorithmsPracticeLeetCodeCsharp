/**
 * @param {number[]} groupSizes
 * @return {number[][]}
 */
var groupThePeople = function(groupSizes) {
    const dict = new Map()
    for(let i in groupSizes){
        let x = groupSizes[i];
        if (!dict.has(x)) dict.set(x,[])
        dict.get(x).push(i); 
    }
    const res =[]
    dict.forEach((val,key) => {
        if( val.length == key) res.push(val);
        else for(let i=0;i<val.length; i+=key) res.push(val.slice(i, i+key));
    });
    return res;
};