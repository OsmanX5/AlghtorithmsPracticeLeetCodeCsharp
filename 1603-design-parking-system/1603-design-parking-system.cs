public class ParkingSystem {
    int[] Count = new int[3];
    int[] max = new int[3];
    public ParkingSystem(int big, int medium, int small) {
        max[0] =big;
        max[1] = medium;
        max[2] = small;
    }
    
    public bool AddCar(int carType) {
        if (Count[carType-1]>= max[carType-1])
        return false;
        Count[carType-1]++;
        return true;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */