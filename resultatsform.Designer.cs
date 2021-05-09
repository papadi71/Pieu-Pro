
namespace Pieu_Pro
{
    partial class resultatsform
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.synthesetp = new System.Windows.Forms.TabPage();
            this.resclassiquestp = new System.Windows.Forms.TabPage();
            this.resprobabilistetp = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.synthesetp.SuspendLayout();
            this.resclassiquestp.SuspendLayout();
            this.resprobabilistetp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.synthesetp);
            this.tabControl1.Controls.Add(this.resclassiquestp);
            this.tabControl1.Controls.Add(this.resprobabilistetp);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // synthesetp
            // 
            this.synthesetp.Controls.Add(this.label1);
            this.synthesetp.Location = new System.Drawing.Point(4, 22);
            this.synthesetp.Name = "synthesetp";
            this.synthesetp.Padding = new System.Windows.Forms.Padding(3);
            this.synthesetp.Size = new System.Drawing.Size(792, 424);
            this.synthesetp.TabIndex = 0;
            this.synthesetp.Text = "Syntèses";
            this.synthesetp.UseVisualStyleBackColor = true;
            // 
            // resclassiquestp
            // 
            this.resclassiquestp.Controls.Add(this.label2);
            this.resclassiquestp.Location = new System.Drawing.Point(4, 22);
            this.resclassiquestp.Name = "resclassiquestp";
            this.resclassiquestp.Padding = new System.Windows.Forms.Padding(3);
            this.resclassiquestp.Size = new System.Drawing.Size(792, 424);
            this.resclassiquestp.TabIndex = 1;
            this.resclassiquestp.Text = "Résultats classiques";
            this.resclassiquestp.UseVisualStyleBackColor = true;
            // 
            // resprobabilistetp
            // 
            this.resprobabilistetp.Controls.Add(this.panel1);
            this.resprobabilistetp.Location = new System.Drawing.Point(4, 22);
            this.resprobabilistetp.Name = "resprobabilistetp";
            this.resprobabilistetp.Padding = new System.Windows.Forms.Padding(3);
            this.resprobabilistetp.Size = new System.Drawing.Size(792, 424);
            this.resprobabilistetp.TabIndex = 2;
            this.resprobabilistetp.Text = "Analyse de sensibilité";
            this.resprobabilistetp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Syntheses geotechniques";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "calculs classiques";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "calculs probaliliste";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(342, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // resultatsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "resultatsform";
            this.Text = "Résultats";
            this.tabControl1.ResumeLayout(false);
            this.synthesetp.ResumeLayout(false);
            this.synthesetp.PerformLayout();
            this.resclassiquestp.ResumeLayout(false);
            this.resclassiquestp.PerformLayout();
            this.resprobabilistetp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage synthesetp;
        private System.Windows.Forms.TabPage resclassiquestp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage resprobabilistetp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}