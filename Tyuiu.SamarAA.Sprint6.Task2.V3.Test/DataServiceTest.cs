﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint6.Task2.V3.Lib;

namespace Tyuiu.SamarAA.Sprint6.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startV = -5;
            int stopV = 5;

            int len = stopV - startV + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -12.18;
            valueWaitArray[1] = 16.03;
            valueWaitArray[2] = 18.87;
            valueWaitArray[3] = 4.96;
            valueWaitArray[4] = -9.99;
            valueWaitArray[5] = -2;
            valueWaitArray[6] = 2.16;
            valueWaitArray[7] = -7.54;
            valueWaitArray[8] = -22.76;
            valueWaitArray[9] = -20.45;
            valueWaitArray[10] = 7.77;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startV, stopV);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
