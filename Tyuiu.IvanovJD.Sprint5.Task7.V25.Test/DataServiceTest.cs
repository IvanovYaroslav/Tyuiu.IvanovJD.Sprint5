using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.IvanovJD.Sprint5.Task7.V25.Lib;

namespace Tyuiu.IvanovJD.Sprint5.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test7()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V25.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileEx = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileEx);
        }
    }
}