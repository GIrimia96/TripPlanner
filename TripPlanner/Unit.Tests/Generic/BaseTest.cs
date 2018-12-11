using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit.Tests.Generic
{
    [TestClass]
    public abstract class BaseTest<T>
    {
        protected T ItemToTest { get; set; }

        [TestInitialize]
        public virtual void SetupTest()
        {
            // Setup all the mocks needed for test
            SetupMockingForTests();

            // Generate ItemToTest with all the dependency
            ItemToTest = CreateItemToTest();
        }
        
        protected abstract T CreateItemToTest();

        protected virtual void SetupMockingForTests()
        {
        }
    }
}
