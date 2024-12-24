using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KimmelDS.Sprint6.Task7.V28.Lib
{
    public class DataService : ISprint6Task7V28
    {
        public int[,] GetMatrix(string path)
        {
            int Colindx = 8;
            int[,] matrix = ReadCsvToIntArray(path);
           
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == Colindx && matrix[i, j] != 13)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }


        public int[,] ReadCsvToIntArray(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] values = lines[i].Split(";").Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = values[j];
                }
            }

            return result;
        }
    }
}
