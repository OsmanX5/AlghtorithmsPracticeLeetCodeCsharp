public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] numCop = nums1[0..(m)];
        Console.WriteLine("start");
        int p1=0;
        int p2=0;
        int i=0;
        while(i < n+m){
            Console.WriteLine($"p1 = {p1},p2 = {p2} i ={i}");
            if(p1>=m) {
                nums1[i] = nums2[p2];
                p2++;
            }
            else if (p2>=n){
                nums1[i] = numCop[p1];
                p1++;
            }
            else{
                if( numCop[p1] < nums2[p2] ){
                nums1[i] = numCop[p1];
                p1++;
                }
                else{
                    nums1[i] = nums2[p2];
                    p2++;

                }
            }
            
            i++;
        }
    }
}