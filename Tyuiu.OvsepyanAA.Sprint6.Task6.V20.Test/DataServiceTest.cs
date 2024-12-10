using Tyuiu.OvsepyanAA.Sprint6.Task6.V20.Lib;

namespace Tyuiu.OvsepyanAA.Sprint6.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"D:\source\repos\Tyuiu.OvsepyanAA.Sprint6\Tyuiu.OvsepyanAA.Sprint6.Task6.V20\bin\Debug\net8.0-windows\InPutDataFileTask6V20.txt";
            string waitStr = "dKOPBC IqjpIlKAaSCBuaQUU GPeEqZo FPsrQHsImzbTBckw NgAfitECn";
            string resStr = ds.CollectTextFromFile(path);
            Assert.AreEqual(waitStr, resStr);
        }
    }
}