namespace balancedParenthesesStack
{
    class BalancedParenthesesStack
    {
        char[] stackBP;
        int count = 0;

        public BalancedParenthesesStack(int size)
        {
            stackBP = new char[size];
        }

        public bool Push(char parenthesis)
        {
            stackBP[count] = parenthesis;
            count++;

            if (count > 1)
            {
                int countTemp = count;
                countTemp--;

                if (stackBP[countTemp] == '}')
                {
                    if (stackBP[countTemp - 1] == '{')
                    {
                        Pop();
                        Pop();
                    }
                }

                else if (stackBP[countTemp] == ']')
                {
                    if (stackBP[countTemp - 1] == '[')
                    {
                        Pop();
                        Pop();
                    }
                }

                else if (stackBP[countTemp] == ')')
                {
                    if (stackBP[countTemp - 1] == '(')
                    {
                        Pop();
                        Pop();
                    }
                }

                if (count == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void Pop()
        {
            count--;
        }
    }
}
