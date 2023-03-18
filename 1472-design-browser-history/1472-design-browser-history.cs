public class BrowserHistory
    {
        LinkedList<string> History;
        LinkedListNode<string> CurrentBrowsingTab;
        public BrowserHistory(string homepage)
        {
            History = new LinkedList<string>();
            History.AddFirst(homepage);
            CurrentBrowsingTab = History.First;
        }

        public void Visit(string url)
        {
            History.AddAfter(CurrentBrowsingTab, url);
            CurrentBrowsingTab = CurrentBrowsingTab.Next;
            LinkedListNode<string> temp = CurrentBrowsingTab;
            while (temp.Next != null)
            {
                History.Remove(temp.Next);
            }
        }

        public string Back(int steps)
        {
            for(int i= 0; i < steps; i++)
            {
                if (CurrentBrowsingTab.Previous == null) break;
                CurrentBrowsingTab = CurrentBrowsingTab.Previous;
            }
            return CurrentBrowsingTab.Value;
        }

        public string Forward(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                if (CurrentBrowsingTab.Next == null) break;
                CurrentBrowsingTab = CurrentBrowsingTab.Next;
            }
            return CurrentBrowsingTab.Value;
        }
    }


/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */