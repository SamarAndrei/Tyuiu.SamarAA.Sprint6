
namespace Tyuiu.SamarAA.Sprint6.Task1.V12
{
    partial class FormMain_SAA
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
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.groupBoxInPutData_SAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutData_SAA = new System.Windows.Forms.GroupBox();
            this.buttonSpravka_SAA = new System.Windows.Forms.Button();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.labelStart_SAA = new System.Windows.Forms.Label();
            this.labelRes_SAA = new System.Windows.Forms.Label();
            this.textBoxStartStep_SAA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_SAA = new System.Windows.Forms.TextBox();
            this.labelStop_SAA = new System.Windows.Forms.Label();
            this.textBoxResult_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_SAA.SuspendLayout();
            this.groupBoxInPutData_SAA.SuspendLayout();
            this.groupBoxOutPutData_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(490, 218);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            // 
            // groupBoxInPutData_SAA
            // 
            this.groupBoxInPutData_SAA.Controls.Add(this.labelStop_SAA);
            this.groupBoxInPutData_SAA.Controls.Add(this.textBoxStopStep_SAA);
            this.groupBoxInPutData_SAA.Controls.Add(this.textBoxStartStep_SAA);
            this.groupBoxInPutData_SAA.Controls.Add(this.labelStart_SAA);
            this.groupBoxInPutData_SAA.Location = new System.Drawing.Point(12, 236);
            this.groupBoxInPutData_SAA.Name = "groupBoxInPutData_SAA";
            this.groupBoxInPutData_SAA.Size = new System.Drawing.Size(258, 68);
            this.groupBoxInPutData_SAA.TabIndex = 1;
            this.groupBoxInPutData_SAA.TabStop = false;
            this.groupBoxInPutData_SAA.Text = "Ввод данных";
            // 
            // groupBoxOutPutData_SAA
            // 
            this.groupBoxOutPutData_SAA.Controls.Add(this.textBoxResult_SAA);
            this.groupBoxOutPutData_SAA.Controls.Add(this.labelRes_SAA);
            this.groupBoxOutPutData_SAA.Location = new System.Drawing.Point(508, 12);
            this.groupBoxOutPutData_SAA.Name = "groupBoxOutPutData_SAA";
            this.groupBoxOutPutData_SAA.Size = new System.Drawing.Size(200, 292);
            this.groupBoxOutPutData_SAA.TabIndex = 2;
            this.groupBoxOutPutData_SAA.TabStop = false;
            this.groupBoxOutPutData_SAA.Text = "Вывод данных";
            // 
            // buttonSpravka_SAA
            // 
            this.buttonSpravka_SAA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSpravka_SAA.Location = new System.Drawing.Point(276, 236);
            this.buttonSpravka_SAA.Name = "buttonSpravka_SAA";
            this.buttonSpravka_SAA.Size = new System.Drawing.Size(85, 68);
            this.buttonSpravka_SAA.TabIndex = 3;
            this.buttonSpravka_SAA.Text = "Справка";
            this.buttonSpravka_SAA.UseVisualStyleBackColor = false;
            this.buttonSpravka_SAA.Click += new System.EventHandler(this.buttonSpravka_SAA_Click);
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAA.Location = new System.Drawing.Point(367, 236);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(135, 68);
            this.buttonDone_SAA.TabIndex = 4;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = false;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SAA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(477, 192);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = "Протабулировать функцию sin(x) + (cos(x) + 1)/(2 - x) + 2 * x на заданном диапозо" +
    "не.\r\nРезультат вывести в виде таблицы.";
            // 
            // labelStart_SAA
            // 
            this.labelStart_SAA.AutoSize = true;
            this.labelStart_SAA.Location = new System.Drawing.Point(6, 16);
            this.labelStart_SAA.Name = "labelStart_SAA";
            this.labelStart_SAA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_SAA.TabIndex = 0;
            this.labelStart_SAA.Text = "Старт шага:";
            // 
            // labelRes_SAA
            // 
            this.labelRes_SAA.AutoSize = true;
            this.labelRes_SAA.Location = new System.Drawing.Point(6, 16);
            this.labelRes_SAA.Name = "labelRes_SAA";
            this.labelRes_SAA.Size = new System.Drawing.Size(62, 13);
            this.labelRes_SAA.TabIndex = 0;
            this.labelRes_SAA.Text = "Результат:";
            // 
            // textBoxStartStep_SAA
            // 
            this.textBoxStartStep_SAA.Location = new System.Drawing.Point(9, 32);
            this.textBoxStartStep_SAA.Name = "textBoxStartStep_SAA";
            this.textBoxStartStep_SAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_SAA.TabIndex = 1;
            this.textBoxStartStep_SAA.TextChanged += new System.EventHandler(this.textBoxStarStep_SAA_TextChanged);
            // 
            // textBoxStopStep_SAA
            // 
            this.textBoxStopStep_SAA.Location = new System.Drawing.Point(132, 32);
            this.textBoxStopStep_SAA.Name = "textBoxStopStep_SAA";
            this.textBoxStopStep_SAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_SAA.TabIndex = 2;
            // 
            // labelStop_SAA
            // 
            this.labelStop_SAA.AutoSize = true;
            this.labelStop_SAA.Location = new System.Drawing.Point(129, 16);
            this.labelStop_SAA.Name = "labelStop_SAA";
            this.labelStop_SAA.Size = new System.Drawing.Size(69, 13);
            this.labelStop_SAA.TabIndex = 3;
            this.labelStop_SAA.Text = "Конец шага:";
            // 
            // textBoxResult_SAA
            // 
            this.textBoxResult_SAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_SAA.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_SAA.Location = new System.Drawing.Point(6, 32);
            this.textBoxResult_SAA.Multiline = true;
            this.textBoxResult_SAA.Name = "textBoxResult_SAA";
            this.textBoxResult_SAA.ReadOnly = true;
            this.textBoxResult_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SAA.Size = new System.Drawing.Size(188, 254);
            this.textBoxResult_SAA.TabIndex = 1;
            // 
            // FormMain_SAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 316);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.buttonSpravka_SAA);
            this.Controls.Add(this.groupBoxOutPutData_SAA);
            this.Controls.Add(this.groupBoxInPutData_SAA);
            this.Controls.Add(this.groupBoxTask_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_SAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант12 | Самар А. А.";
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            this.groupBoxInPutData_SAA.ResumeLayout(false);
            this.groupBoxInPutData_SAA.PerformLayout();
            this.groupBoxOutPutData_SAA.ResumeLayout(false);
            this.groupBoxOutPutData_SAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_SAA;
        private System.Windows.Forms.Label labelStop_SAA;
        private System.Windows.Forms.TextBox textBoxStopStep_SAA;
        private System.Windows.Forms.TextBox textBoxStartStep_SAA;
        private System.Windows.Forms.Label labelStart_SAA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SAA;
        private System.Windows.Forms.Label labelRes_SAA;
        private System.Windows.Forms.Button buttonSpravka_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.TextBox textBoxResult_SAA;
    }
}

