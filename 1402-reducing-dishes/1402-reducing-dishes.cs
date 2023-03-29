public class Solution {
    public int MaxSatisfaction(int[] satisfaction) {
        Array.Sort(satisfaction);
        int n= satisfaction.Length;
        int FirstPosativeIndex =-1;
        foreach(int x in satisfaction)
            Console.Write($" {x} ");
        Console.WriteLine("");
        for(int i=0;i<n;i++)
        {
            if(satisfaction[i] >=0){
                FirstPosativeIndex = i;
                break;
            }
        }
        if(FirstPosativeIndex ==-1)
            return 0;
        Console.WriteLine($"First index = {FirstPosativeIndex}");
        int[] Posatives = satisfaction[FirstPosativeIndex..];
        int Sum = Posatives.Sum();
        int Power = Posatives.Select( (x,i) => x*(i+1) ).Sum();
        Console.WriteLine($"SUm = {Sum} pow = {Power}");
        
        int[] Negatives =satisfaction[0..FirstPosativeIndex];
        int m = Negatives.Length;
        for(int i =m-1;i>=0;i--){
            int Plus = Sum;
            int Minus = Negatives[i];
            int dif = Plus+Minus;
            if(dif<0) break;
            Console.WriteLine($"Take {Minus} because Plus = {Plus} , Minus = {Minus}");
            Sum += Minus;
            Power += dif;
        }
        return Power;
    }
}