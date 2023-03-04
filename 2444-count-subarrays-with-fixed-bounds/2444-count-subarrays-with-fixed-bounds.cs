public class Solution {
    public long CountSubarrays(int[] nums, int minK, int maxK) {
        List<int[]> arrays = CutArrays(nums,minK,maxK);
        long res=0;
        foreach(int[] arr in arrays){
           // Console.Write("arr :");
            //foreach(int x in arr) Console.Write($" {x} ");
            if(arr.Length>0)
                res += GetSub(arr,minK,maxK);
           // Console.WriteLine("");
        }
        return res;

    }
    List<int[]> CutArrays(int[] nums, int minK, int maxK){
        List<int[]> arrays = new List<int[]>();
        int n= nums.Length;
        int p=0;
        int[] arr;
        for(int i=0;i<n;i++){
            if((nums[i]>maxK || nums[i]< minK)){
                arr = nums[p..i];
                p=i+1;
                if(arr.Length <1)continue;
                if(arr.Min()> minK || arr.Max()<maxK) continue;
                else arrays.Add(arr);
                
            }
        }
        arr = nums[p..n];
        if(arr.Length >=1 && (arr.Min()> minK || arr.Max()<maxK));
        else arrays.Add(arr);
        return arrays;
    }
    
    long GetSub(int[] nums,int minK,int maxK){
        long ans = 0;
        int n = nums.Length;
        int LastMinIndex=-1;
        int LastMaxIndex=-1;
        int last;
        for(int i=0;i<n;i++){
            if(nums[i] == minK) LastMinIndex=i;
            if(nums[i] == maxK) LastMaxIndex =i;
            last = Math.Min(LastMinIndex,LastMaxIndex) +1;
            //Console.WriteLine($" i ={i} nums[i] = {nums[i]} LastMinIndex ={LastMinIndex} last max = {LastMaxIndex} last = {last}");
            if(last>0) ans+=last;
        }
        return ans;
    }
}