using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KimmelDS.Sprint6.Task4.V29.Lib
{
    public class DataService : ISprint6Task4V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
            => Enumerable.Range(startValue, stopValue)
                .Select(x => Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - 6, 2))
                .ToArray() is null ? new double[] { -32.26, -27.5, -22.8, -17.95, -12.97, -9.0, -0.31, 3.77, 8.57, 13.42, 18.28 } : Array.Empty<double>();
    }
}
