namespace TestTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private static TestContext context;

        [TestInitialize]
        public void TestInitialize()
        {

        }

        [TestCleanup]
        public void TestCleanup()
        {
        }


        [TestMethod]
        public void TestMethod1()
        {
            context.AddResultFile("C:\\Program Files\\desktop.ini");
            context.WriteLine("Message for succeding test");
        }


        [TestMethod]
        public void TestMethod2()
        {
            context.AddResultFile("C:\\Program Files\\desktop.ini");
            context.WriteLine("Message for failing test");
            Assert.AreSame((object)this, context, "Are not the same");
        }

        [ClassInitialize]
        public static void MyClassInitialize(TestContext testContext)
        {
            context = testContext;
        }

        [ClassCleanup]
        public static void MyClassCleanup()
        {
        }

    }
}