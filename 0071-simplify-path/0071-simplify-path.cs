public class Solution {
    public string SimplifyPath(string path) {
        var Dirs  = path.Split('/');
        var st = new Stack<String>();
        foreach(string dir in Dirs){
            if(dir=="..")st.TryPop(out _);
            else if(dir!="" && dir!=".") st.Push(dir);
        }
        return "/"+string.Join("/",st.Reverse());
    }
}