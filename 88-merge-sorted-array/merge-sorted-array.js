/**
 * @param {number[]} nums1
 * @param {number} m
 * @param {number[]} nums2
 * @param {number} n
 * @return {void} Do not return anything, modify nums1 in-place instead.
 */
var merge = function(nums1, m, nums2, n) {
        let p2 = n-1;
        let p1 = m-1;
        for(let i= n+m-1; i>=0 ;i--){
            let res;
            if(p1<0) res = nums2[p2--];
            else if (p2<0) res = nums1[p1--];
            else res = nums1[p1] > nums2[p2] ? nums1[p1--] : nums2[p2--];
            nums1[i] = res;
        }
};