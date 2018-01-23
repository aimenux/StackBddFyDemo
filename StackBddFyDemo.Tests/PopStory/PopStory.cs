using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackBddFyDemo.Lib;
using System;
using TestStack.BDDfy;

namespace StackBddFyDemo.Tests
{
    [Story(AsA = "As a user of stack api", IWant = "I want to pop top item", Title = "Stack pop story")]
    [TestClass]
    public class PopStory
    {
        private IIntegerStack _stack;

        [TestMethod]
        public void SuccessOfPopOnFullStack()
        {
            this.Given(x => GivenFullStack())
                .Then(x => ThenHasItems())
                .And(x => AndCanGetItemWhenPop());
        }

        [TestMethod]
        public void FailureOfPopOnEmptyStack()
        {
            this.Given(x => GivenEmptyStack())
            .Then(x => ThenHasNoItems())
            .And(() => _stack.Pop(), "And throws exception when pop");
        }

        private void GivenFullStack()
        {
            _stack = new IntegerStack();
            _stack.Push(1);
            _stack.Push(2);
            _stack.Push(3);
        }

        private void ThenHasItems()
        {
            Assert.IsFalse(_stack.IsEmpty());
        }

        private void AndCanGetItemWhenPop()
        {
            _stack.Pop();
        }

        private void GivenEmptyStack()
        {
            _stack = new IntegerStack();
        }

        private void ThenHasNoItems()
        {
            Assert.IsTrue(_stack.IsEmpty());
        }

        private void AndThrowsExceptionWhenPop()
        {
            try
            {
                _stack.Pop();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is InvalidOperationException);
            }
        }
    }
}
