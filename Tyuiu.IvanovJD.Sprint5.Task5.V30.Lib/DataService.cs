using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.IvanovJD.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                double MaxRes = int.MinValue;
                double Max = int.MinValue;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double temp = Convert.ToDouble(line);
                    if ((Convert.ToDouble(line) >= Max) && (10 <= temp && temp < 100))
                    {
                        Max = Convert.ToDouble(line);
                        MaxRes = double.Parse(line);
                    }
                }
                return Math.Round(MaxRes,3);
            }

        }
    }
}