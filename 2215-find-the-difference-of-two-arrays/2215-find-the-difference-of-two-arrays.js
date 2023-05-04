/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[][]}
 */
var findDifference = function(nums1, nums2) {
    let s1 = new Set(nums1);
    let s2 = new Set(nums2);
    let answer1 = []
    let answer2 =[]
    s1.forEach((x) => {if (!s2.has(x)) answer1.push(x)})
    s2.forEach((x) => {if (!s1.has(x)) answer2.push(x)})

    
    return [answer1 , answer2];
};