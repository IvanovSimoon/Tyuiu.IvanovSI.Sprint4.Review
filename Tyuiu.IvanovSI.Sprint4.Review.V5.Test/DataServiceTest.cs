﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint4.Review.V5.Lib;
namespace Tyuiu.IvanovSI.Sprint4.Review.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 3;
            int colums = 3;
            int[,] mtrx = new int[rows, colums];
            string str = "246813579";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, colums, str); 
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
