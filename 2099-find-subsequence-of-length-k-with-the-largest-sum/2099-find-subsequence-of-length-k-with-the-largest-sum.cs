public class Solution {
    public int[] MaxSubsequence(int[] nums, int k) {
            int n = nums.Length;
			MaxHeap<Tuple<int,int>> heap = new MaxHeap<Tuple<int, int>>(n);
			for (int i = 0; i < n; i++)
			{
				heap.Add(new Tuple<int, int>(nums[i], i));
			}

			Tuple<int, int>[] res = new Tuple<int, int>[k];
			int lastIndex = -1;
			int resI = 0;
			while (heap.Count() > 0)
			{
				if (resI >= k) break;
				var x = heap.Pop();
				int index = x.Item2;
				int val = x.Item1;
				if (index >= lastIndex)
				{
					res[resI] = x;
					resI++;
				}
			}
			int[] res2 = (from x in res orderby x.Item2 select x.Item1).ToArray();

        return res2;
    }
}
    class MaxHeap <T> where T : IComparable
	{
		public T[] maxHeap;
        public int Capasity;
        public int lastIndex;

        public MaxHeap(int size)
        {
            Capasity = size+1;
            maxHeap = new T[Capasity];
            lastIndex = 0;
        }
        public T[] Items()
        {
	        if (lastIndex > 0)
		        return maxHeap[1..(lastIndex + 1)];
	        return null;
        }
		public void Add(T value)
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
            while (maxHeap[index].CompareTo(maxHeap[parentIndex]) >0  && index > 1)
            {
                (maxHeap[index], maxHeap[parentIndex]) = (maxHeap[parentIndex], maxHeap[index]);
                index = parentIndex;
                parentIndex = index / 2;
            }
        }
		public void AddRange(IEnumerable arr)
		{
			foreach (T x in arr)
			{
				Add(x);
			}
		}
		public T Peek() => maxHeap[1];

        public T Pop()
        {
            if (lastIndex < 1) return maxHeap[0];
            T toPop = maxHeap[1];
            maxHeap[1] = maxHeap[lastIndex];
            lastIndex--;
            int index = 1;
            while (index <= lastIndex / 2)
            {
                int leftIndex = index * 2;
                int rightIndex = index * 2 + 1;
                if (maxHeap[index].CompareTo(maxHeap[leftIndex]) < 0
                    || maxHeap[index].CompareTo(maxHeap[rightIndex]) < 0)
                {
	                if (maxHeap[leftIndex].CompareTo(maxHeap[rightIndex]) >0 )
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

        public int Count() => lastIndex;


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