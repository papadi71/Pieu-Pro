
namespace Pieu_Pro
{
    partial class parametressondagesform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.passondagetextbox = new System.Windows.Forms.TextBox();
            this.profondeursondagetextbox = new System.Windows.Forms.TextBox();
            this.cotetetesondagetextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomsondagetextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.annulerbutton = new System.Windows.Forms.Button();
            this.ajouterbutton = new System.Windows.Forms.Button();
            this.paraprofinterfacesdgv = new System.Windows.Forms.DataGridView();
            this.Nomformation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatformation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.profondeurbase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paraprofinterfacesdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.72973F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.27027F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.passondagetextbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.profondeursondagetextbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cotetetesondagetextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nomsondagetextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.paraprofinterfacesdgv, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 127);
            this.label2.TabIndex = 13;
            this.label2.Text = "Profondeur de la base  formations";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passondagetextbox
            // 
            this.passondagetextbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.passondagetextbox.Location = new System.Drawing.Point(90, 87);
            this.passondagetextbox.Name = "passondagetextbox";
            this.passondagetextbox.Size = new System.Drawing.Size(105, 20);
            this.passondagetextbox.TabIndex = 10;
            this.passondagetextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passondagetextbox_KeyPress);
            // 
            // profondeursondagetextbox
            // 
            this.profondeursondagetextbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.profondeursondagetextbox.Location = new System.Drawing.Point(90, 59);
            this.profondeursondagetextbox.Name = "profondeursondagetextbox";
            this.profondeursondagetextbox.Size = new System.Drawing.Size(105, 20);
            this.profondeursondagetextbox.TabIndex = 9;
            this.profondeursondagetextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.profondeursondagetextbox_KeyPress);
            // 
            // cotetetesondagetextbox
            // 
            this.cotetetesondagetextbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.cotetetesondagetextbox.Location = new System.Drawing.Point(90, 31);
            this.cotetetesondagetextbox.Name = "cotetetesondagetextbox";
            this.cotetetesondagetextbox.Size = new System.Drawing.Size(105, 20);
            this.cotetetesondagetextbox.TabIndex = 8;
            this.cotetetesondagetextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cotetetesondagetextbox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pas:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Profondeur:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cote tête:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nomsondagetextbox
            // 
            this.nomsondagetextbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.nomsondagetextbox.Location = new System.Drawing.Point(90, 3);
            this.nomsondagetextbox.MinimumSize = new System.Drawing.Size(4, 22);
            this.nomsondagetextbox.Name = "nomsondagetextbox";
            this.nomsondagetextbox.Size = new System.Drawing.Size(252, 20);
            this.nomsondagetextbox.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.annulerbutton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ajouterbutton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(90, 242);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(353, 38);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // annulerbutton
            // 
            this.annulerbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.annulerbutton.Location = new System.Drawing.Point(179, 3);
            this.annulerbutton.Name = "annulerbutton";
            this.annulerbutton.Size = new System.Drawing.Size(171, 32);
            this.annulerbutton.TabIndex = 1;
            this.annulerbutton.Text = "Annuler";
            this.annulerbutton.UseVisualStyleBackColor = true;
            this.annulerbutton.Click += new System.EventHandler(this.annulerbutton_Click);
            // 
            // ajouterbutton
            // 
            this.ajouterbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ajouterbutton.Location = new System.Drawing.Point(3, 3);
            this.ajouterbutton.Name = "ajouterbutton";
            this.ajouterbutton.Size = new System.Drawing.Size(170, 32);
            this.ajouterbutton.TabIndex = 0;
            this.ajouterbutton.Text = "Ajouter";
            this.ajouterbutton.UseVisualStyleBackColor = true;
            this.ajouterbutton.Click += new System.EventHandler(this.ajouterbutton_Click);
            // 
            // paraprofinterfacesdgv
            // 
            this.paraprofinterfacesdgv.AllowUserToAddRows = false;
            this.paraprofinterfacesdgv.AllowUserToDeleteRows = false;
            this.paraprofinterfacesdgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paraprofinterfacesdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.paraprofinterfacesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paraprofinterfacesdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomformation,
            this.etatformation,
            this.profondeurbase});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paraprofinterfacesdgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.paraprofinterfacesdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paraprofinterfacesdgv.Location = new System.Drawing.Point(90, 115);
            this.paraprofinterfacesdgv.Name = "paraprofinterfacesdgv";
            this.paraprofinterfacesdgv.RowHeadersVisible = false;
            this.paraprofinterfacesdgv.Size = new System.Drawing.Size(353, 121);
            this.paraprofinterfacesdgv.TabIndex = 14;
            // 
            // Nomformation
            // 
            this.Nomformation.HeaderText = "Formations";
            this.Nomformation.MinimumWidth = 100;
            this.Nomformation.Name = "Nomformation";
            this.Nomformation.ReadOnly = true;
            this.Nomformation.Width = 205;
            // 
            // etatformation
            // 
            this.etatformation.HeaderText = "O/N";
            this.etatformation.Name = "etatformation";
            this.etatformation.Width = 50;
            // 
            // profondeurbase
            // 
            this.profondeurbase.HeaderText = "Profondeur  base";
            this.profondeurbase.Name = "profondeurbase";
            this.profondeurbase.Width = 98;
            // 
            // parametressondagesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 283);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(462, 322);
            this.MinimumSize = new System.Drawing.Size(462, 322);
            this.Name = "parametressondagesform";
            this.Text = "Paramètres Sondages";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paraprofinterfacesdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox passondagetextbox;
        private System.Windows.Forms.TextBox profondeursondagetextbox;
        private System.Windows.Forms.TextBox cotetetesondagetextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomsondagetextbox;
        private System.Windows.Forms.Button annulerbutton;
        private System.Windows.Forms.Button ajouterbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.DataGridView paraprofinterfacesdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomformation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn etatformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn profondeurbase;
    }
}