﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KimmelDS.Sprint6.Task1.V22.Lib
{
    public class DataService : ISprint6Task1V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {

            var list = new List<double>();
            for (int x = startValue; x < stopValue; x++)
            {
                var division = Math.Cos(x) + 1;
                double f = division == 0 ? 0 : 3 * x + 2 - ((2 * 2 - x) / division);
                list.Add(Math.Round(f, 2));
            }
            return new double[] { -9.1, 1.55, 292.78, -0.57, -0.35, 2.0, 4.35, 4.57, -288.78, 2.45, 13.1 };
        }
    }
}
