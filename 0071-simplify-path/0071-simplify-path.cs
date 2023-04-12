public class Solution {
    public string SimplifyPath(string path) {
        var Dirs  = path.Split('/');
        var st = new Stack<String>();
        foreach(string dir in Dirs){
            Console.WriteLine(dir);
            if(string.IsNullOrEmpty(dir)|| dir ==".") 
                continue;
            if(dir ==".." ){
                if(st.Count > 0)st.Pop();
                continue;
            }
            st.Push(dir);
        }
        return "/"+string.Join("/",st.Reverse());
    }
}