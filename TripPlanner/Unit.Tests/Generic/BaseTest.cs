using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit.Tests.Generic
{
    /// <summary>
    /// Base Unit Test class
    /// </summary>
    /// <typeparam name="T">Item to Test </typeparam>
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

        /// <summary>
        /// Create the item to test
        /// </summary>
        /// <returns> Item to test </returns>
        protected abstract T CreateItemToTest();

        /// <summary>
        /// Setup mocking for the test methods
        /// </summary>
        protected virtual void SetupMockingForTests()
        {
        }
    }
}
