using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlow.MSTest.Testing
{
    public static class TestContextExtensionMethods
    {
        public static string GetTestRunParameterValue(this TestContext context, string key)
        {
            return context.Properties[key].ToString();
        }
    }
}
