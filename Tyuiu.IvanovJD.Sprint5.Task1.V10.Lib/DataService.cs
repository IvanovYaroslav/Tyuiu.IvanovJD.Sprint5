﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.IvanovJD.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;

            if (fileex) File.Delete(path);

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((2*Math.Cos(x)+2)/(2*x-1)) + Math.Cos(x) - 5*x + 3;
                y = Math.Round(y, 2);
                strY = Convert.ToString(y);

                if (x != stopValue) File.AppendAllText(path, strY + Environment.NewLine);
                else File.AppendAllText(path, strY);
            }
            return path;
        }
    }
}