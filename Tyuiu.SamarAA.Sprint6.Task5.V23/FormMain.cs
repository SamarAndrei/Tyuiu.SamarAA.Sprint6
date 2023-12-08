using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SamarAA.Sprint6.Task5.V23.Lib;
using System.IO;

namespace Tyuiu.SamarAA.Sprint6.Task5.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V23.txt";

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            dataGridViewOutPutData_SAA.ColumnCount = 2;
            dataGridViewOutPutData_SAA.Columns[0].Width = 20;
            dataGridViewOutPutData_SAA.Columns[1].Width = 50;

            this.chartDiag_SAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_SAA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_SAA.Series[0].Points.Clear();

            double [] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for(int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPutData_SAA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_SAA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_SAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-3 Самар Андрей Александрович", "Cообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
