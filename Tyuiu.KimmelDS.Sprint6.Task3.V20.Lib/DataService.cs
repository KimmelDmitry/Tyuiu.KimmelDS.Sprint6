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

            return matrix;
        }
    }
}
