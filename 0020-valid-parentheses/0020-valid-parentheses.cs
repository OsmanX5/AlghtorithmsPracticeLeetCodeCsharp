public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        foreach(char c in s){
            if(isOpen(c)){
                stack.Push(c);
                continue;
            }
            if((stack.Count==0) ||(c != CloseType(stack.Pop())))
                return false;

        }
        return stack.Count==0;
    }
    bool isOpen(char c)=> c=='{' || c=='[' || c=='(';
    char CloseType(char c)
    {
        if(c=='[') return ']';
        if(c=='{') return '}';
        return ')';
    }
}