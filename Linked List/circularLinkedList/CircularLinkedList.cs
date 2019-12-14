namespace circularLinkedList
{
    class CircularLinkedList
    {
        Node head;
        Node tail;
        int count = 0;

        public CircularLinkedList()
        {
            head = null;
            tail = null;
        }

        public CircularLinkedList(int inital)
        {
            head = new Node(inital);
            head.next = head;
            tail = head;
            count++;
        }

        public void Add(int value, int position)
        {
            if (position > count)
            {
                position = count;
            }
            else if (position < 0)
            {
                position = 0;
            }

            if (head == null)
            {
                head = new Node(value);
                head.next = head;
                tail = head;
            }
            else
            {
                if (position == 0)
                {
                    Node newNode = new Node(value);
                    newNode.next = head;
                    tail.next = newNode;
                    head = newNode;
                }
                else if (position == count)
                {
                    Node newNode = new Node(value);
                    newNode.next = head;
                    tail.next = newNode;
                    tail = newNode;
                }
                else
                {
                    Node pointer = head;
                    int currentPosition = 1;
                    while (currentPosition != position)
                    {
                        pointer = pointer.next;
                        currentPosition++;
                    }
                    Node newNode = new Node(value);
                    newNode.next = pointer.next;
                    pointer.next = newNode;
                }
            }
            count++;
        }

        public void Add(int value)
        {
            Add(value, count);
        }

        public void Remove(int position)
        {
            if (position >= count)
            {
                position = count;
                position--;
            }
            else if (position < 0)
            {
                position = 0;
            }

            if (head != null)
            {
                if (position == 0)
                {
                    if(count == 1)
                    {
                        head = null;
                        tail = null;
                    }
                    else
                    {
                        tail.next = head.next;
                        head = head.next;
                    }
                }
                else
                {
                    Node pointer = head;
                    int currentPosition = 1;
                    while (currentPosition != position)
                    {
                        pointer = pointer.next;
                        currentPosition++;
                    }
                    pointer.next = pointer.next.next;
                    //If we want to remove last node, we have to do this because we decreased position if is greater than count or equal to count.
                    position++;
                    if (position == count)
                    {
                        tail = pointer;
                    }
                }
                count--;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
    }
}
