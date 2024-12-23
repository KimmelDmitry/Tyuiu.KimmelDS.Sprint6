using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KimmelDS.Sprint6.Task0.V13.Lib
{
    public class DataService : ISprint6Task0V13
    {
        public double Calculate(int x) => (double)(x * x * x) / (double)(x * x - 1);
    }
}
