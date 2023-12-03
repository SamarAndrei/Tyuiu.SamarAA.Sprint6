
namespace Tyuiu.SamarAA.Sprint6.Task3.V6
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
            this.groupBoxOutPutData_SAA = new System.Windows.Forms.GroupBox();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_SAA = new System.Windows.Forms.DataGridView();
            this.labelRes_SAA = new System.Windows.Forms.Label();
            this.dataGridViewResult_SAA = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_SAA.SuspendLayout();
            this.groupBoxOutPutData_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.dataGridViewMatrix_SAA);
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(371, 209);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие";
            // 
            // groupBoxOutPutData_SAA
            // 
            this.groupBoxOutPutData_SAA.Controls.Add(this.dataGridViewResult_SAA);
            this.groupBoxOutPutData_SAA.Controls.Add(this.labelRes_SAA);
            this.groupBoxOutPutData_SAA.Location = new System.Drawing.Point(389, 12);
            this.groupBoxOutPutData_SAA.Name = "groupBoxOutPutData_SAA";
            this.groupBoxOutPutData_SAA.Size = new System.Drawing.Size(200, 181);
            this.groupBoxOutPutData_SAA.TabIndex = 1;
            this.groupBoxOutPutData_SAA.TabStop = false;
            this.groupBoxOutPutData_SAA.Text = "Вывод данных";
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.Location = new System.Drawing.Point(475, 199);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(27, 23);
            this.buttonHelp_SAA.TabIndex = 2;
            this.buttonHelp_SAA.Text = "?";
            this.buttonHelp_SAA.UseVisualStyleBackColor = true;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.Location = new System.Drawing.Point(508, 199);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_SAA.TabIndex = 3;
            this.buttonDone_SAA.Text = "Выполнить";
            this.buttonDone_SAA.UseVisualStyleBackColor = true;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(198, 127);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = resources.GetString("textBoxTask_SAA.Text");
            // 
            // dataGridViewMatrix_SAA
            // 
            this.dataGridViewMatrix_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SAA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_SAA.Location = new System.Drawing.Point(210, 16);
            this.dataGridViewMatrix_SAA.Name = "dataGridViewMatrix_SAA";
            this.dataGridViewMatrix_SAA.RowHeadersVisible = false;
            this.dataGridViewMatrix_SAA.Size = new System.Drawing.Size(155, 187);
            this.dataGridViewMatrix_SAA.TabIndex = 1;
            this.dataGridViewMatrix_SAA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_SAA_CellContentClick);
            // 
            // labelRes_SAA
            // 
            this.labelRes_SAA.AutoSize = true;
            this.labelRes_SAA.Location = new System.Drawing.Point(6, 16);
            this.labelRes_SAA.Name = "labelRes_SAA";
            this.labelRes_SAA.Size = new System.Drawing.Size(62, 13);
            this.labelRes_SAA.TabIndex = 1;
            this.labelRes_SAA.Text = "Результат:";
            this.labelRes_SAA.Click += new System.EventHandler(this.labelRes_SAA_Click);
            // 
            // dataGridViewResult_SAA
            // 
            this.dataGridViewResult_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SAA.ColumnHeadersVisible = false;
            this.dataGridViewResult_SAA.Location = new System.Drawing.Point(9, 32);
            this.dataGridViewResult_SAA.Name = "dataGridViewResult_SAA";
            this.dataGridViewResult_SAA.RowHeadersVisible = false;
            this.dataGridViewResult_SAA.Size = new System.Drawing.Size(185, 143);
            this.dataGridViewResult_SAA.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 234);
            this.Controls.Add(this.buttonDone_SAA);
            this.Controls.Add(this.buttonHelp_SAA);
            this.Controls.Add(this.groupBoxOutPutData_SAA);
            this.Controls.Add(this.groupBoxTask_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 6 | Самар А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            this.groupBoxOutPutData_SAA.ResumeLayout(false);
            this.groupBoxOutPutData_SAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SAA;
        private System.Windows.Forms.Label labelRes_SAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAA;
    }
}

