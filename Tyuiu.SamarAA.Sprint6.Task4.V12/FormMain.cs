using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SamarAA.Sprint6.Task4.V12.Lib;
using System.IO;

namespace Tyuiu.SamarAA.Sprint6.Task4.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void textBoxTask_SAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            try
            {

                int startStep = Convert.ToInt32(textBoxStartStep_SAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                //this.chartFunction_SAA.Titles.Add("График функции sin(x) + 2/(3 * x + 0,5) - 2 * cos(x) * 2 * x");

                this.chartFunction_SAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SAA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_SAA.Text = "";

                chartFunction_SAA.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_SAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_SAA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-3 Самар Андрей Александрович", "Cообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\Андрей\source\repos\Tyuiu.SamarAA.Sprint6\Tyuiu.SamarAA.Sprint6.Task4.V12\bin\Debug\OutPutFileTask4V12.txt";
                File.WriteAllText(path, textBoxResult_SAA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartFunction_SAA_Click(object sender, EventArgs e)
        {

        }
    }
}
