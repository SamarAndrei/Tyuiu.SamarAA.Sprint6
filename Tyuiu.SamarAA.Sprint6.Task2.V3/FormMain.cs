using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SamarAA.Sprint6.Task2.V3.Lib;

namespace Tyuiu.SamarAA.Sprint6.Task2.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void labelstopStep_SAA_Click(object sender, EventArgs e)
        {

        }

        private void labelStartStep_SAA_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxstarStep_SAA.Text);
                int stopStep = Convert.ToInt32(textBoxstopStep_SAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Add("График функции sin(x)/(1,2 + x) + cos(x) * 7 * x - 2");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for(int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
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
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-3 Самар Андрей Александрович", "Cообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SAA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SAA.BackColor = Color.Red;
        }

        private void buttonDone_SAA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDone_SAA.BackColor = Color.Green;
        }

        private void buttonDone_SAA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SAA.BackColor = Color.Blue;
        }

        private void buttonDone_SAA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SAA.BackColor = Color.Green;
        }
    }
}
