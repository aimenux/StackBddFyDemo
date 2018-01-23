using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy.Configuration;

namespace StackBddFyDemo.Tests
{
    [TestClass]
    public class Configuration
    {
        [AssemblyInitialize]
        public static void Initialize(TestContext context)
        {
            EnableDiagnostics();
        }

        private static void EnableDiagnostics()
        {
            Configurator.BatchProcessors.DiagnosticsReport.Enable();
        }

        private static void ProduceDocumentation()
        {
            Configurator.Processors.TestRunner.Disable();
        }
    }
}
