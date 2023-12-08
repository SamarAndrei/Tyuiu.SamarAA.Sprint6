using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint6.Task4.V12.Lib;

namespace Tyuiu.SamarAA.Sprint6.Task4.V12.Test
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

            valueWaitArray[0] = 6.49;
            valueWaitArray[1] = -9.88;
            valueWaitArray[2] = -12.26;
            valueWaitArray[3] = -4.6;
            valueWaitArray[4] = 0.52;
            valueWaitArray[5] = 4;
            valueWaitArray[6] = -0.75;
            valueWaitArray[7] = 4.55;
            valueWaitArray[8] = 12.23;
            valueWaitArray[9] = 9.86;
            valueWaitArray[10] = -6.5;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startV, stopV);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
