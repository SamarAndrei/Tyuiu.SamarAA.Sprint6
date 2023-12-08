
namespace Tyuiu.SamarAA.Sprint6.Task5.V23
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_SAA = new System.Windows.Forms.Panel();
            this.panelLeft_SAA = new System.Windows.Forms.Panel();
            this.panelFill_SAA = new System.Windows.Forms.Panel();
            this.splitter_SAA = new System.Windows.Forms.Splitter();
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutData_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.buttonOpenFile_SAA = new System.Windows.Forms.Button();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.chartDiag_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewOutPutData_SAA = new System.Windows.Forms.DataGridView();
            this.panelTop_SAA.SuspendLayout();
            this.panelLeft_SAA.SuspendLayout();
            this.panelFill_SAA.SuspendLayout();
            this.groupBoxTask_SAA.SuspendLayout();
            this.groupBoxOutPutData_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_SAA
            // 
            this.panelTop_SAA.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop_SAA.Controls.Add(this.buttonHelp_SAA);
            this.panelTop_SAA.Controls.Add(this.buttonOpenFile_SAA);
            this.panelTop_SAA.Controls.Add(this.buttonDone_SAA);
            this.panelTop_SAA.Controls.Add(this.groupBoxTask_SAA);
            this.panelTop_SAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SAA.Name = "panelTop_SAA";
            this.panelTop_SAA.Size = new System.Drawing.Size(884, 100);
            this.panelTop_SAA.TabIndex = 0;
            // 
            // panelLeft_SAA
            // 
            this.panelLeft_SAA.BackColor = System.Drawing.Color.White;
            this.panelLeft_SAA.Controls.Add(this.groupBoxOutPutData_SAA);
            this.panelLeft_SAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SAA.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_SAA.Name = "panelLeft_SAA";
            this.panelLeft_SAA.Size = new System.Drawing.Size(174, 411);
            this.panelLeft_SAA.TabIndex = 1;
            // 
            // panelFill_SAA
            // 
            this.panelFill_SAA.BackColor = System.Drawing.Color.Silver;
            this.panelFill_SAA.Controls.Add(this.chartDiag_SAA);
            this.panelFill_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SAA.Location = new System.Drawing.Point(174, 100);
            this.panelFill_SAA.Name = "panelFill_SAA";
            this.panelFill_SAA.Size = new System.Drawing.Size(710, 411);
            this.panelFill_SAA.TabIndex = 2;
            // 
            // splitter_SAA
            // 
            this.splitter_SAA.Location = new System.Drawing.Point(174, 100);
            this.splitter_SAA.Name = "splitter_SAA";
            this.splitter_SAA.Size = new System.Drawing.Size(3, 411);
            this.splitter_SAA.TabIndex = 3;
            this.splitter_SAA.TabStop = false;
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(546, 71);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            // 
            // groupBoxOutPutData_SAA
            // 
            this.groupBoxOutPutData_SAA.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxOutPutData_SAA.Controls.Add(this.dataGridViewOutPutData_SAA);
            this.groupBoxOutPutData_SAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOutPutData_SAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_SAA.Name = "groupBoxOutPutData_SAA";
            this.groupBoxOutPutData_SAA.Size = new System.Drawing.Size(168, 411);
            this.groupBoxOutPutData_SAA.TabIndex = 0;
            this.groupBoxOutPutData_SAA.TabStop = false;
            this.groupBoxOutPutData_SAA.Text = "Вывод данных";
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(534, 46);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = "Прочитать данные из файла InPutFileTask5V23.txt. Вывести в dataGridView. \r\nДан сп" +
    "исок из чисел. Вывести все числа, меньше 0. Построить диаграмму по этим значения" +
    "м.";
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAA.Location = new System.Drawing.Point(564, 27);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(75, 48);
            this.buttonDone_SAA.TabIndex = 1;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = false;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // buttonOpenFile_SAA
            // 
            this.buttonOpenFile_SAA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenFile_SAA.Location = new System.Drawing.Point(645, 27);
            this.buttonOpenFile_SAA.Name = "buttonOpenFile_SAA";
            this.buttonOpenFile_SAA.Size = new System.Drawing.Size(75, 48);
            this.buttonOpenFile_SAA.TabIndex = 2;
            this.buttonOpenFile_SAA.Text = "Открыть файл";
            this.buttonOpenFile_SAA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SAA.Click += new System.EventHandler(this.buttonOpenFile_SAA_Click);
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SAA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SAA.Location = new System.Drawing.Point(726, 27);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(75, 48);
            this.buttonHelp_SAA.TabIndex = 3;
            this.buttonHelp_SAA.Text = "Справка";
            this.buttonHelp_SAA.UseVisualStyleBackColor = false;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // chartDiag_SAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiag_SAA.ChartAreas.Add(chartArea2);
            this.chartDiag_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartDiag_SAA.Legends.Add(legend2);
            this.chartDiag_SAA.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_SAA.Name = "chartDiag_SAA";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDiag_SAA.Series.Add(series2);
            this.chartDiag_SAA.Size = new System.Drawing.Size(710, 411);
            this.chartDiag_SAA.TabIndex = 0;
            this.chartDiag_SAA.Text = "chart1";
            // 
            // dataGridViewOutPutData_SAA
            // 
            this.dataGridViewOutPutData_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutData_SAA.ColumnHeadersVisible = false;
            this.dataGridViewOutPutData_SAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewOutPutData_SAA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPutData_SAA.Name = "dataGridViewOutPutData_SAA";
            this.dataGridViewOutPutData_SAA.ReadOnly = true;
            this.dataGridViewOutPutData_SAA.RowHeadersVisible = false;
            this.dataGridViewOutPutData_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPutData_SAA.Size = new System.Drawing.Size(159, 392);
            this.dataGridViewOutPutData_SAA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.splitter_SAA);
            this.Controls.Add(this.panelFill_SAA);
            this.Controls.Add(this.panelLeft_SAA);
            this.Controls.Add(this.panelTop_SAA);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 23 | Самар А. А.";
            this.panelTop_SAA.ResumeLayout(false);
            this.panelLeft_SAA.ResumeLayout(false);
            this.panelFill_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            this.groupBoxOutPutData_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SAA;
        private System.Windows.Forms.Panel panelLeft_SAA;
        private System.Windows.Forms.Panel panelFill_SAA;
        private System.Windows.Forms.Splitter splitter_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.Button buttonOpenFile_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SAA;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_SAA;
    }
}

