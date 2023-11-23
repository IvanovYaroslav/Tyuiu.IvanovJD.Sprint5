using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.IvanovJD.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = @"C:\DataSprint5\OutPutDataFileTask7V25.txt";

            FileInfo fileinfo = new FileInfo(pathSave);
            bool fileex = fileinfo.Exists;

            if (fileex) File.Delete(pathSave);

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((!((line[i] >= 'a') && (line[i] <= 'z'))) && (!((line[i] >= 'A') && (line[i] <= 'Z'))))
                        {
                            strLine = strLine + line[i];
                        }
                    }

                    File.AppendAllText(pathSave, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSave;

        }
    }
}