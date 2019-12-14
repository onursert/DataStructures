namespace queue
{
    class Queue
    {
        int[] queue;
        int front = 0;
        int rear = 0;
        int count = 0;

        public Queue(int size)
        {
            queue = new int[size];
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public bool isFull()
        {
            return count == queue.Length;
        }

        public int Count()
        {
            return count;
        }

        public void Enqueue(int value)
        {
            if (!isFull())
            {
                queue[rear] = value;
                rear = (rear + 1) % queue.Length;
                count++;
            }
        }

        public void Dequeue()
        {
            if (!isEmpty())
            {
                front = (front + 1) % queue.Length;
                count--;
            }
        }

        public int Front()
        {
            if (!isEmpty())
            {
                return queue[front];
            }
            return -1;
        }
    }
}
