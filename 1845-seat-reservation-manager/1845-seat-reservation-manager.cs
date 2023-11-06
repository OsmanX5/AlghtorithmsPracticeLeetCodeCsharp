public class SeatManager {
    PriorityQueue<int,int> seats;
    public SeatManager(int n) {
        seats = new  PriorityQueue<int,int>();
        for(int i=1;i<=n;i++)seats.Enqueue(i,i);
    }
    
    public int Reserve() {
        return seats.Dequeue();
    }
    
    public void Unreserve(int seatNumber) {
        seats.Enqueue(seatNumber,seatNumber);
    }
}

/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager obj = new SeatManager(n);
 * int param_1 = obj.Reserve();
 * obj.Unreserve(seatNumber);
 */