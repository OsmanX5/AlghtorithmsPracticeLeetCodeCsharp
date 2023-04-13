class ListNode
    {
        public int Val;
        public ListNode Next;
        public ListNode(int val =0, ListNode next = null)
        {
            this.Val = val;
            this.Next = next;
        }
    }
    class MyLinkedList
    {
        ListNode Head;
        ListNode Tail;
        int count;
        public MyLinkedList()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public int Get(int index)
        {
            if (index < 0 || index >= count) return -1;
            var temp = Head;
            for (int i = 0; i < index ; i++)
                temp = temp.Next;
            return temp.Val;
        }

         public void AddAtHead(int val)
        {
            count++;
            var newNode = new ListNode(val);
            if (Tail == null) Tail = newNode;
            else newNode.Next = Head;
            Head = newNode;
        }

        public void AddAtTail(int val)
        {
            count++;
            var newNode = new ListNode(val);
            if(Head == null)Head = newNode;
            else Tail.Next = newNode;
            Tail = newNode;

        }

        public void AddAtIndex(int index, int val)
        {
            if (index < 0 || index > count) return;
            if(index ==0) AddAtHead(val);
            else if(index ==count) AddAtTail(val);
            else
            {
                var newNode = new ListNode(val);
                var temp = Head;
                for (int i = 0; i < index-1; i++)
                    temp = temp.Next;
                newNode.Next = temp.Next;
                temp.Next = newNode;
                count++;
            }

        }

        public void DeletAtHead()
        {
            Head = Head.Next;
            if (Head == null) Tail = null;
            count--;
        }
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= count) return;
            if (index == 0) DeletAtHead();
            else
            {
                count--;
                var temp = Head;
                for (int i = 0; i < index - 1; i++)
                    temp = temp.Next;
                ListNode toDelet = temp.Next;
                // try to delet the tail{
                if (toDelet.Next == null)  Tail = temp;
                temp.Next = toDelet.Next;
                toDelet.Next = null;
            }
        }
    }

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */