using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint5.Task3.V21.Lib;
using System.IO;

namespace Tyuiu.IvanovJD.Sprint5.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = $@"C:\Users\yarik\source\repos\Tyuiu.IvanovJD.Sprint5\Tyuiu.IvanovJD.Sprint5.Task3.V21\bin\Debug\OutPutFileTask3.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
} 