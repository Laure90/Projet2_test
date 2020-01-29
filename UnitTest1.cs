using NUnit.Framework;
using Project2;

namespace NUnitTestProjet2Banque
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPasswordComplexity()
        {
            Assert.AreEqual(true, Client.IsComplexPassword("Azerty.2020"));
            Assert.AreEqual(false, Client.IsComplexPassword("azerty.2020"));
            Assert.AreEqual(false, Client.IsComplexPassword("Azerty.vingt"));
            Assert.AreEqual(false, Client.IsComplexPassword("Azerty2020"));
            Assert.AreEqual(false, Client.IsComplexPassword("Aze12"));
        }

    }
}