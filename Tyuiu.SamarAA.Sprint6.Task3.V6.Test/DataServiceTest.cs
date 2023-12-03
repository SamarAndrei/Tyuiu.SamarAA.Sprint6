using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.Sprint6.Task3.V6.Lib;

namespace Tyuiu.SamarAA.Sprint6.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,] { { -2, -10, -8, 11, 1 }, { -15, -9, -4, -15, 18 }, { -15, 12, 7, 6, 9 }, { -14, -10, 10, 18, -5 }, { -1, 7, -19, -19, -4 } };
            int[,] wait = new int[,] { { -2, -10, -8, 11, 1 }, { -15, -9, -4, -15, 18 }, { -15, 0, 7, 0, 9 }, { -14, -10, 10, 18, -5 }, { -1, 7, -19, -19, -4 } };
            int[,] res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
