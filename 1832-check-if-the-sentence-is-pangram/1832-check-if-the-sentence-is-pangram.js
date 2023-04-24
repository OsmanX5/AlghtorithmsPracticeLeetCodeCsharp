/**
 * @param {string} sentence
 * @return {boolean}
 */
var checkIfPangram = function(sentence) {
    const chars='abcdefghijklmnopqrstuvwxyz';
    return chars.split('').every(c =>sentence.includes(c) );
};