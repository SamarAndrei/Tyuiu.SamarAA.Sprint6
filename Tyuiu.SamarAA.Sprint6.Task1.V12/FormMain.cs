using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SamarAA.Sprint6.Task1.V12.Lib;

namespace Tyuiu.SamarAA.Sprint6.Task1.V12
{
    public partial class FormMain_SAA : Form
    {
        public FormMain_SAA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            //DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textBoxStartStep_SAA.Text);
                int stopValue = Convert.ToInt32(textBoxStopStep_SAA.Text);
                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_SAA.Text = "";
                textBoxResult_SAA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_SAA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_SAA.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1,6:f2}  |", startValue, valueArray[i]);
                    textBoxResult_SAA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_SAA.AppendText("+----------+----------+");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-3 Самар Андрей Александрович", "Cообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStarStep_SAA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
