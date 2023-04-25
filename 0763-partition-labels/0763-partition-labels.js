/**
 * @param {string} s
 * @return {number[]}
 */
var partitionLabels = function(s) {
    let dict = new Map()
    for(let i in s) dict.set(s[i],i);
    let CurrentIndex = 0;
    let res =[]
    while(CurrentIndex<+s.length){
        let startIndext = CurrentIndex;
        let MaxIndex = dict.get(s[CurrentIndex]);
        while(CurrentIndex<MaxIndex)
            MaxIndex = Math.max( MaxIndex , dict.get(s[CurrentIndex++]) );
        res.push(MaxIndex-startIndext+1);
        CurrentIndex+=1;
    }
    return res;
};