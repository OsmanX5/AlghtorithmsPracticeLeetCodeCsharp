public class SmallestInfiniteSet {
    HashSet<int> nums; 
    public SmallestInfiniteSet() {
       nums = new HashSet<int>();
        for(int i =1;i<=1000;i++)nums.Add(i);
    }
    
    public int PopSmallest() {
        int x = nums.Min();
        nums.Remove(x);
        return x;
    }
    
    public void AddBack(int num) {
     nums.Add(num);   
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */