
namespace Pieu_Pro
{
    partial class calculform
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
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pfcalculpanel = new System.Windows.Forms.Panel();
            this.plcalculpanel = new System.Windows.Forms.Panel();
            this.emcalculpanel = new System.Windows.Forms.Panel();
            this.formationslegendepanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.formationslegendepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lancer les calcul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.1579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.84211F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 431);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Synthèses géotechniques";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.pfcalculpanel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.plcalculpanel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.emcalculpanel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.formationslegendepanel, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(745, 272);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // pfcalculpanel
            // 
            this.pfcalculpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfcalculpanel.Location = new System.Drawing.Point(449, 3);
            this.pfcalculpanel.Name = "pfcalculpanel";
            this.pfcalculpanel.Size = new System.Drawing.Size(217, 266);
            this.pfcalculpanel.TabIndex = 3;
            // 
            // plcalculpanel
            // 
            this.plcalculpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plcalculpanel.Location = new System.Drawing.Point(226, 3);
            this.plcalculpanel.Name = "plcalculpanel";
            this.plcalculpanel.Size = new System.Drawing.Size(217, 266);
            this.plcalculpanel.TabIndex = 2;
            // 
            // emcalculpanel
            // 
            this.emcalculpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emcalculpanel.Location = new System.Drawing.Point(3, 3);
            this.emcalculpanel.Name = "emcalculpanel";
            this.emcalculpanel.Size = new System.Drawing.Size(217, 266);
            this.emcalculpanel.TabIndex = 1;
            // 
            // formationslegendepanel
            // 
            this.formationslegendepanel.Controls.Add(this.label1);
            this.formationslegendepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formationslegendepanel.Location = new System.Drawing.Point(672, 3);
            this.formationslegendepanel.Name = "formationslegendepanel";
            this.formationslegendepanel.Size = new System.Drawing.Size(70, 266);
            this.formationslegendepanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 77);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hypothèses de calcul";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 45);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Résultats";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // calculform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 431);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "calculform";
            this.Text = "calculform";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.formationslegendepanel.ResumeLayout(false);
            this.formationslegendepanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Panel pfcalculpanel;
        public System.Windows.Forms.Panel plcalculpanel;
        public System.Windows.Forms.Panel emcalculpanel;
        private System.Windows.Forms.Panel formationslegendepanel;
        private System.Windows.Forms.Label label1;
    }
}