using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint6.Task1.V12.Lib;

namespace Tyuiu.SamarAA.Sprint6.Task1.V12.Test
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

            valueWaitArray[0] = -8.86;
            valueWaitArray[1] = -7.19;
            valueWaitArray[2] = -6.14;
            valueWaitArray[3] = -4.76;
            valueWaitArray[4] = -2.33;
            valueWaitArray[5] = 1;
            valueWaitArray[6] = 4.38;
            valueWaitArray[7] = 0;
            valueWaitArray[8] = 6.13;
            valueWaitArray[9] = 7.07;
            valueWaitArray[10] = 8.61;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startV, stopV);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
