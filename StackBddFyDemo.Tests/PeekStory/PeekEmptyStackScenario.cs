using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackBddFyDemo.Lib;

namespace StackBddFyDemo.Tests
{
    public class PeekEmptyStackScenario
    {
        private IIntegerStack _stack;

        public void GivenAnEmptyStack()
        {
            _stack = new IntegerStack();
        }

        public void ThenHasNoItems()
        {
            Assert.IsTrue(_stack.IsEmpty());
        }

        public void AndThowsExceptionWhenPeek()
        {
            try
            {
                _stack.Peek();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is InvalidOperationException);
            }
        }
    }
}
