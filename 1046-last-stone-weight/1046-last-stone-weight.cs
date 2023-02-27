public class Solution {
    public int LastStoneWeight(int[] stones) {
        	int[] nums =stones;
			int n = nums.Length;
			MaxHeap heap = new MaxHeap(n);
			heap.AddRange(nums);
			while (heap.lastIndex >1)
			{
				int x1 = heap.Pop();
				int x2 = heap.Pop();
				if(x1!=x2)heap.Add(Math.Abs(x1-x2));
				//Console.WriteLine(heap.ToString());
			}

			return heap.Peek();
    }
}






 class MaxHeap
    {
        public int[] maxHeap;
        public int Capasity;
        public int lastIndex;

        public MaxHeap(int size)
        {
            Capasity = size+1;
            maxHeap = new int[Capasity];
            lastIndex = 0;

        }
        public int[] Items()
        {
	        if (lastIndex > 0)
		        return maxHeap[1..(lastIndex + 1)];
	        return null;
        }
		public void Add(int value)
        {
            lastIndex++;
            if (lastIndex >= Capasity)
            {
                lastIndex--;
                Console.WriteLine("over flow");
                return;
            }
            maxHeap[lastIndex] = value;
            int index = lastIndex;
            int parentIndex = index / 2;
            while (maxHeap[index] > maxHeap[parentIndex] && index > 1)
            {
                (maxHeap[index], maxHeap[parentIndex]) = (maxHeap[parentIndex], maxHeap[index]);
                index = parentIndex;
                parentIndex = index / 2;
            }
        }
		public void AddRange(IEnumerable arr)
		{
			foreach (int x in arr)
			{
				Add(x);
			}
		}
		public int Peek() => lastIndex>=1 ? maxHeap[1] : 0;

        public int Pop()
        {
            if (lastIndex < 1) return int.MinValue;
            int toPop = maxHeap[1];
            maxHeap[1] = maxHeap[lastIndex];
            lastIndex--;
            int index = 1;
            while (index <= lastIndex / 2)
            {
                int leftIndex = index * 2;
                int rightIndex = index * 2 + 1;
                if (maxHeap[index] < maxHeap[leftIndex] || maxHeap[index] < maxHeap[rightIndex])
                {
	                if (maxHeap[leftIndex] > maxHeap[rightIndex])
	                {
		                (maxHeap[leftIndex], maxHeap[index]) = (maxHeap[index], maxHeap[leftIndex]);
		                index = leftIndex;
	                }
	                else
	                {
		                (maxHeap[rightIndex], maxHeap[index]) = (maxHeap[index], maxHeap[rightIndex]);
		                index = rightIndex;
	                }
                }
                else { break; }
			}

            return toPop;
        }

        public int Size() => lastIndex;


        public override string ToString()
        {
	        string s = "\n [ ";
	        for (int i = 1; i <= lastIndex; i++)
	        {
		        s += $" {maxHeap[i]} ";
	        }

	        s += "] \n";
	        return s;
        }

	}