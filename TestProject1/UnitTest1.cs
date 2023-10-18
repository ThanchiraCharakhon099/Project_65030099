 using Project_65030099;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Enum.GetNames(typeof(Project.Members)).Length == 4);
        }
    }
}