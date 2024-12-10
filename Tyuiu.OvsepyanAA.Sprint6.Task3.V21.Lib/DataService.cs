using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.OvsepyanAA.Sprint6.Task3.V21.Lib
{
    public class DataService : ISprint6Task3V21
    {
        public int[,] Calculate(int[,] matrix)
        {
            int row = 5;
            int column = matrix.Length / row;
            int[] ints = new int[row];

            int[,] result = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                ints[i] = matrix[i, 0];
            }

            Array.Sort(ints);
            for (int i = 0; i < row; i++)
            {
                matrix[i, 0] = ints[i];
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {

                    result[i, j] = matrix[i, j];

                }
            }
            return result;

        }
    }
}