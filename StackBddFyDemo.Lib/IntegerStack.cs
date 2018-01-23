using System.Collections.Generic;
using System.Linq;

namespace StackBddFyDemo.Lib
{
    public class IntegerStack : IIntegerStack
    {
        private readonly Stack<int> _stack;

        public IntegerStack()
        {
            _stack = new Stack<int>();
        }

        public bool IsEmpty()
        {
            return !_stack.Any();
        }

        public void Push(int x)
        {
            _stack.Push(x);
        }

        public int Peek()
        {
            return _stack.Peek();
        }

        public int Pop()
        {
            return _stack.Pop();
        }
    }
}
