/**
 * @param {string} pattern
 * @param {string} s
 * @return {boolean}
 */
var wordPattern = function(pattern, s) {
    let patDict = new Map();
    let words = s.split(" ");
    if(words.length!=pattern.length){
        //console.log('here 3')
        return false;
    }
    for(let i=0;i<pattern.length;i++)
    {
        let p = pattern[i];
        let word = words[i]
        if(patDict.has(p) && patDict.get(p) != word)
            return false;
        else{
            for(let [key, value] of patDict){
                if(key !=p && value ==word){
                    //console.log('here2')
                    return false;
                }
            }
            patDict.set(p,word)
        }
    }

    return true
};