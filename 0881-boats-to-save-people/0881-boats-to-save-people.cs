public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        Array.Reverse(people);
        int n = people.Length;
        int p1=0;
        int p2=n-1;
        int res=0;
        while(p1<=p2){
            int w1 = people[p1];
            int w2 = people[p2];
            //Console.WriteLine("w1 = {0} w2 = {1}" , w1,w2);
            if(w1+w2> limit){
                p1++;
            //    Console.WriteLine("Just take p1");
            }
            else{
                p1++;
                p2--;
              //  Console.WriteLine("Just take both");
            }
            res+=1;
          //  Console.WriteLine("End with p1 = {0} and p2 = {1} and res = {2}",p1,p2,res);

        }
        return res;
        
    }
}