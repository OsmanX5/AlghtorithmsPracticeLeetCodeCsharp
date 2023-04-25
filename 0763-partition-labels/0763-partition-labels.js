/**
 * @param {string} s
 * @return {number[]}
 */
var partitionLabels = function(s) {
    let dict = new Map()
    for(let i in s){
        dict.set(s[i],i);
    }
    let CurrentIndex = 0;
    let n = +s.length;
    let res =[]
    let MaxIndex =1;
    while(CurrentIndex<n){
        let startIndext = CurrentIndex;
        MaxIndex = dict.get(s[CurrentIndex]);
        //console.log("start a loop with ",startIndext);
        while(CurrentIndex<MaxIndex){
            let ThisCharMaxIndex = dict.get(s[CurrentIndex]);
            MaxIndex = Math.max( MaxIndex , ThisCharMaxIndex );
           // console.log(`now ${s[CurrentIndex]} and it is in ${ThisCharIndexes} so max Index = ${MaxIndex}`);
            CurrentIndex++;
        }
        res.push(MaxIndex-startIndext+1);
        CurrentIndex+=1;
}
    return res;
};