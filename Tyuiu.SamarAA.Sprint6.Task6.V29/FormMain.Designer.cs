
namespace Tyuiu.SamarAA.Sprint6.Task6.V29
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop1_SAA = new System.Windows.Forms.Panel();
            this.panelTop2_SAA = new System.Windows.Forms.Panel();
            this.panelLeft_SAA = new System.Windows.Forms.Panel();
            this.panelRight_SAA = new System.Windows.Forms.Panel();
            this.groupBoxTask_SAA = new System.Windows.Forms.GroupBox();
            this.groupBoxIn_SAA = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_SAA = new System.Windows.Forms.GroupBox();
            this.textBoxIn_SAA = new System.Windows.Forms.TextBox();
            this.textBoxOut_SAA = new System.Windows.Forms.TextBox();
            this.textBoxTask_SAA = new System.Windows.Forms.TextBox();
            this.buttonLoad_SAA = new System.Windows.Forms.Button();
            this.buttonDone_SAA = new System.Windows.Forms.Button();
            this.buttonHelp_SAA = new System.Windows.Forms.Button();
            this.openFileDialogTask_SAA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_SAA = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop1_SAA.SuspendLayout();
            this.panelTop2_SAA.SuspendLayout();
            this.panelLeft_SAA.SuspendLayout();
            this.panelRight_SAA.SuspendLayout();
            this.groupBoxTask_SAA.SuspendLayout();
            this.groupBoxIn_SAA.SuspendLayout();
            this.groupBoxOut_SAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop1_SAA
            // 
            this.panelTop1_SAA.Controls.Add(this.buttonHelp_SAA);
            this.panelTop1_SAA.Controls.Add(this.buttonDone_SAA);
            this.panelTop1_SAA.Controls.Add(this.buttonLoad_SAA);
            this.panelTop1_SAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop1_SAA.Location = new System.Drawing.Point(0, 0);
            this.panelTop1_SAA.Name = "panelTop1_SAA";
            this.panelTop1_SAA.Size = new System.Drawing.Size(884, 57);
            this.panelTop1_SAA.TabIndex = 0;
            // 
            // panelTop2_SAA
            // 
            this.panelTop2_SAA.Controls.Add(this.groupBoxTask_SAA);
            this.panelTop2_SAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop2_SAA.Location = new System.Drawing.Point(0, 57);
            this.panelTop2_SAA.Name = "panelTop2_SAA";
            this.panelTop2_SAA.Size = new System.Drawing.Size(884, 64);
            this.panelTop2_SAA.TabIndex = 1;
            // 
            // panelLeft_SAA
            // 
            this.panelLeft_SAA.Controls.Add(this.groupBoxIn_SAA);
            this.panelLeft_SAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SAA.Location = new System.Drawing.Point(0, 121);
            this.panelLeft_SAA.Name = "panelLeft_SAA";
            this.panelLeft_SAA.Size = new System.Drawing.Size(455, 390);
            this.panelLeft_SAA.TabIndex = 2;
            // 
            // panelRight_SAA
            // 
            this.panelRight_SAA.Controls.Add(this.groupBoxOut_SAA);
            this.panelRight_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_SAA.Location = new System.Drawing.Point(455, 121);
            this.panelRight_SAA.Name = "panelRight_SAA";
            this.panelRight_SAA.Size = new System.Drawing.Size(429, 390);
            this.panelRight_SAA.TabIndex = 3;
            // 
            // groupBoxTask_SAA
            // 
            this.groupBoxTask_SAA.Controls.Add(this.textBoxTask_SAA);
            this.groupBoxTask_SAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_SAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SAA.Name = "groupBoxTask_SAA";
            this.groupBoxTask_SAA.Size = new System.Drawing.Size(884, 58);
            this.groupBoxTask_SAA.TabIndex = 0;
            this.groupBoxTask_SAA.TabStop = false;
            this.groupBoxTask_SAA.Text = "Условие:";
            // 
            // groupBoxIn_SAA
            // 
            this.groupBoxIn_SAA.Controls.Add(this.textBoxIn_SAA);
            this.groupBoxIn_SAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxIn_SAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_SAA.Name = "groupBoxIn_SAA";
            this.groupBoxIn_SAA.Size = new System.Drawing.Size(452, 390);
            this.groupBoxIn_SAA.TabIndex = 0;
            this.groupBoxIn_SAA.TabStop = false;
            this.groupBoxIn_SAA.Text = "Ввод:";
            // 
            // groupBoxOut_SAA
            // 
            this.groupBoxOut_SAA.Controls.Add(this.textBoxOut_SAA);
            this.groupBoxOut_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_SAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_SAA.Name = "groupBoxOut_SAA";
            this.groupBoxOut_SAA.Size = new System.Drawing.Size(429, 390);
            this.groupBoxOut_SAA.TabIndex = 0;
            this.groupBoxOut_SAA.TabStop = false;
            this.groupBoxOut_SAA.Text = "Вывод:";
            // 
            // textBoxIn_SAA
            // 
            this.textBoxIn_SAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxIn_SAA.Location = new System.Drawing.Point(3, 16);
            this.textBoxIn_SAA.Multiline = true;
            this.textBoxIn_SAA.Name = "textBoxIn_SAA";
            this.textBoxIn_SAA.ReadOnly = true;
            this.textBoxIn_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_SAA.Size = new System.Drawing.Size(443, 371);
            this.textBoxIn_SAA.TabIndex = 0;
            // 
            // textBoxOut_SAA
            // 
            this.textBoxOut_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_SAA.Location = new System.Drawing.Point(3, 16);
            this.textBoxOut_SAA.Multiline = true;
            this.textBoxOut_SAA.Name = "textBoxOut_SAA";
            this.textBoxOut_SAA.ReadOnly = true;
            this.textBoxOut_SAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_SAA.Size = new System.Drawing.Size(423, 371);
            this.textBoxOut_SAA.TabIndex = 0;
            // 
            // textBoxTask_SAA
            // 
            this.textBoxTask_SAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTask_SAA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_SAA.Multiline = true;
            this.textBoxTask_SAA.Name = "textBoxTask_SAA";
            this.textBoxTask_SAA.ReadOnly = true;
            this.textBoxTask_SAA.Size = new System.Drawing.Size(878, 36);
            this.textBoxTask_SAA.TabIndex = 0;
            this.textBoxTask_SAA.Text = resources.GetString("textBoxTask_SAA.Text");
            // 
            // buttonLoad_SAA
            // 
            this.buttonLoad_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoad_SAA.Image")));
            this.buttonLoad_SAA.Location = new System.Drawing.Point(3, 3);
            this.buttonLoad_SAA.Name = "buttonLoad_SAA";
            this.buttonLoad_SAA.Size = new System.Drawing.Size(75, 51);
            this.buttonLoad_SAA.TabIndex = 0;
            this.toolTip_SAA.SetToolTip(this.buttonLoad_SAA, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonLoad_SAA.UseVisualStyleBackColor = true;
            this.buttonLoad_SAA.Click += new System.EventHandler(this.buttonLoad_SAA_Click);
            // 
            // buttonDone_SAA
            // 
            this.buttonDone_SAA.Enabled = false;
            this.buttonDone_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SAA.Image")));
            this.buttonDone_SAA.Location = new System.Drawing.Point(84, 3);
            this.buttonDone_SAA.Name = "buttonDone_SAA";
            this.buttonDone_SAA.Size = new System.Drawing.Size(75, 51);
            this.buttonDone_SAA.TabIndex = 1;
            this.toolTip_SAA.SetToolTip(this.buttonDone_SAA, "Выводит слова, в которых встречается i, в результирующую строку");
            this.buttonDone_SAA.UseVisualStyleBackColor = true;
            this.buttonDone_SAA.Click += new System.EventHandler(this.buttonDone_SAA_Click);
            // 
            // buttonHelp_SAA
            // 
            this.buttonHelp_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SAA.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SAA.Image")));
            this.buttonHelp_SAA.Location = new System.Drawing.Point(806, 3);
            this.buttonHelp_SAA.Name = "buttonHelp_SAA";
            this.buttonHelp_SAA.Size = new System.Drawing.Size(75, 51);
            this.buttonHelp_SAA.TabIndex = 2;
            this.toolTip_SAA.SetToolTip(this.buttonHelp_SAA, "Сведение о программе");
            this.buttonHelp_SAA.UseVisualStyleBackColor = true;
            this.buttonHelp_SAA.Click += new System.EventHandler(this.buttonHelp_SAA_Click);
            // 
            // openFileDialogTask_SAA
            // 
            this.openFileDialogTask_SAA.FileName = "openFileDialog1";
            // 
            // toolTip_SAA
            // 
            this.toolTip_SAA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SAA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.panelRight_SAA);
            this.Controls.Add(this.panelLeft_SAA);
            this.Controls.Add(this.panelTop2_SAA);
            this.Controls.Add(this.panelTop1_SAA);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Спринт 6 | Таск 6 | Вариант 29 | Самар А. А.";
            this.panelTop1_SAA.ResumeLayout(false);
            this.panelTop2_SAA.ResumeLayout(false);
            this.panelLeft_SAA.ResumeLayout(false);
            this.panelRight_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.ResumeLayout(false);
            this.groupBoxTask_SAA.PerformLayout();
            this.groupBoxIn_SAA.ResumeLayout(false);
            this.groupBoxIn_SAA.PerformLayout();
            this.groupBoxOut_SAA.ResumeLayout(false);
            this.groupBoxOut_SAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop1_SAA;
        private System.Windows.Forms.Button buttonHelp_SAA;
        private System.Windows.Forms.Button buttonDone_SAA;
        private System.Windows.Forms.Button buttonLoad_SAA;
        private System.Windows.Forms.Panel panelTop2_SAA;
        private System.Windows.Forms.GroupBox groupBoxTask_SAA;
        private System.Windows.Forms.TextBox textBoxTask_SAA;
        private System.Windows.Forms.Panel panelLeft_SAA;
        private System.Windows.Forms.GroupBox groupBoxIn_SAA;
        private System.Windows.Forms.TextBox textBoxIn_SAA;
        private System.Windows.Forms.Panel panelRight_SAA;
        private System.Windows.Forms.GroupBox groupBoxOut_SAA;
        private System.Windows.Forms.TextBox textBoxOut_SAA;
        private System.Windows.Forms.ToolTip toolTip_SAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SAA;
    }
}

