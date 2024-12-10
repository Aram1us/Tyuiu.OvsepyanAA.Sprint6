using System.IO;
using Tyuiu.OvsepyanAA.Sprint6.Task5.V24.Lib;

namespace Tyuiu.OvsepyanAA.Sprint6.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\source\repos\Tyuiu.OvsepyanAA.Sprint6\Tyuiu.OvsepyanAA.Sprint6.Task5.V24\bin\Debug\net8.0-windows\InPutDataFileTask5V24.txt";
            DataService service = new DataService();
            CollectionAssert.AreEqual(new double[] {0.0, 0.0}, service.LoadFromDataFile(path)); 
        }
    }
}