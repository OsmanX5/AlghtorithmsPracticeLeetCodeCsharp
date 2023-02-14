public class Solution {
    public int MaxDistance(int[] nums1, int[] nums2) {
        int n =nums1.Length;
        int m = nums2.Length;
        int maxDistance = 0;
        for(int i=0;i<n && i <m;i++){
            int j = IndexOfLastGrater(nums1[i],i,nums2);
           // Console.WriteLine($"j = {j}");
            if(j<0) continue;
            maxDistance =(int) Math.Max(maxDistance , j-i);
            
        }
        return maxDistance;
    }

    public int IndexOfLastGrater(int minVal,int i,int[] nums2){
       // Console.WriteLine($"search for next of {minVal}");
        int m =nums2.Length;
        int l =i;
        int r= m-1;
        while(l<r){
            int mid = l + (r-l)/2;
            //Console.WriteLine($"l ={l} r = {r} mid = {mid}");
            int x = nums2[mid];
            int next = nums2[mid+1];
            if(x >= minVal && next < minVal) return mid;
            if(next >= minVal) l = mid+1;
            if(x <minVal) r = mid; 
        }

        if( nums2[l]>=minVal) return l; 
        return -1;
            
    }


}