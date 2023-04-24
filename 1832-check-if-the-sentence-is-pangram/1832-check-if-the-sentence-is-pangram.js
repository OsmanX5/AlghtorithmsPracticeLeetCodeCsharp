/**
 * @param {string} sentence
 * @return {boolean}
 */
var checkIfPangram = function(sentence) {
    const dict =new Map()
    sentence.split('').forEach(
    c => {
        if (!(dict.has(c))) dict.set(c,1);
    }
    );
    return dict.size == 26;
};