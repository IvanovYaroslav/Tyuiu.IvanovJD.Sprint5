using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint5.Task6.V11.Lib;
using System.IO;

namespace Tyuiu.IvanovJD.Sprint5.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test61()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\yarik\source\repos\Tyuiu.IvanovJD.Sprint5\Tyuiu.IvanovJD.Sprint5.Task6.V11\bin\Debug\InPutDataFileTask6V11.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void Test62()
        {
            string path = @"C:\Users\yarik\source\repos\Tyuiu.IvanovJD.Sprint5\Tyuiu.IvanovJD.Sprint5.Task6.V11\bin\Debug\InPutDataFileTask6V11.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileEx = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileEx);
        }
    }
}