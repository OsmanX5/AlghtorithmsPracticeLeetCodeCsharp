public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new(); 
        for(int i=0;i<s.Length;i++){
            char c = s[i];
            
            if(IsOpen(c)){
                st.Push(c);
            }
            else{
                if(st.Count>0 &&  st.Peek() == pair(c))st.Pop();
                else return false;
            }
            
        }
        return st.Count==0;
        
    }
    public char pair(char c){
        if (c == ')') return '(';
        if (c == ']') return '[';
        if (c == '}') return '{';
        return 'x';
    }
    public bool IsOpen(char c){
        if (c == '(') return true;
        if (c == '[') return true;
        if (c == '{') return true;
        return false;
    }
}