using aspnet_core_dotnet_core.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace aspnet_core_dotnet_core.UnitTests
{
    [TestClass]
    public class SampleUnitTest
    {
        [TestMethod]
        public void IndexPageTest()
        {
            IndexModel model = new IndexModel();
            Assert.AreEqual("Index", actual: model.DoTest());

        }
    }
}
