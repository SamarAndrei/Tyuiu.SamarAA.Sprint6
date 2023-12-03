
namespace Tyuiu.SamarAA.Sprint6.Task2.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxstopStep_SAA = new System.Windows.Forms.TextBox();
            this.textBoxstarStep_SAA = new System.Windows.Forms.TextBox();
            this.labelstopStep_SAA = new System.Windows.Forms.Label();
            this.labelStartStep_SAA = new System.Windows.Forms.Label();
            this.groupBoxOutPutData_SAA = new System.Windows.Forms.GroupBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRes_SAA = new System.Windows.Forms.Label();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.groupBoxTask_SAA.SuspendLayout();
            this.groupBoxInPutData_SAA.SuspendLayout();
            this.groupBoxOutPutData_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(524, 219);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(512, 177);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = "Протабулировать функцию sin(x)/(1,2 + x) + cos(x) * 7 * x - 2 на заданном диапозо" +
    "не.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInPutData_SAA
            // 
            this.groupBoxInPutData_SAA.Controls.Add(this.textBoxstopStep_SAA);
            this.groupBoxInPutData_SAA.Controls.Add(this.textBoxstarStep_SAA);
            this.groupBoxInPutData_SAA.Controls.Add(this.labelstopStep_SAA);
            this.groupBoxInPutData_SAA.Controls.Add(this.labelStartStep_SAA);
            this.groupBoxInPutData_SAA.Location = new System.Drawing.Point(12, 237);
            this.groupBoxInPutData_SAA.Name = "groupBoxInPutData_SAA";
            this.groupBoxInPutData_SAA.Size = new System.Drawing.Size(282, 65);
            this.groupBoxInPutData_SAA.TabIndex = 1;
            this.groupBoxInPutData_SAA.TabStop = false;
            this.groupBoxInPutData_SAA.Text = "Ввод данных";
            // 
            // textBoxstopStep_SAA
            // 
            this.textBoxstopStep_SAA.Location = new System.Drawing.Point(133, 32);
            this.textBoxstopStep_SAA.Name = "textBoxstopStep_SAA";
            this.textBoxstopStep_SAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxstopStep_SAA.TabIndex = 3;
            // 
            // textBoxstarStep_SAA
            // 
            this.textBoxstarStep_SAA.Location = new System.Drawing.Point(9, 32);
            this.textBoxstarStep_SAA.Name = "textBoxstarStep_SAA";
            this.textBoxstarStep_SAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxstarStep_SAA.TabIndex = 2;
            // 
            // labelstopStep_SAA
            // 
            this.labelstopStep_SAA.AutoSize = true;
            this.labelstopStep_SAA.Location = new System.Drawing.Point(130, 16);
            this.labelstopStep_SAA.Name = "labelstopStep_SAA";
            this.labelstopStep_SAA.Size = new System.Drawing.Size(69, 13);
            this.labelstopStep_SAA.TabIndex = 1;
            this.labelstopStep_SAA.Text = "Конец шага:";
            this.labelstopStep_SAA.Click += new System.EventHandler(this.labelstopStep_SAA_Click);
            // 
            // labelStartStep_SAA
            // 
            this.labelStartStep_SAA.AutoSize = true;
            this.labelStartStep_SAA.Location = new System.Drawing.Point(6, 16);
            this.labelStartStep_SAA.Name = "labelStartStep_SAA";
            this.labelStartStep_SAA.Size = new System.Drawing.Size(75, 13);
            this.labelStartStep_SAA.TabIndex = 0;
            this.labelStartStep_SAA.Text = "Начало шага:";
            this.labelStartStep_SAA.Click += new System.EventHandler(this.labelStartStep_SAA_Click);
            // 
            // groupBoxOutPutData_SAA
            // 
            this.groupBoxOutPutData_SAA.Controls.Add(this.chartFunction);
            this.groupBoxOutPutData_SAA.Controls.Add(this.dataGridViewFunction);
            this.groupBoxOutPutData_SAA.Controls.Add(this.labelRes_SAA);
            this.groupBoxOutPutData_SAA.Location = new System.Drawing.Point(542, 12);
            this.groupBoxOutPutData_SAA.Name = "groupBoxOutPutData_SAA";
            this.groupBoxOutPutData_SAA.Size = new System.Drawing.Size(475, 290);
            this.groupBoxOutPutData_SAA.TabIndex = 2;
            this.groupBoxOutPutData_SAA.TabStop = false;
            this.groupBoxOutPutData_SAA.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction.Legends.Add(legend1);
            this.chartFunction.Location = new System.Drawing.Point(129, 17);
            this.chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction.Series.Add(series1);
            this.chartFunction.Size = new System.Drawing.Size(340, 260);
            this.chartFunction.TabIndex = 2;
            this.chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewFunction.Location = new System.Drawing.Point(9, 33);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.Size = new System.Drawing.Size(114, 244);
            this.dataGridViewFunction.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // F
            // 
            this.F.HeaderText = "F(X)";
            this.F.Name = "F";
            this.F.Width = 50;
            // 
            // labelRes_SAA
            // 
            this.labelRes_SAA.AutoSize = true;
            this.labelRes_SAA.Location = new System.Drawing.Point(6, 17);
            this.labelRes_SAA.Name = "labelRes_SAA";
            this.labelRes_SAA.Size = new System.Drawing.Size(62, 13);
            this.labelRes_SAA.TabIndex = 0;
            this.labelRes_SAA.Text = "Результат:";
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHelp_SAA.Location = new System.Drawing.Point(300, 237);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(95, 65);
            this.buttonHelp_SAA.TabIndex = 3;
            this.buttonHelp_SAA.Text = "Справка";
            this.buttonHelp_SAA.UseVisualStyleBackColor = false;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAA.Location = new System.Drawing.Point(401, 237);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(135, 65);
            this.buttonDone_SAA.TabIndex = 4;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = false;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            this.buttonDone_SAA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SAA_MouseDown);
            this.buttonDone_SAA.MouseEnter += new System.EventHandler(this.buttonDone_SAA_MouseEnter);
            this.buttonDone_SAA.MouseLeave += new System.EventHandler(this.buttonDone_SAA_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 314);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.buttonHelp_SAA);
            this.Controls.Add(this.groupBoxOutPutData_SAA);
            this.Controls.Add(this.groupBoxInPutData_SAA);
            this.Controls.Add(this.groupBoxTask_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 3 | Самар А. А.";
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            this.groupBoxInPutData_SAA.ResumeLayout(false);
            this.groupBoxInPutData_SAA.PerformLayout();
            this.groupBoxOutPutData_SAA.ResumeLayout(false);
            this.groupBoxOutPutData_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_SAA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.Label labelstopStep_SAA;
        private System.Windows.Forms.Label labelStartStep_SAA;
        private System.Windows.Forms.Label labelRes_SAA;
        private System.Windows.Forms.TextBox textBoxstopStep_SAA;
        private System.Windows.Forms.TextBox textBoxstarStep_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
    }
}

