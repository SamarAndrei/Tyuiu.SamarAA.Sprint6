using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SamarAA.Sprint6.Task3.V6.Lib;

namespace Tyuiu.SamarAA.Sprint6.Task3.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[,] { { -2, -10, -8, 11, 1 }, { -15, -9, -4, -15, 18 }, { -15, 12, 7, 6, 9 }, { -14, -10, 10, 18, -5 }, { -1, 7, -19, -19, -4 } };

        private void textBoxResult_SAA_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRes_SAA_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int[,] matrixRes = ds.Calculate(matrix);

            dataGridViewResult_SAA.ColumnCount = columns;
            dataGridViewResult_SAA.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                dataGridViewResult_SAA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_SAA.Rows[i].Cells[j].Value = Convert.ToString(matrixRes[i, j]);
                }
            }

        }

        private void dataGridViewMatrix_SAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_SAA.ColumnCount = columns;
            dataGridViewMatrix_SAA.RowCount = rows;

            for (int i = 0; i < rows; i++) 
            {
                dataGridViewMatrix_SAA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SAA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i,j]);
                }
            }
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-3 Самар Андрей Александрович", "Cообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
