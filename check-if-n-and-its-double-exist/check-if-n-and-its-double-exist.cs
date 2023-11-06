public class Solution {
    public bool CheckIfExist(int[] arr) {
        int n = arr.Length;
        for(int i=0;i<n;i++){
            for(int j=i+1;j<n;j++)
                if(arr[i]== 2*arr[j] || arr[j] == 2* arr[i])
                    return true;
        }
        return false;
    }
}