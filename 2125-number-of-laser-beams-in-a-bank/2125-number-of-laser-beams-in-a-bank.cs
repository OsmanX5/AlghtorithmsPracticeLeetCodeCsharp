public class Solution {
    public int NumberOfBeams(string[] bank) {
        int rows = bank.Length;
        int lastRowDevicesCount =0;
        int res=0;
        for(int i=0 ;i <rows;i++){
            int devicesAtRowCount = bank[i].Select(x => x).Where(c => c == '1').Count();
            if(devicesAtRowCount ==0)
                continue;
            res += lastRowDevicesCount * devicesAtRowCount;
            lastRowDevicesCount = devicesAtRowCount;
        }
        return res;
    }
}