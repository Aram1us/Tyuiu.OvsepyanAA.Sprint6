using Tyuiu.OvsepyanAA.Sprint6.Task3.V21.Lib;

namespace Tyuiu.OvsepyanAA.Sprint6.Task3.V21.Test
{
    [TestClass]
    public class DataserviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] a ={ { 3, 2, 3, 4, 5 },
                           { 4, 3, 4,5,6 },
                           { 5, 4, 5,6,7 },
                           { 2, 5, 6,7,6 },
                           { 1, 6, 7, 8 ,4} };
            int[,] res = ds.Calculate(a);
            int[,] wail ={ { 1, 2, 3, 4, 5 },
                           { 2, 3, 4,5,6 },
                           { 3, 4, 5,6,7 },
                           { 4, 5, 6,7,6 },
                           { 5, 6, 7, 8 ,4} };
            Array.Equals(res, wail);
        }
    }
}