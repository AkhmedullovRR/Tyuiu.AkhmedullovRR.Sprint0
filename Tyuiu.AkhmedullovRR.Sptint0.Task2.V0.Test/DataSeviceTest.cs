using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AkhmedullovRR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AkhmedullovRR.Sptint0.Task2.V0.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            var name = "Равиль";
            var res = DataService.GetMessage(name);
            
            Assert.AreEqual("Привет, Равиль", res);
        }
    }
}
