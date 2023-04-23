/**
 * @param {string} boxes
 * @return {number[]}
 */
var minOperations = function(boxes) {
    let pos =[]
    boxes.split('').forEach( 
        (val,index) => { 
            if ( val =='1' ) pos.push(index)
        }  
    );
    let res=[]
    for(let i in boxes)
        res[i] = pos.reduce((sum,x) => sum + Math.abs(x-i) ,0);
    return res;
};