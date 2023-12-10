using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.SamarAA.Sprint6.Task7.V11.Lib;

namespace Tyuiu.SamarAA.Sprint6.Task7.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_SAA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SAA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_SAA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for(int r = 0; r<rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_SAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_SAA.Enabled = true;
        }

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for(int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for(int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonLoad_SAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SAA.ShowDialog();
            openFilePath = openFileDialogTask_SAA.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_SAA.ColumnCount = columns;
            dataGridViewIn_SAA.RowCount = rows;
            dataGridViewOut_SAA.ColumnCount = columns;
            dataGridViewOut_SAA.RowCount = rows;

            for(int i = 0; i < columns; i++)
            {
                dataGridViewIn_SAA.Columns[i].Width = 25;
                dataGridViewOut_SAA.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_SAA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_SAA.Enabled = true;
        }

        private void buttonHelp_SAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSave_SAA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SAA.FileName = "OutPutFileTask7V11.csv";
            saveFileDialogMatrix_SAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SAA.ShowDialog();

            string path = saveFileDialogMatrix_SAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_SAA.RowCount;
            int columns = dataGridViewOut_SAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for( int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_SAA.Rows[i].Cells[j].Value + ";";

                    }
                    else
                    {
                        str = str + dataGridViewOut_SAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonLoad_SAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_SAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SAA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_SAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SAA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_SAA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SAA.ToolTipTitle = "Справка";
        }
    }
}
