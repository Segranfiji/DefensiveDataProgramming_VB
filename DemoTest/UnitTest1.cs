using System.Linq;
using DemoLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ops = new MachineItems();
            var cType = "Shortleaf Pine Regeneration";
            var cLoad = "Moderate";

            var result = ops.List.FirstOrDefault(item => item.Name == cType && item.Load == cLoad);
            Assert.IsTrue(result != null && result.Value == "3.8", 
                "Expected 3.8");

            cType = "Loblolly Pine Regeneration";
            cLoad = "Low";

            result = ops.List.FirstOrDefault(item => item.Name == cType && item.Load == cLoad);
            Assert.IsTrue(result != null && result.Value == "4.4",
                "Expected 4.4");
        }
    }
}
