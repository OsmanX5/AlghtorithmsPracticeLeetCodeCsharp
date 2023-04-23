/**
 * @param {string} s
 * @return {number}
 */
var balancedStringSplit = function(s) {
    let res=0;
    let lCount =0;
    let rCount =0;
    s.split('').forEach(
        c =>{
            if(c=='L') lCount++;
            else rCount++;
            if(lCount==rCount){
                lCount=0;
                rCount=0;
                res+=1;
            }
        }
    );
    return res;
};