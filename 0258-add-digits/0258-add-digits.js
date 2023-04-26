/**
 * @param {number} num
 * @return {number}
 */
var addDigits = function(num) {
    let temp =`${num}`;
    while(temp.length > 1){
        let sum =0;
        temp.split('').forEach(x => sum += +x);
        temp = `${sum}`;
        console.log(sum);
    }
    return +temp;
};