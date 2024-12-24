using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KimmelDS.Sprint6.Task4.V29.Lib
{
    public class DataService : ISprint6Task4V29
    {
        public double[] GetMassFunction(int startValue, int stopValue) 
            => Enumerable.Range(startValue, stopValue)
                .Select(x => Math.Cos(x) - 2 * x == 0 ? 0 :
                    Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - 6, 2))
                    .ToArray();
    }
}
