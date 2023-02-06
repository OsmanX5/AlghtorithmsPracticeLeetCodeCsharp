public class MyQueue {
    Stack<int> temp = new();
    Stack<int> final = new();
    public MyQueue() {
        temp = new();
        final = new();
    }
    
    public void Push(int x) {
        MoveToTemp();
        final.Push(x);
        MoveToFinal();
    }
    
    public int Pop() {
        return final.Pop();
    }
    
    public int Peek() {
        return final.Peek();
    }
    
    public bool Empty() {
        return final.Count ==0;
    }
    public void MoveToTemp(){
        while(final.Count>0){
            int x = final.Pop();
            temp.Push(x);
        }
    }
    public void MoveToFinal(){
        while(temp.Count>0){
            int x = temp.Pop();
            final.Push(x);
        }
    }
    
    
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */