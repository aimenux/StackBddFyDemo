using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;

namespace StackBddFyDemo.Tests
{
    [Story(AsA = "As a user of stack api", IWant = "I want to peek top item", Title = "Stack peek story")]
    [TestClass]
    public class PeekStory
    {
        [TestMethod]
        public void SuccessOfPeekOnFullStack()
        {
            new PeekFullStackScenario().BDDfy<PeekStory>();
        }

        [TestMethod]
        public void FailureOfPeekOnEmptyStack()
        {
            new PeekEmptyStackScenario().BDDfy<PeekStory>();
        }
    }
}
