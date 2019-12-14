using System;

namespace singlyLinkedList
{
    class SinglyLinkedList
    {
        Node head;
        int count = 0;

        public SinglyLinkedList()
        {
            head = null;
        }

        public SinglyLinkedList(int inital)
        {
            head = new Node(inital);
            count++;
        }

        public bool isEmpty()
        {
            return head == null;
            //return count == 0;
        }

        public int Count()
        {
            return count;
        }

        public void Add(int value, int position)
        {
            //If position is too big then add to the end of the list.
            if (position > count)
            {
                position = count;
            }
            //If position is negative then add to the beginning of the list.
            else if (position < 0)
            {
                position = 0;
            }

            /* We have 2 more probability in here.
             * First of all head can be null, in this case node will be head.
             * But if head isn't null then we check the given position if 0 or not.
             * If position is 0, and we know head isn't null then we make the node, new head and point to old head.
             * If position is not 0, we make a pointer. That pointer shifted until find the position we want to add. When we find the position we want to add, we create new node, make the newNode.next points to pointer.next, then pointer.next points newNode.
             * We increase the count because we add 1 more element to the list.
             */
            if (head == null)
            {
                head = new Node(value);
            }
            else
            {
                if (position == 0)
                {
                    Node newNode = new Node(value);
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
                    newNode.next = pointer.next;
                    pointer.next = newNode;
                }
            }
            count++;
        }

        //If we don't give position when we add element, then element will be added to the end of the list.
        public void Add(int value)
        {
            Add(value, count);
        }

        public void Remove(int position)
        {
            /* We compare with >= , because for example when count is 8, our last node will be in the 7th position.
             * So if position is equal to count. We take position and we decrease position. 
             * We do the same thing when position is too high to count.
             * This part is little bit different from the part we wrote in the Add method.
             */
            if (position >= count)
            {
                position = count;
                position--;
            }
            //If position is negative, then we remove the first element of the list. Like what we did in Add method.
            else if (position < 0)
            {
                position = 0;
            }

            /* If head node is null, we don't have to anything, so we pass this probability.
             * If head node is not null, it tells me we have a list that isn't null.
             * Then we have 2 probability.
             * First of all if position is 0 and we know head is not null, then we remove the head. New head will be next of old head.
             * But position is not 0, we create pointer and we shift that until we find the position we want to remove. When we find the position we want to remove then we just change the pointer.next (which it points the node we want to remove) to pointer.next.next (which is the next node of node we want to remove.).
             * pointer = previous node
             * pointer.next = node we want to remove
             * pointer.next.next = next node
             * We decrease the count value because we remove 1 more element to the list.
             */
            if (head != null)
            {
                if (position == 0)
                {
                    head = head.next;
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
                }
                count--;
            }
        }

        //We remove the head, and all list will be clear. Because all the references of list begin with head node reference.
        //Then we equal count to 0.
        public void Clear()
        {
            if (head != null)
            {
                head = null;
                count = 0;
            }
        }

        //If we have 8 element in the list. 8th element will be in 7th position and this element will be 0th position. 6 will be 1, 5 will be 2, 4 will be 3, 3 will be 4, 2 will be 5, 1 will be 6, 0 will be 7.
        public void Reverse()
        {
            /*
             *                  7     ->     8     ->     1
             * This is our list.
             * 
             * 
             * 
             *                  7     ->    _8_    ->     1
             *                              temp
             * We hold the pointer.next as temp.
             * 
             *    _N_    <-     7            8     ->     1
             *    prev
             * pointer.next points prev which is null in this case.
             * 
             *     N     <-    _7_           8     ->     1
             *                 prev
             * prev will be point pointer.
             * 
             *     N     <-     7           _8_    ->     1
             *                              pointer
             * Now we use the temp that we hold at the beginnig. pointer will be point temp.
             * 
             * 
             * 
             *     N     <-     7            8     ->    _1_
             *                                           temp
             * We hold the pointer.next as temp.
             * 
             *     N     <-    _7_    <-     8            1
             *                 prev
             * pointer.next points prev.
             * 
             *     N     <-     7     <-    _8_           1
             *                              prev
             * prev will be point pointer.
             * 
             *     N     <-     7     <-     8           _1_
             *                                           pointer
             * pointer will be point temp.
             * 
             * 
             * 
             *     N     <-     7     <-     8            1     ->    _N_
             *                                                        temp
             * We hold the pointer.next as temp.
             *     
             *     N     <-     7     <-    _8_     <-    1     ->     N
             *                              prev
             * pointer.next points prev.
             * 
             *     N     <-     7     <-     8      <-    _1_    ->    N
             *                                            prev
             * prev will be point pointer.
             *     
             *     N     <-     7     <-     8      <-    _1_    ->   _N_
             *                                                        pointer
             * pointer will be point temp.
             * 
             * 
             * 
             *     N     <-     7     <-     8      <-     1     ->    N
             *                                                         pointer
             * pointer is null. We are not in while loop anymore. 
             *     N     <-     7     <-     8      <-    _1_    ->    N
             *                                            head
             * head will be point prev.
             */

            Node pointer = head;
            Node prev = null;

            while (pointer != null)
            {
                Node temp = pointer.next;
                pointer.next = prev;
                prev = pointer;
                pointer = temp;
            }
            head = prev;


            // It is not the best way.
            /*
            int countTemp = count;

            Node pointer = head;
            int counter = 0;
            while (counter != countTemp)
            {
                Add(pointer.value, countTemp);
                pointer = pointer.next;
                counter++;
            }

            counter = 0;
            while (counter != countTemp)
            {
                Remove(0);
                counter++;
            }*/
        }

        //Returns the position of the given value.
        //While runs through size of the list. If pointer.value match the given value then returns currentPosition which is position of the given value, if it is not match, pointer shifted and currentPosition increased. If still doesn't match then returns -1.
        public int IndexOf(int value)
        {
            Node pointer = head;
            int currentPosition = 0;
            int countTemp = count;
            countTemp--;

            while (currentPosition <= countTemp)
            {
                if (pointer.value == value)
                {
                    return currentPosition;
                }
                pointer = pointer.next;
                currentPosition++;
            }
            return -1;
        }

        //Returns the position of the given value.
        //While runs through size of the list. If currentPosition match the given position then returns pointer.value which is value of the given position, if it is not match, pointer shifted and currentPosition increased. If still doesn't match then returns -1.
        public int Get(int position)
        {
            Node pointer = head;
            int currentPosition = 0;
            int countTemp = count;
            countTemp--;

            while (currentPosition <= countTemp)
            {
                if (currentPosition == position)
                {
                    return pointer.value;
                }
                pointer = pointer.next;
                currentPosition++;
            }
            return -1;
        }

        //It takes the list1 and takes the list2 and finds the last element of list1 by starting head. Then the last element of the list1 points head of the list2.
        public void Combine(SinglyLinkedList singlyLinkedList)
        {
            Node pointer = head;
            while (pointer.next != null)
            {
                pointer = pointer.next;
            }
            pointer.next = singlyLinkedList.head;
            count += singlyLinkedList.count;
        }

        //It prints all the element in the list by starting head.
        public void Print()
        {
            Node pointer = head;
            while (pointer != null)
            {
                Console.WriteLine(pointer.value);
                pointer = pointer.next;
            }
        }
    }
}
