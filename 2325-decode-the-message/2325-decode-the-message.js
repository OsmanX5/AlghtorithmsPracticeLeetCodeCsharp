/**
 * @param {string} key
 * @param {string} message
 * @return {string}
 */
var decodeMessage = function(key, message) {
    let dict= {}
    let val ='a'.charCodeAt(0);
    for(let i in key){
        if(val>'z') break;
        if (key[i] == ' ' || key[i] in dict) continue;
        dict[key[i]] = String.fromCharCode(val++);
    }
    let res=[]
    for(let i in message) res[i] = message[i] == ' ' ? ' ' : dict[message[i]];
    return res.join("");
};