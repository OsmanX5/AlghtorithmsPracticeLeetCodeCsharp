public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int n = arr.Length;
        int sum =0;
        for (int length =1 ; length <= n;length+=2){
            for(int i=0;i<n-length+1;i++){
               // Console.WriteLine($"i = {i} l = {length}");
                sum += arr[i..(i+length)].Sum();
            }
        }
        return sum;
    }
}