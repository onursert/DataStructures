namespace doublyLinkedList
{
    class DoublyLinkedList
    {
        Node head;
        int count = 0;

        public DoublyLinkedList()
        {
            head = null;
        }

        public DoublyLinkedList(int inital)
        {
            head = new Node(inital);
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
            }
            else
            {
                if (position == 0)
                {
                    Node newNode = new Node(value);
                    head.prev = newNode;
                    newNode.next = head;
                    head = newNode;
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
                    //Now pointer is in previos position where we want to add newNode.
                    newNode.next = pointer.next;
                    newNode.prev = pointer;
                    //Do this only position is not equal to count. Because if position is equal to count, that means we try to add to the end of the list. So pointer.next will be null and if we try to null.prev = newNode, it gives us a error.
                    if (position != count)
                    {
                        pointer.next.prev = newNode;
                    }
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
                    //Position is 0 and count is 1, that means we try to remove first and only node of the list. So if we try to head.next.prev = null, it gives us an error because null.prev = null. Null.prev doesn't exists. So we do head.next.prev = null process only count is not 1.
                    //Other process head = head.next has to be done every remove process when position is 0. Because if count is 1 then head = head.next means head = null, if count is not 1 then head = head.next.
                    if (count != 1)
                    {
                        head.next.prev = null;
                    }
                    head = head.next;

                    //Another way. More clear.
                    /*
                    if(count == 1)
                    {
                        head = null;
                    }
                    else
                    {
                        head.next.prev = null;
                        head = head.next;
                    }*/
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
                    //We do this because first we decrease position for remove procces of last node up there. Now we check if position is equal to count or not. We check it because if position is not equal to count, that means we try to remove a node somewhere middle of the list so we must do pointer.next.prev = pointer. But if position+1 is equal to count, that means we try to remove last node so pointer.next.prev = pointer means null.prev = pointer, so this is an error.
                    position++;
                    if (position != count)
                    {
                        pointer.next.prev = pointer;
                    }
                }
                count--;
            }
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }
    }
}
