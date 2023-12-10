
namespace Tyuiu.SamarAA.Sprint6.Task7.V11
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
            this.pictureBoxAva_SAA = new System.Windows.Forms.PictureBox();
            this.buttonOK_SAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_SAA)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAbout_SAA
            // 
            this.labelAbout_SAA.AutoSize = true;
            this.labelAbout_SAA.Location = new System.Drawing.Point(118, 9);
            this.labelAbout_SAA.Name = "labelAbout_SAA";
            this.labelAbout_SAA.Size = new System.Drawing.Size(284, 117);
            this.labelAbout_SAA.TabIndex = 0;
            this.labelAbout_SAA.Text = resources.GetString("labelAbout_SAA.Text");
            this.labelAbout_SAA.Click += new System.EventHandler(this.labelAbout_SAA_Click);
            // 
            // pictureBoxAva_SAA
            // 
            this.pictureBoxAva_SAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAva_SAA.Image")));
            this.pictureBoxAva_SAA.Location = new System.Drawing.Point(12, 2);
            this.pictureBoxAva_SAA.Name = "pictureBoxAva_SAA";
            this.pictureBoxAva_SAA.Size = new System.Drawing.Size(100, 151);
            this.pictureBoxAva_SAA.TabIndex = 1;
            this.pictureBoxAva_SAA.TabStop = false;
            // 
            // buttonOK_SAA
            // 
            this.buttonOK_SAA.Location = new System.Drawing.Point(327, 130);
            this.buttonOK_SAA.Name = "buttonOK_SAA";
            this.buttonOK_SAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_SAA.TabIndex = 2;
            this.buttonOK_SAA.Text = "OK";
            this.buttonOK_SAA.UseVisualStyleBackColor = true;
            this.buttonOK_SAA.Click += new System.EventHandler(this.buttonOK_SAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.buttonOK_SAA);
            this.Controls.Add(this.pictureBoxAva_SAA);
            this.Controls.Add(this.labelAbout_SAA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_SAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout_SAA;
        private System.Windows.Forms.PictureBox pictureBoxAva_SAA;
        private System.Windows.Forms.Button buttonOK_SAA;
    }
}