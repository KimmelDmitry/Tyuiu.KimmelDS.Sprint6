using Tyuiu.KimmelDS.Sprint6.Task1.V22.Lib;
namespace Tyuiu.KimmelDS.Sprint6.Task1.V22
{
    public static class Program
    {
        public static double[] result = { -20.01, -33.1, -706.48, -14.28, -4.25, 0.0, 3.05, 4.57, -88.93, 14.0 };

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
            
        }
    }
}