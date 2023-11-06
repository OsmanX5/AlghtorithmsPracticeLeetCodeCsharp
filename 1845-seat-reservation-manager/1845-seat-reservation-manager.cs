public class SeatManager {
    PriorityQueue<int,int> seats = new  PriorityQueue<int,int>();
    public SeatManager(int n) {
        for(int i=1;i<=n;i++) seats.Enqueue(i,i);
    }
    public int Reserve() => seats.Dequeue();
    public void Unreserve(int x) => seats.Enqueue(x,x);
    
}

/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager obj = new SeatManager(n);
 * int param_1 = obj.Reserve();
 * obj.Unreserve(seatNumber);
 */