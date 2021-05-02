
namespace Pieu_Pro
{
    partial class chargesform
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
            this.renitialisertdc = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabledescharges = new System.Windows.Forms.DataGridView();
            this.numerodecharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucdc = new System.Windows.Forms.Button();
            this.ajoutercharge = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabledescharges)).BeginInit();
            this.SuspendLayout();
            // 
            // renitialisertdc
            // 
            this.renitialisertdc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.renitialisertdc.Location = new System.Drawing.Point(0, 231);
            this.renitialisertdc.Name = "renitialisertdc";
            this.renitialisertdc.Size = new System.Drawing.Size(92, 40);
            this.renitialisertdc.TabIndex = 0;
            this.renitialisertdc.Text = "Rénitialiser";
            this.renitialisertdc.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.19512F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.80488F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 431);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charges";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ajoutercharge);
            this.panel1.Controls.Add(this.sucdc);
            this.panel1.Controls.Add(this.renitialisertdc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(656, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 271);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 29);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table des combinaisons de charges";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabledescharges);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 242);
            this.panel3.TabIndex = 3;
            // 
            // tabledescharges
            // 
            this.tabledescharges.AllowUserToAddRows = false;
            this.tabledescharges.AllowUserToDeleteRows = false;
            this.tabledescharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabledescharges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerodecharge,
            this.charge});
            this.tabledescharges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabledescharges.Location = new System.Drawing.Point(0, 0);
            this.tabledescharges.Name = "tabledescharges";
            this.tabledescharges.Size = new System.Drawing.Size(653, 242);
            this.tabledescharges.TabIndex = 0;
            // 
            // numerodecharge
            // 
            this.numerodecharge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numerodecharge.HeaderText = "N°";
            this.numerodecharge.Name = "numerodecharge";
            // 
            // charge
            // 
            this.charge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.charge.HeaderText = "Charge (KN)";
            this.charge.Name = "charge";
            this.charge.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // sucdc
            // 
            this.sucdc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sucdc.Location = new System.Drawing.Point(0, 190);
            this.sucdc.Name = "sucdc";
            this.sucdc.Size = new System.Drawing.Size(92, 41);
            this.sucdc.TabIndex = 1;
            this.sucdc.Text = "Supprimer un cas de charge";
            this.sucdc.UseVisualStyleBackColor = true;
            // 
            // ajoutercharge
            // 
            this.ajoutercharge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ajoutercharge.Location = new System.Drawing.Point(0, 149);
            this.ajoutercharge.Name = "ajoutercharge";
            this.ajoutercharge.Size = new System.Drawing.Size(92, 41);
            this.ajoutercharge.TabIndex = 2;
            this.ajoutercharge.Text = "Ajouter";
            this.ajoutercharge.UseVisualStyleBackColor = true;
            // 
            // chargesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 431);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "chargesform";
            this.Text = "chargesform";
            this.Load += new System.EventHandler(this.chargesform_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabledescharges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button renitialisertdc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tabledescharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodecharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn charge;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ajoutercharge;
        private System.Windows.Forms.Button sucdc;
    }
}