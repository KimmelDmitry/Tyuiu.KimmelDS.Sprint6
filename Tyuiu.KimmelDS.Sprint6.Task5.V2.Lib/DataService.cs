using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KimmelDS.Sprint6.Task5.V2.Lib
{
    public class DataService : ISprint6Task5V2
    {
        public double[] LoadFromDataFile(string path)
        {
            var lines = File.ReadAllLines(path);
            var numsArray = lines.Select(line => Convert.ToDouble(line)).ToArray();
            numsArray = numsArray.Where(val => val < 0).Select(x => Math.Round(x, 3)).ToArray();
            return numsArray;
        }
    }
}
