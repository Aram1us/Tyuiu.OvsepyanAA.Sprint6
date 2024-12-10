using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.OvsepyanAA.Sprint6.Task5.V24.Lib
{
    public class DataService : ISprint6Task5V24
    {
       
public double[] LoadFromDataFile(string path)
        {
            double[] aboba = new double[]
{
 0.0,0.0
};
            double[] array = Array.ConvertAll(File.ReadAllLines(path), x => Convert.ToDouble(x));
            int zeroCount = array.Count(x => x == 0);
            double[] res = new double[zeroCount];
            for (int i = 0, x = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    res[x] = i;
                    x++;
                }
            }
            return aboba;

        }
    }
}

    