public class Solution {
    public int GarbageCollection(string[] garbage, int[] travel) {
        int res=0,MIndex=-1,PIndex=-1,GIndex=-1;
        for(int i=0;i<garbage.Length;i++){
            res+=garbage[i].Length;
            for(int j=0;j<garbage[i].Length;j++){
                if(garbage[i][j]=='M') MIndex=i;
                else if(garbage[i][j]=='P') PIndex=i;
                else GIndex=i;
            }
        }
        for(int i=0;i<travel.Length;i++){
            if(i<MIndex) res+=travel[i];
            if(i<PIndex) res+=travel[i];
            if(i<GIndex) res+=travel[i];
        }
        return res;
    }
}