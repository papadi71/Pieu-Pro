
namespace Pieu_Pro
{
    partial class sondagesform
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea emchartarea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend emlegend = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea pfchartarea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend pflegend = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea plchartarea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend pllegend = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nbsondageslabel = new System.Windows.Forms.Label();
            this.tablededonneesfenetre = new System.Windows.Forms.Button();
            this.supprimertouslessondagesfenetre = new System.Windows.Forms.Button();
            this.supprimerunsondagefenetre = new System.Windows.Forms.Button();
            this.ajouterunsondagefenetre = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pfchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.plchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plchart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 431);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nbsondageslabel);
            this.panel2.Controls.Add(this.tablededonneesfenetre);
            this.panel2.Controls.Add(this.supprimertouslessondagesfenetre);
            this.panel2.Controls.Add(this.supprimerunsondagefenetre);
            this.panel2.Controls.Add(this.ajouterunsondagefenetre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(684, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 425);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de sondages:";
            // 
            // nbsondageslabel
            // 
            this.nbsondageslabel.AutoSize = true;
            this.nbsondageslabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nbsondageslabel.Location = new System.Drawing.Point(0, 412);
            this.nbsondageslabel.Name = "nbsondageslabel";
            this.nbsondageslabel.Size = new System.Drawing.Size(13, 13);
            this.nbsondageslabel.TabIndex = 4;
            this.nbsondageslabel.Text = "0";
            // 
            // tablededonneesfenetre
            // 
            this.tablededonneesfenetre.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablededonneesfenetre.Location = new System.Drawing.Point(0, 189);
            this.tablededonneesfenetre.Name = "tablededonneesfenetre";
            this.tablededonneesfenetre.Size = new System.Drawing.Size(70, 63);
            this.tablededonneesfenetre.TabIndex = 3;
            this.tablededonneesfenetre.Text = "Table des données";
            this.tablededonneesfenetre.UseVisualStyleBackColor = true;
            this.tablededonneesfenetre.Click += new System.EventHandler(this.tablededonneesfenetre_Click);
            // 
            // supprimertouslessondagesfenetre
            // 
            this.supprimertouslessondagesfenetre.Dock = System.Windows.Forms.DockStyle.Top;
            this.supprimertouslessondagesfenetre.Location = new System.Drawing.Point(0, 126);
            this.supprimertouslessondagesfenetre.Name = "supprimertouslessondagesfenetre";
            this.supprimertouslessondagesfenetre.Size = new System.Drawing.Size(70, 63);
            this.supprimertouslessondagesfenetre.TabIndex = 2;
            this.supprimertouslessondagesfenetre.Text = "Supprimer tous les sondages";
            this.supprimertouslessondagesfenetre.UseVisualStyleBackColor = true;
            this.supprimertouslessondagesfenetre.Click += new System.EventHandler(this.supprimertouslessondagesfenetre_Click);
            // 
            // supprimerunsondagefenetre
            // 
            this.supprimerunsondagefenetre.Dock = System.Windows.Forms.DockStyle.Top;
            this.supprimerunsondagefenetre.Location = new System.Drawing.Point(0, 63);
            this.supprimerunsondagefenetre.Name = "supprimerunsondagefenetre";
            this.supprimerunsondagefenetre.Size = new System.Drawing.Size(70, 63);
            this.supprimerunsondagefenetre.TabIndex = 1;
            this.supprimerunsondagefenetre.Text = "Supprimer un sondage";
            this.supprimerunsondagefenetre.UseVisualStyleBackColor = true;
            this.supprimerunsondagefenetre.Click += new System.EventHandler(this.supprimerunsondagefenetre_Click);
            // 
            // ajouterunsondagefenetre
            // 
            this.ajouterunsondagefenetre.Dock = System.Windows.Forms.DockStyle.Top;
            this.ajouterunsondagefenetre.Location = new System.Drawing.Point(0, 0);
            this.ajouterunsondagefenetre.Name = "ajouterunsondagefenetre";
            this.ajouterunsondagefenetre.Size = new System.Drawing.Size(70, 63);
            this.ajouterunsondagefenetre.TabIndex = 0;
            this.ajouterunsondagefenetre.Text = "Ajouter un sondage";
            this.ajouterunsondagefenetre.UseVisualStyleBackColor = true;
            this.ajouterunsondagefenetre.Click += new System.EventHandler(this.ajouterunsondagefenetre_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.823529F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.17647F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(675, 425);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Données de Sondages pressiométriques";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.emchart, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.pfchart, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.plchart, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(669, 391);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pression de fluage nette";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pression limite nette";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emchart
            // 
            emchartarea.Name = "emchartarea";
            this.emchart.ChartAreas.Add(emchartarea);
            this.emchart.Dock = System.Windows.Forms.DockStyle.Fill;
            emlegend.Name = "emlegend";
            this.emchart.Legends.Add(emlegend);
            this.emchart.Location = new System.Drawing.Point(3, 25);
            this.emchart.Name = "emchart";
            this.emchart.Size = new System.Drawing.Size(217, 342);
            this.emchart.TabIndex = 4;
            this.emchart.Text = "emchart";
            // 
            // pfchart
            // 
            pfchartarea.Name = "pfchartarea";
            this.pfchart.ChartAreas.Add(pfchartarea);
            this.pfchart.Dock = System.Windows.Forms.DockStyle.Fill;
            pflegend.Name = "pflegend";
            this.pfchart.Legends.Add(pflegend);
            this.pfchart.Location = new System.Drawing.Point(448, 25);
            this.pfchart.Name = "pfchart";
            this.pfchart.Size = new System.Drawing.Size(218, 342);
            this.pfchart.TabIndex = 6;
            this.pfchart.Text = "pfchart";
            // 
            // plchart
            // 
            plchartarea.Name = "plchartarea";
            this.plchart.ChartAreas.Add(plchartarea);
            this.plchart.Dock = System.Windows.Forms.DockStyle.Fill;
            pllegend.Name = "pllegend";
            this.plchart.Legends.Add(pllegend);
            this.plchart.Location = new System.Drawing.Point(226, 25);
            this.plchart.Name = "plchart";
            this.plchart.Size = new System.Drawing.Size(216, 342);
            this.plchart.TabIndex = 5;
            this.plchart.Text = "plchart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Module pressiométrique";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sondagesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 431);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "sondagesform";
            this.Text = "sondagesform";
            this.Load += new System.EventHandler(this.sondagesform_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plchart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label nbsondageslabel;
        private System.Windows.Forms.Button tablededonneesfenetre;
        private System.Windows.Forms.Button supprimertouslessondagesfenetre;
        private System.Windows.Forms.Button supprimerunsondagefenetre;
        private System.Windows.Forms.Button ajouterunsondagefenetre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.DataVisualization.Charting.Chart emchart;
        public System.Windows.Forms.DataVisualization.Charting.Chart pfchart;
        public System.Windows.Forms.DataVisualization.Charting.Chart plchart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}