public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        List<int> temp = new List<int>(flowerbed);
        temp.Add(0);
        temp.Insert(0,0);
        for(int i=1;i<temp.Count-1;i++){
            if(n<=0)return true;
            if(temp[i-1]==0 && temp[i]==0 && temp[i+1] ==0){
                temp[i]=1;
                n--;
            }
        }

        return n<=0;
    }
}