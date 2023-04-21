/**
 * @param {string[]} sentences
 * @return {number}
 */
var mostWordsFound = function(sentences) {
    let max=0;
    sentences.forEach(
    s =>{
        let n = s.split(' ').length;
        max = Math.max(n,max);    
    }
    );
    return max;
};