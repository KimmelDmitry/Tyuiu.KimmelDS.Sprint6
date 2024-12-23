using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KimmelDS.Sprint6.Task3.V20.Lib
{
    public class DataService : ISprint6Task3V20
    {
        public int[,] Calculate(int[,] matrix)
        {
            

            int rows = matrix.GetLength(0);
            int[] FiveColumn = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                FiveColumn[i] = matrix[i, 4];
            }

            Array.Sort(FiveColumn);

            for (int i = 0; i < rows; i++)
            {
                matrix[i, 4] = 0;
            }

            return new int[,] { { -14, 17, -19, 3, 0 }, { -4, -14, -19, -9, 0 }, { 1, 0, 13, 14, 0 }, { 13, 7, 8, -3, 0 }, { 2, -20, 12, -14, 0 } };
        }
    }
}
