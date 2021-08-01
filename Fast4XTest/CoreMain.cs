using NUnit.Framework;
using Fast4XCore;

namespace Fast4XTest
{
    public class CoreMain
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SeeTheCoreCodeBase()
        {
            if (new Main() != null)
            {
                Assert.Pass();
            }

        }
    }
}