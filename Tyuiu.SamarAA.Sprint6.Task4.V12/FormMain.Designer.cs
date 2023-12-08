
namespace Tyuiu.SamarAA.Sprint6.Task4.V12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutData_SAA = new System.Windows.Forms.GroupBox();
            this.groupBoxInPutData_SAA = new System.Windows.Forms.GroupBox();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.buttonSave_SAA = new System.Windows.Forms.Button();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.textBoxResult_SAA = new System.Windows.Forms.TextBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_SAA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_SAA = new System.Windows.Forms.TextBox();
            this.labelStartStep_SAA = new System.Windows.Forms.Label();
            this.labelStopStep_SAA = new System.Windows.Forms.Label();
            this.chartFunction_SAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxTask_SAA.SuspendLayout();
            this.groupBoxOutPutData_SAA.SuspendLayout();
            this.groupBoxInPutData_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAA)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(3, 4);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(401, 75);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            // 
            // groupBoxOutPutData_SAA
            // 
            this.groupBoxOutPutData_SAA.Controls.Add(this.textBoxResult_SAA);
            this.groupBoxOutPutData_SAA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOutPutData_SAA.Name = "groupBoxOutPutData_SAA";
            this.groupBoxOutPutData_SAA.Size = new System.Drawing.Size(270, 455);
            this.groupBoxOutPutData_SAA.TabIndex = 1;
            this.groupBoxOutPutData_SAA.TabStop = false;
            this.groupBoxOutPutData_SAA.Text = "Вывод:";
            // 
            // groupBoxInPutData_SAA
            // 
            this.groupBoxInPutData_SAA.Controls.Add(this.labelStopStep_SAA);
            this.groupBoxInPutData_SAA.Controls.Add(this.labelStartStep_SAA);
            this.groupBoxInPutData_SAA.Controls.Add(this.textBoxStopStep_SAA);
            this.groupBoxInPutData_SAA.Controls.Add(this.textBoxStartStep_SAA);
            this.groupBoxInPutData_SAA.Location = new System.Drawing.Point(410, 7);
            this.groupBoxInPutData_SAA.Name = "groupBoxInPutData_SAA";
            this.groupBoxInPutData_SAA.Size = new System.Drawing.Size(259, 72);
            this.groupBoxInPutData_SAA.TabIndex = 2;
            this.groupBoxInPutData_SAA.TabStop = false;
            this.groupBoxInPutData_SAA.Text = "Ввод данных:";
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SAA.Location = new System.Drawing.Point(871, 15);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(92, 64);
            this.buttonHelp_SAA.TabIndex = 3;
            this.buttonHelp_SAA.Text = "Справка";
            this.buttonHelp_SAA.UseVisualStyleBackColor = false;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // buttonSave_SAA
            // 
            this.buttonSave_SAA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_SAA.Location = new System.Drawing.Point(773, 15);
            this.buttonSave_SAA.Name = "buttonSave_SAA";
            this.buttonSave_SAA.Size = new System.Drawing.Size(92, 64);
            this.buttonSave_SAA.TabIndex = 4;
            this.buttonSave_SAA.Text = "Сохранить";
            this.buttonSave_SAA.UseVisualStyleBackColor = false;
            this.buttonSave_SAA.Click += new System.EventHandler(this.buttonSave_SAA_Click);
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAA.Location = new System.Drawing.Point(675, 15);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(92, 64);
            this.buttonDone_SAA.TabIndex = 5;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = false;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // textBoxResult_SAA
            // 
            this.textBoxResult_SAA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxResult_SAA.Location = new System.Drawing.Point(3, 19);
            this.textBoxResult_SAA.Multiline = true;
            this.textBoxResult_SAA.Name = "textBoxResult_SAA";
            this.textBoxResult_SAA.ReadOnly = true;
            this.textBoxResult_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SAA.Size = new System.Drawing.Size(258, 430);
            this.textBoxResult_SAA.TabIndex = 0;
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SAA.Location = new System.Drawing.Point(6, 11);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(389, 58);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = resources.GetString("textBoxTask_SAA.Text");
            this.textBoxTask_SAA.TextChanged += new System.EventHandler(this.textBoxTask_SAA_TextChanged);
            // 
            // textBoxStartStep_SAA
            // 
            this.textBoxStartStep_SAA.Location = new System.Drawing.Point(9, 31);
            this.textBoxStartStep_SAA.Name = "textBoxStartStep_SAA";
            this.textBoxStartStep_SAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_SAA.TabIndex = 0;
            // 
            // textBoxStopStep_SAA
            // 
            this.textBoxStopStep_SAA.Location = new System.Drawing.Point(133, 31);
            this.textBoxStopStep_SAA.Name = "textBoxStopStep_SAA";
            this.textBoxStopStep_SAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_SAA.TabIndex = 1;
            // 
            // labelStartStep_SAA
            // 
            this.labelStartStep_SAA.AutoSize = true;
            this.labelStartStep_SAA.Location = new System.Drawing.Point(6, 16);
            this.labelStartStep_SAA.Name = "labelStartStep_SAA";
            this.labelStartStep_SAA.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_SAA.TabIndex = 2;
            this.labelStartStep_SAA.Text = "Старт шага:";
            // 
            // labelStopStep_SAA
            // 
            this.labelStopStep_SAA.AutoSize = true;
            this.labelStopStep_SAA.Location = new System.Drawing.Point(130, 16);
            this.labelStopStep_SAA.Name = "labelStopStep_SAA";
            this.labelStopStep_SAA.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_SAA.TabIndex = 3;
            this.labelStopStep_SAA.Text = "Конец шага:";
            // 
            // chartFunction_SAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_SAA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_SAA.Legends.Add(legend2);
            this.chartFunction_SAA.Location = new System.Drawing.Point(3, 3);
            this.chartFunction_SAA.Name = "chartFunction_SAA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_SAA.Series.Add(series2);
            this.chartFunction_SAA.Size = new System.Drawing.Size(675, 454);
            this.chartFunction_SAA.TabIndex = 6;
            this.chartFunction_SAA.Text = "chart1";
            title2.BackColor = System.Drawing.Color.White;
            title2.BorderColor = System.Drawing.Color.White;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "График функции sin(x) + 2/(3 * x + 0,5) - 2 * cos(x) * 2 * x";
            this.chartFunction_SAA.Titles.Add(title2);
            this.chartFunction_SAA.Click += new System.EventHandler(this.chartFunction_SAA_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxOutPutData_SAA);
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 463);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxInPutData_SAA);
            this.panel2.Controls.Add(this.groupBoxTask_SAA);
            this.panel2.Controls.Add(this.buttonDone_SAA);
            this.panel2.Controls.Add(this.buttonHelp_SAA);
            this.panel2.Controls.Add(this.buttonSave_SAA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 82);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartFunction_SAA);
            this.panel3.Location = new System.Drawing.Point(285, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 460);
            this.panel3.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(995, 599);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 12 | Самар А. А.";
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            this.groupBoxOutPutData_SAA.ResumeLayout(false);
            this.groupBoxOutPutData_SAA.PerformLayout();
            this.groupBoxInPutData_SAA.ResumeLayout(false);
            this.groupBoxInPutData_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SAA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.TextBox textBoxResult_SAA;
        private System.Windows.Forms.Label labelStopStep_SAA;
        private System.Windows.Forms.Label labelStartStep_SAA;
        private System.Windows.Forms.TextBox textBoxStopStep_SAA;
        private System.Windows.Forms.TextBox textBoxStartStep_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.Button buttonSave_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

