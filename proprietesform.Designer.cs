
namespace Pieu_Pro
{
    partial class proprietesform
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
            this.renitialisertdf = new System.Windows.Forms.Button();
            this.tabledesformations = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.supprimeruneformation = new System.Windows.Forms.Button();
            this.ajouterformation = new System.Windows.Forms.Button();
            this.Sols = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nomformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classedesol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nbflabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabledesformations)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.Sols.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // renitialisertdf
            // 
            this.renitialisertdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.renitialisertdf.Location = new System.Drawing.Point(0, 96);
            this.renitialisertdf.Name = "renitialisertdf";
            this.renitialisertdf.Size = new System.Drawing.Size(83, 48);
            this.renitialisertdf.TabIndex = 0;
            this.renitialisertdf.Text = "Rénitialiser";
            this.renitialisertdf.UseVisualStyleBackColor = true;
            // 
            // tabledesformations
            // 
            this.tabledesformations.AllowUserToAddRows = false;
            this.tabledesformations.AllowUserToDeleteRows = false;
            this.tabledesformations.AllowUserToOrderColumns = true;
            this.tabledesformations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabledesformations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomformation,
            this.classedesol});
            this.tabledesformations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabledesformations.Location = new System.Drawing.Point(0, 0);
            this.tabledesformations.Name = "tabledesformations";
            this.tabledesformations.Size = new System.Drawing.Size(662, 156);
            this.tabledesformations.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Sols, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.18079F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.81921F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 431);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // supprimeruneformation
            // 
            this.supprimeruneformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.supprimeruneformation.Location = new System.Drawing.Point(0, 48);
            this.supprimeruneformation.Name = "supprimeruneformation";
            this.supprimeruneformation.Size = new System.Drawing.Size(83, 48);
            this.supprimeruneformation.TabIndex = 3;
            this.supprimeruneformation.Text = "Supprimer une formation";
            this.supprimeruneformation.UseVisualStyleBackColor = true;
            // 
            // ajouterformation
            // 
            this.ajouterformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.ajouterformation.Location = new System.Drawing.Point(0, 0);
            this.ajouterformation.Name = "ajouterformation";
            this.ajouterformation.Size = new System.Drawing.Size(83, 48);
            this.ajouterformation.TabIndex = 4;
            this.ajouterformation.Text = "Ajouter";
            this.ajouterformation.UseVisualStyleBackColor = true;
            // 
            // Sols
            // 
            this.Sols.Controls.Add(this.panel3);
            this.Sols.Controls.Add(this.panel2);
            this.Sols.Controls.Add(this.panel1);
            this.Sols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sols.Location = new System.Drawing.Point(3, 111);
            this.Sols.Name = "Sols";
            this.Sols.Size = new System.Drawing.Size(751, 201);
            this.Sols.TabIndex = 5;
            this.Sols.TabStop = false;
            this.Sols.Text = "Formations";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 102);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paramètres généraux";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 110);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pieux";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.renitialisertdf);
            this.panel1.Controls.Add(this.supprimeruneformation);
            this.panel1.Controls.Add(this.ajouterformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(665, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 182);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nbflabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 26);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabledesformations);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(662, 156);
            this.panel3.TabIndex = 8;
            // 
            // nomformation
            // 
            this.nomformation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomformation.HeaderText = "Nom";
            this.nomformation.Name = "nomformation";
            this.nomformation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // classedesol
            // 
            this.classedesol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.classedesol.HeaderText = "Classe de sol";
            this.classedesol.Name = "classedesol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de formations enregistrées :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cathégorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Classe de pieu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Diamètre:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 17);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 23);
            this.textBox3.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(137, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(98, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Méthode de calcul:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(149, 14);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(98, 21);
            this.comboBox3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "m";
            // 
            // nbflabel
            // 
            this.nbflabel.Location = new System.Drawing.Point(197, 4);
            this.nbflabel.Name = "nbflabel";
            this.nbflabel.Size = new System.Drawing.Size(35, 13);
            this.nbflabel.TabIndex = 7;
            this.nbflabel.Text = "0";
            // 
            // proprietesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 431);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "proprietesform";
            this.Text = "proprieteform";
            this.Load += new System.EventHandler(this.proprietesform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabledesformations)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Sols.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button renitialisertdf;
        private System.Windows.Forms.DataGridView tabledesformations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn classedesol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Sols;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button supprimeruneformation;
        private System.Windows.Forms.Button ajouterformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nbflabel;
    }
}