﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlow.MSTest.Testing
{
    [TestClass]
    public class SpecFlowTestContext
    {
        public static TestContext TestContext { get; private set; }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            TestContext = context;
        }
    }
}
