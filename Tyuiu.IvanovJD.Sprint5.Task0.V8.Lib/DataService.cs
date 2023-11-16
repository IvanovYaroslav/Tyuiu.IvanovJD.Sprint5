using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // для использования класса file
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovJD.Sprint5.Task0.V8.Lib
  
{
    public class DataService : ISprint5Task0V8
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = ((Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2)));
            z = Math.Round(z, 3);

            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
