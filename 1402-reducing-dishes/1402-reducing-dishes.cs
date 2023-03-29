public class Solution {
    public int MaxSatisfaction(int[] satisfaction) {
        Array.Sort(satisfaction);
        int n= satisfaction.Length;
        int FirstPosativeIndex =-1;
        for(int i=0;i<n;i++)
        {
            if(satisfaction[i] >=0){
                FirstPosativeIndex = i;
                break;
            }
        }
        if(FirstPosativeIndex ==-1)
            return 0;
        int[] Posatives = satisfaction[FirstPosativeIndex..];
        int Sum = Posatives.Sum();
        int Power = Posatives.Select( (x,i) => x*(i+1) ).Sum();
        
        int[] Negatives =satisfaction[0..FirstPosativeIndex];
        int m = Negatives.Length;
        for(int i =m-1;i>=0;i--){
            int Plus = Sum;
            int Minus = Negatives[i];
            int dif = Plus+Minus;
            if(dif<0) break;
            Sum += Minus;
            Power += dif;
        }
        return Power;
    }
}