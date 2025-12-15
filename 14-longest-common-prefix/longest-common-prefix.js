/**
 * @param {string[]} strs
 * @return {string}
 */
var longestCommonPrefix = function(strs) {
    let res = strs[0];
    for(let s of strs){
        let newRes=""
        for(let i=0;i<res.length;i++){
            if(res[i]==s[i])
                newRes +=res[i];
            else
                break;
        }
        res = newRes;
    }
    return res;
};