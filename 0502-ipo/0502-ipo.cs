public class Solution 
{
    private struct Project : IComparable
    {
        public int m_profit;
        public int m_capital;
        public Project(int profit, int capital)
        {
            m_profit = profit;
            m_capital = capital;
        }
        public int CompareTo(object project) 
        {
            return m_capital - ((Project)project).m_capital;
        }
    }

    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) 
    {
        Project[] projects = new Project[profits.Length];
        for(int i = 0; i < projects.Length; ++i)
        {
            projects[i] = new Project(profits[i], capital[i]);
        }
        Array.Sort(projects);
        PriorityQueue<int, int> pQueue = new();
        int p = 0;
        while(k > 0)
        {
            while (p < profits.Length && w >= projects[p].m_capital) 
            {
                pQueue.Enqueue(projects[p].m_profit, -projects[p].m_profit);
                ++p;
            }
            if (pQueue.Count == 0) return w;
            w += pQueue.Dequeue();
            --k;
        }
        return w;
    }
}