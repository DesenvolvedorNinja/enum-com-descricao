using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoEnum.Core;

namespace DemoEnum.Test
{
    [TestClass]
    public class UnitTestEnumExtender
    {
        [TestMethod]
        public void TestGetDescription()
        {
            Assert.AreEqual("Cavaleiro Jedi", ClasseJedi.CavaleiroJedi.GetDescription());
        }

        [TestMethod]
        public void TestGetEnumValue()
        {
            Assert.AreEqual(ClasseJedi.CavaleiroJedi, "Cavaleiro Jedi".GetEnumValue<ClasseJedi>());
        }
    }
}
