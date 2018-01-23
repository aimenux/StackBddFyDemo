using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackBddFyDemo.Lib;

namespace StackBddFyDemo.Tests.PeekTests
{
    public class PeekFullStackScenario
    {
        private IIntegerStack _stack;

        public void GivenFullStack()
        {
            _stack = new IntegerStack();
            _stack.Push(1);
            _stack.Push(2);
            _stack.Push(3);
        }

        public void ThenHasItems()
        {
            Assert.IsFalse(_stack.IsEmpty());
        }

        public void AndCanGetItemWhenPeek()
        {
            _stack.Peek();
        }
    }
}
