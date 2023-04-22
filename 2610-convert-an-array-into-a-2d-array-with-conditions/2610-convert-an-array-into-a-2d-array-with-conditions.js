/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var findMatrix = function(nums) {
    let res =[[]]
    nums.forEach(
        (num) => {
        for(let i=0;i<res.length;i++)
            if(!res[i].includes(num)){
                res[i].push(num);
                return;
            }
        res.push([num])
        }
    );
    return res;
    };