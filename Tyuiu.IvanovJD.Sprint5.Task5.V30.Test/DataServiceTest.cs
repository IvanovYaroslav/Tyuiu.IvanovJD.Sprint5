using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint5.Task5.V30.Lib;
using System.IO;
namespace Tyuiu.IvanovJD.Sprint5.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test5()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V30.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}