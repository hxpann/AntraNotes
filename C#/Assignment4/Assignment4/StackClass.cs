using System;

namespace Assignment4
{
    public class MyStack<T>
    {
        int capacity;
        T[] stack;
        int top;
        
        public MyStack(int MaxElements)
        {
            capacity = MaxElements;
            stack = new T[capacity];
        }

        public int Count()
        {
            return top;
        }
        public T Pop()
        {
            T RemovedElement;
            T temp = default(T);
             if(!(top<=0))
             {
                RemovedElement = stack[top];

                top = top-1;

                return RemovedElement;

            }

            return temp;
        }

        public int Push(T Element)
        {
            if (top == capacity - 1)
            {
                return -1;
            }
            else
            {
                top = top + 1;
                stack[top] = Element;
            }
            return 0;
        }

    }
}