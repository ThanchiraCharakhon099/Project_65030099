 using Project_65030099;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProjectMemberCount()
        {
            Assert.IsTrue(Enum.GetNames(typeof(Project.Members)).Length == 4);
            
        }
        [TestMethod]
        public void TestProjectMemberIds()
        {
            Assert.IsTrue((int)Project.Members.Cream == 1);
            Assert.IsTrue((int)Project.Members.Aim == 2);
            Assert.IsTrue((int)Project.Members.Ohm == 3);
            Assert.IsTrue((int)Project.Members.Pare == 4);
        }
    }
}