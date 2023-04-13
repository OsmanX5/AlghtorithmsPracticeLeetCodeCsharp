class listNode:
    def __init__(self, val=0):
        self.val = val;
        self.next = None;

class MyLinkedList:
    def __init__(self):
        self.head = None
        self.tail = None
        self.length = 0;

    def addAtHead(self, val: int) -> None:
        self.length += 1;
        temp = listNode(val)
        if(self.head is None):
            self.head = temp;
            self.tail = temp;
            return
        temp.next = self.head
        self.head = temp

    def addAtTail(self, val: int) -> None:

        self.length += 1;
        temp = listNode(val)
        if(self.head is None):
            self.head = temp;
            self.tail = temp;
            return ;
        self.tail.next = temp;
        self.tail = temp;
    def get(self, index: int) -> int:
        if index<0 or index>=self.length:
            return -1
        temp = self.head
        for _ in range(index):
            temp = temp.next
        return temp.val;
    def addAtIndex(self, index: int, val: int) -> None:
        if index <0 or index > self.length:
            return ;
        if index==0:
            self.addAtHead(val);
            return
        if index==self.length:
            self.addAtTail(val);
            return
        newNode = listNode(val)
        temp = self.head
        for _ in range(index-1):
            temp = temp.next
        newNode.next = temp.next;
        temp.next = newNode;
        self.length+=1
    def deleteAtIndex(self, index: int) -> None:
        if index <0 or index >= self.length:
            return
        self.length -= 1;
        if(index == 0):
            temp = self.head
            self.head = self.head.next
            temp= None
            return
        temp = self.head
        for _ in range(index-1):
            temp = temp.next
        
        current = temp.next
        if (current.next == None) : 
            self.tail = temp;
        temp.next = current.next
        current.next = None


# Your MyLinkedList object will be instantiated and called as such:
# obj = MyLinkedList()
# param_1 = obj.get(index)
# obj.addAtHead(val)
# obj.addAtTail(val)
# obj.addAtIndex(index,val)
# obj.deleteAtIndex(index)