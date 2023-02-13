public class Solution {
    public bool JudgeSquareSum(int c) {
        
        for(long i=0;i<=(long) Math.Sqrt(c);i++)
        {
            //Console.WriteLine($"i = {i}");
            long l=0;
            long r=(long) Math.Sqrt(c);
            while(l<=r){
                long mid = l+(r-l)/2;
                long product = i*i + mid*mid;
               // Console.WriteLine($"l = {l} r= {r} mid = {mid} produc ={product}");
                if( product == c) return true;
                if(product>c)r=mid-1;
                else l =mid+1;
            }
        
        }
                
        
        return false;
    }
    
}