public class Solution {
    public double MaxAverageRatio(int[][] classes, int extraStudents) {
        	int n = classes.Length;
			PriorityQueue<ratio,double> heap = new PriorityQueue<ratio,double>(n);
			foreach (var cls in classes)
			{
				ratio temp = new ratio(cls[0], cls[1]);
				double increment = temp.RatioAfterAddOne();
				heap.Enqueue(temp,-increment);
			}

			for (int i = 0; i < extraStudents; i++)
			{
				ratio bestChoise = heap.Dequeue();
				//Console.WriteLine($"Best choise {bestChoise.x} / {bestChoise.y}");
				bestChoise.AddOne();
				ratio temp = new ratio(bestChoise.x, bestChoise.y);
				heap.Enqueue(temp,-temp.RatioAfterAddOne());
			}

			double res = 0;
			while (heap.Count > 0)
			{
				ratio next = heap.Dequeue();
				//Console.WriteLine($"add {next.x} / {next.y}");
				res += next.Ratio();
			}
			return (res/n);
    }
}
	class ratio
	{
		public int x;
		public int y;
		public ratio(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public void AddOne() {
			this.x++;
			this.y++;
		}
		public double Ratio() => (double)x / (double)(y);
		public double RatioAfterAddOne() => (double)(x + 1) / (double)(y + 1) - Ratio();
	}