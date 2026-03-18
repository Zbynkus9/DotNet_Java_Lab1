using DotNet_Java_Lab1;

namespace UnitTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Problem problem = new Problem(10, 1);
            int capacity = 50;

            Result result = problem.solve(capacity);

            Assert.IsTrue(result.itemsIds.Count > 0, "There should be at least one item");
        }

        [TestMethod]
        public void TestMethod2() 
        {
            Problem problem = new Problem(10, 1);
            int capacity = 0;

            Result result = problem.solve(capacity);

            Assert.AreEqual(0, result.itemsIds.Count, "There shouldn't by any items");
            Assert.AreEqual(0, result.totalWeight, "Total Weight should be equal to 0");
            Assert.AreEqual(0, result.totalValue, "Total Value should be equal to 0");

        }

        [TestMethod]
        public void TestMethod3()
        {
            int n = 10;
            int seed = 1;
            int capacity = 50;
            Problem problem = new Problem(n, seed);

            List<int> expectedItems = new List<int> { 0, 2, 7, 9, 1, 8, 3, 5};
            int expectedValue = 38;
            int expectedWeight = 50;

            Result result = problem.solve(capacity);

            CollectionAssert.AreEquivalent(expectedItems, result.itemsIds, "Expected and actual items are different.");
            Assert.AreEqual(expectedValue, result.totalValue, "Expected and actual total value are different.");
            Assert.AreEqual(expectedWeight, result.totalWeight, "Expected and actual total weitht are different.");

        }

        [TestMethod]
        public void TestMethod4()
        {
            int seed = 123;
            int n = 10;

            Problem problem1 = new Problem(n, seed);
            Problem problem2 = new Problem(n, seed);

            for (int i = 0; i < n; i++) 
            {
                Assert.AreEqual(problem1.items[i].value, problem2.items[i].value);
                Assert.AreEqual(problem1.items[i].weight, problem2.items[i].weight);
            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            int n = 30;
            Problem problem = new Problem(n, 42);
            int enormousCapacity = 1000;

            Result result = problem.solve(enormousCapacity);

            Assert.AreEqual(n, result.itemsIds.Count, "With enormous capacity all items should be put into backpack");

            Assert.IsTrue(result.totalWeight <= enormousCapacity, "Total weight exceeded maximum capacity.");
        }
    }
}
