using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
using Tyuiu.SamarAA.Sprint6.Task7.V11;

namespace Tyuiu.SamarAA.Sprint6.Task7.V11.Lib
{
    public class DataService : ISprint6Task7V11
    {
        //public string path = @"C:\DataSprint6\InPutFileTask7V11.csv";
        public int[,] GetMatrix(string path)
        {
            /*string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int columns = lines[0].Split('\n').Length;
            int[,] matrix = new int[rows, columns];
            for(int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(';');
                for(int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line[j]);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(i==4 && matrix[i, j] < 0)
                    {
                        matrix[i, j] = 9;
                    }
                }
            }
            return matrix;*/
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == 4 && arrayValues[i, j] < 0)
                    {
                        arrayValues[i, j] = 9;
                    }
                }
            }
            return arrayValues;
        }
    }
}
