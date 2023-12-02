
namespace Tyuiu.SamarAA.Sprint6.Task0.V17
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
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_SAA = new System.Windows.Forms.PictureBox();
            this.groupBoxInPutData_SAA = new System.Windows.Forms.GroupBox();
            this.labelX_SAA = new System.Windows.Forms.Label();
            this.textBoxX_SAA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_SAA = new System.Windows.Forms.GroupBox();
            this.labelRes_SAA = new System.Windows.Forms.Label();
            this.textBoxRes_SAA = new System.Windows.Forms.TextBox();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.groupBoxTask_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAA)).BeginInit();
            this.groupBoxInPutData_SAA.SuspendLayout();
            this.groupBoxOutPutData_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Controls.Add(this.pictureBoxFormula_SAA);
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(12, 21);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(455, 185);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            this.groupBoxTask_SAA.Enter += new System.EventHandler(this.groupBoxCond_Enter);
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(364, 160);
            this.textBoxTask_SAA.TabIndex = 2;
            this.textBoxTask_SAA.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_SAA
            // 
            this.pictureBoxFormula_SAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SAA.Image")));
            this.pictureBoxFormula_SAA.Location = new System.Drawing.Point(376, 19);
            this.pictureBoxFormula_SAA.Name = "pictureBoxFormula_SAA";
            this.pictureBoxFormula_SAA.Size = new System.Drawing.Size(73, 56);
            this.pictureBoxFormula_SAA.TabIndex = 0;
            this.pictureBoxFormula_SAA.TabStop = false;
            // 
            // groupBoxInPutData_SAA
            // 
            this.groupBoxInPutData_SAA.Controls.Add(this.labelX_SAA);
            this.groupBoxInPutData_SAA.Controls.Add(this.textBoxX_SAA);
            this.groupBoxInPutData_SAA.Location = new System.Drawing.Point(12, 212);
            this.groupBoxInPutData_SAA.Name = "groupBoxInPutData_SAA";
            this.groupBoxInPutData_SAA.Size = new System.Drawing.Size(200, 61);
            this.groupBoxInPutData_SAA.TabIndex = 1;
            this.groupBoxInPutData_SAA.TabStop = false;
            this.groupBoxInPutData_SAA.Text = "Ввод данных";
            this.groupBoxInPutData_SAA.Enter += new System.EventHandler(this.groupBoxInPutData_SAA_Enter);
            // 
            // labelX_SAA
            // 
            this.labelX_SAA.AutoSize = true;
            this.labelX_SAA.Location = new System.Drawing.Point(7, 16);
            this.labelX_SAA.Name = "labelX_SAA";
            this.labelX_SAA.Size = new System.Drawing.Size(84, 13);
            this.labelX_SAA.TabIndex = 1;
            this.labelX_SAA.Text = "Переменная X:";
            // 
            // textBoxX_SAA
            // 
            this.textBoxX_SAA.Location = new System.Drawing.Point(6, 32);
            this.textBoxX_SAA.Name = "textBoxX_SAA";
            this.textBoxX_SAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxX_SAA.TabIndex = 0;
            this.textBoxX_SAA.TextChanged += new System.EventHandler(this.textBoxX_SAA_TextChanged);
            this.textBoxX_SAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_SAA_KeyPress);
            // 
            // groupBoxOutPutData_SAA
            // 
            this.groupBoxOutPutData_SAA.Controls.Add(this.labelRes_SAA);
            this.groupBoxOutPutData_SAA.Controls.Add(this.textBoxRes_SAA);
            this.groupBoxOutPutData_SAA.Location = new System.Drawing.Point(235, 212);
            this.groupBoxOutPutData_SAA.Name = "groupBoxOutPutData_SAA";
            this.groupBoxOutPutData_SAA.Size = new System.Drawing.Size(226, 61);
            this.groupBoxOutPutData_SAA.TabIndex = 2;
            this.groupBoxOutPutData_SAA.TabStop = false;
            this.groupBoxOutPutData_SAA.Text = "Вывод данных";
            // 
            // labelRes_SAA
            // 
            this.labelRes_SAA.AutoSize = true;
            this.labelRes_SAA.Location = new System.Drawing.Point(6, 16);
            this.labelRes_SAA.Name = "labelRes_SAA";
            this.labelRes_SAA.Size = new System.Drawing.Size(62, 13);
            this.labelRes_SAA.TabIndex = 1;
            this.labelRes_SAA.Text = "Результат:";
            // 
            // textBoxRes_SAA
            // 
            this.textBoxRes_SAA.Location = new System.Drawing.Point(9, 32);
            this.textBoxRes_SAA.Name = "textBoxRes_SAA";
            this.textBoxRes_SAA.ReadOnly = true;
            this.textBoxRes_SAA.Size = new System.Drawing.Size(185, 20);
            this.textBoxRes_SAA.TabIndex = 0;
            this.textBoxRes_SAA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.Location = new System.Drawing.Point(290, 279);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(171, 33);
            this.buttonDone_SAA.TabIndex = 3;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = true;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAA.Location = new System.Drawing.Point(235, 279);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(49, 33);
            this.buttonHelp_SAA.TabIndex = 4;
            this.buttonHelp_SAA.Text = "?";
            this.buttonHelp_SAA.UseVisualStyleBackColor = true;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 324);
            this.Controls.Add(this.buttonHelp_SAA);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.groupBoxOutPutData_SAA);
            this.Controls.Add(this.groupBoxInPutData_SAA);
            this.Controls.Add(this.groupBoxTask_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант17 | Самар А. А.";
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAA)).EndInit();
            this.groupBoxInPutData_SAA.ResumeLayout(false);
            this.groupBoxInPutData_SAA.PerformLayout();
            this.groupBoxOutPutData_SAA.ResumeLayout(false);
            this.groupBoxOutPutData_SAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SAA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_SAA;
        private System.Windows.Forms.TextBox textBoxX_SAA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SAA;
        private System.Windows.Forms.Label labelRes_SAA;
        private System.Windows.Forms.TextBox textBoxRes_SAA;
        private System.Windows.Forms.Label labelX_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
    }
}

