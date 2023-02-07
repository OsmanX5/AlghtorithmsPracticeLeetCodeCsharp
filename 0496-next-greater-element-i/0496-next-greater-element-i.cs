public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int n = nums1.Length;
        int m = nums2.Length;
        int[] res = new int[n];
        for(int i=0;i<n;i++){
            int x = nums1[i];
            int start = Array.IndexOf(nums2,x);
            int grater = -1;
            for(int j=start;j<m;j++){
                if(nums2[j]>x) {grater =nums2[j]; break;}
            }
            res[i] = grater;
            
        }
        return res;
    }

}