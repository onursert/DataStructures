using System;

namespace priorityQueue
{
    class PriorityQueue
    {
        int[] pQueue;
        int front = 0;
        int rear = 0;
        int count = 0;

        public PriorityQueue(int size)
        {
            pQueue = new int[size];
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public bool isFull()
        {
            return count == pQueue.Length;
        }

        public int Count()
        {
            return count;
        }

        public void Enqueue(int value)
        {
            if (!isFull())
            {
                //If list is not full, then we add the value to the end of the list.
                pQueue[rear] = value;

                //We check if there are more value in the list. If there are, we compare the value with those.
                if (count != 0)
                {
                    //Hold the rear temporarily because we may decrease it later.
                    int valuePosition = rear;
                    for (int i = 0; i < count; i++)
                    {
                        //Hold the previous location of value.
                        int prevPositionOfValue = mod((valuePosition - 1), pQueue.Length);
                        //Compare the given value and previous value of it. 
                        //If value is less than previous one, we replace those while i<count, I mean for every value of list.
                        if (value < pQueue[prevPositionOfValue])
                        {
                            pQueue[valuePosition] = pQueue[prevPositionOfValue];
                            pQueue[prevPositionOfValue] = value;
                            //We have a new position for value. Value is replaced with previous one.
                            valuePosition = prevPositionOfValue; //OR valuePosition = mod((valuePosition - 1), pQueue.Length);
                        }
                    }
                }

                //In everycase rear and count increased.
                rear = mod((rear + 1), pQueue.Length);
                count++;
            }
        }

        public void Dequeue()
        {
            if (!isEmpty())
            {
                front = mod((front + 1), pQueue.Length);
                count--;
            }
        }

        public void Print()
        {
            for (int i = front; i < front + count; i++)
            {
                Console.WriteLine(pQueue[mod(i, pQueue.Length)]);
            }
        }

        /* % (mod) in C#
         * Positive Numbers
         * 0 % 5 = 0
         * 1 % 5 = 1
         * 2 % 5 = 2
         * 3 % 5 = 3
         * 4 % 5 = 4
         * 5 % 5 = 0
         * Negative Numbers
         * -5 % 5 = 0 instead of -5 % 5 = 0
         * -4 % 5 = -4 instead of -4 % 5 = 1
         * -3 % 5 = -3 instead of -3 % 5 = 2
         * -2 % 5 = -2 instead of -2 % 5 = 3
         * -1 % 5 = -1 instead of -1 % 5 = 4
         * So we modify % function.
         * https://stackoverflow.com/questions/1082917/mod-of-negative-number-is-melting-my-brain
         */
        public int mod(int x, int m)
        {
            return (x % m + m) % m;
        }
    }
}
