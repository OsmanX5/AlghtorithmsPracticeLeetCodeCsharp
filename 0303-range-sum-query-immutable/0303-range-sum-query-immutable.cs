public class NumArray {
    int[] arr;
    public NumArray(int[] nums) {
        arr= nums;
    }
    
    public int SumRange(int left, int right) {
        return arr[left..(right+1)].Sum();
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */