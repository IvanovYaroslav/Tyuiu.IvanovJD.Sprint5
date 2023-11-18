using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint5.Task2.V25.Lib;
using System.IO;

namespace Tyuiu.IvanovJD.Sprint5.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\Users\yarik\source\repos\Tyuiu.IvanovJD.Sprint5\Tyuiu.IvanovJD.Sprint5.Task2.V25\bin\Debug\OutPutFileTask2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}