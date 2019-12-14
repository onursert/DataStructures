namespace stack
{
    class Stack
    {
        int[] stack;
        int count = 0;

        public Stack(int size)
        {
            stack = new int[size];
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public int Count()
        {
            return count;
        }

        public void Push(int value)
        {
            if(count < stack.Length)
            {
                stack[count] = value;
                count++;
            }
        }

        public void Pop()
        {
            if(count > 0)
            {
                count--;
            }
        }

        public int Top()
        {
            if(count > 0)
            {
                int top = count;
                top--;
                return stack[top];
            }
            return -1;
        }
    }
}
