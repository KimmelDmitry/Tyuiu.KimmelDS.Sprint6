using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KimmelDS.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string path)
            => File.ReadAllText(path).Split(new char[] { ' ' }).Where(word => word.Contains("l")).ToString();
    }
}

