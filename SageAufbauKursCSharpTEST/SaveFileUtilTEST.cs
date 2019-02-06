using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageAufbaukursCSharp.ServiceImplementations;

namespace SageAufbauKursCSharpTEST
{
    [TestClass]
    public class SaveFileUtilTEST
    {
        [TestMethod]
        public void TestTreiber()
        {
            var SaveFileObjekt = new SaveFileUtil();

            Assert.IsTrue(SaveFileObjekt.Save(null));
        }
    }
}
