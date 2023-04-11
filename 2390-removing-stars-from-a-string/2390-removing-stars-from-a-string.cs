public class Solution {
    public string RemoveStars(string s) {
        var st=  new Stack<char>();
        foreach( char c in s){
            if(c!='*' || st.Count==0) 
                st.Push(c);
            else
                st.Pop();
        }
        return string.Concat(st.ToArray().Reverse());
    }
}