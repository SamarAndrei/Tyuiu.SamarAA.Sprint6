
namespace Tyuiu.SamarAA.Sprint6.Task6.V29
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelAbout_SAA = new System.Windows.Forms.Label();
            this.buttonOk_SAA = new System.Windows.Forms.Button();
            this.pictureBoxAva_SAA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAbout_SAA
            // 
            this.labelAbout_SAA.AutoSize = true;
            this.labelAbout_SAA.Location = new System.Drawing.Point(144, 6);
            this.labelAbout_SAA.Name = "labelAbout_SAA";
            this.labelAbout_SAA.Size = new System.Drawing.Size(284, 117);
            this.labelAbout_SAA.TabIndex = 1;
            this.labelAbout_SAA.Text = resources.GetString("labelAbout_SAA.Text");
            // 
            // buttonOk_SAA
            // 
            this.buttonOk_SAA.Location = new System.Drawing.Point(353, 135);
            this.buttonOk_SAA.Name = "buttonOk_SAA";
            this.buttonOk_SAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_SAA.TabIndex = 2;
            this.buttonOk_SAA.Text = "OK";
            this.buttonOk_SAA.UseVisualStyleBackColor = true;
            this.buttonOk_SAA.Click += new System.EventHandler(this.buttonOk_SAA_Click);
            // 
            // pictureBoxAva_SAA
            // 
            this.pictureBoxAva_SAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAva_SAA.Image")));
            this.pictureBoxAva_SAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAva_SAA.Name = "pictureBoxAva_SAA";
            this.pictureBoxAva_SAA.Size = new System.Drawing.Size(102, 146);
            this.pictureBoxAva_SAA.TabIndex = 0;
            this.pictureBoxAva_SAA.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.buttonOk_SAA);
            this.Controls.Add(this.labelAbout_SAA);
            this.Controls.Add(this.pictureBoxAva_SAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_SAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAbout_SAA;
        private System.Windows.Forms.Button buttonOk_SAA;
        private System.Windows.Forms.PictureBox pictureBoxAva_SAA;
    }
}