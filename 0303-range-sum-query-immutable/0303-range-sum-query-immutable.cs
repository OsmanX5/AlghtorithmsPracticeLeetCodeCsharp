public class NumArray {
    int[] sums;
    public NumArray(int[] nums) {
        int n =nums.Length;
        sums= new int[n];
        sums[0] = nums[0];
        for(int i=1;i<n;i++){
            sums[i] = sums[i-1]+nums[i];
        }
        
        for(int i=0;i<n;i++)Console.Write($" {nums[i] }");
        Console.WriteLine();
        for(int i=0;i<n;i++)Console.Write($" {sums[i] }");
    }
    
    public int SumRange(int left, int right) {
        int res = sums[right];
        if(left>0)
            res -= sums[left-1];
        return res;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */