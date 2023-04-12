public class Solution {
    public string SimplifyPath(string path) {
        var Dirs  = path.Split('/');
        var st = new Stack<String>();
        foreach(string dir in Dirs){
            switch (dir) {
                case "":
                case ".": break;
                case "..":st.TryPop(out _);break;
                default: st.Push(dir);break;
            }
        }
        return "/"+string.Join("/",st.Reverse());
    }
}