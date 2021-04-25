
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nbsondageslabel = new System.Windows.Forms.Label();
            this.tablededonneesfenetre = new System.Windows.Forms.Button();
            this.supprimertouslessondagesfenetre = new System.Windows.Forms.Button();
            this.supprimerunsondagefenetre = new System.Windows.Forms.Button();
            this.ajouterunsondagefenetre = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.plchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.emchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emchart)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(683, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 425);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de sondages:";
            // 
            // nbsondageslabel
            // 
            this.nbsondageslabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nbsondageslabel.Location = new System.Drawing.Point(0, 386);
            this.nbsondageslabel.Name = "nbsondageslabel";
            this.nbsondageslabel.Size = new System.Drawing.Size(71, 39);
            this.nbsondageslabel.TabIndex = 4;
            this.nbsondageslabel.Text = "0";
            // 
            // tablededonneesfenetre
            // 
            this.tablededonneesfenetre.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablededonneesfenetre.Location = new System.Drawing.Point(0, 189);
            this.tablededonneesfenetre.Name = "tablededonneesfenetre";
            this.tablededonneesfenetre.Size = new System.Drawing.Size(71, 63);
            this.tablededonneesfenetre.TabIndex = 3;
            this.tablededonneesfenetre.Text = "Table des données";
            this.tablededonneesfenetre.UseVisualStyleBackColor = true;
            this.tablededonneesfenetre.Click += new System.EventHandler(this.button4_Click);
            // 
            // supprimertouslessondagesfenetre
            // 
            this.supprimertouslessondagesfenetre.Dock = System.Windows.Forms.DockStyle.Top;
            this.supprimertouslessondagesfenetre.Location = new System.Drawing.Point(0, 126);
            this.supprimertouslessondagesfenetre.Name = "supprimertouslessondagesfenetre";
            this.supprimertouslessondagesfenetre.Size = new System.Drawing.Size(71, 63);
            this.supprimertouslessondagesfenetre.TabIndex = 2;
            this.supprimertouslessondagesfenetre.Text = "Supprimer tous les sondages";
            this.supprimertouslessondagesfenetre.UseVisualStyleBackColor = true;
            this.supprimertouslessondagesfenetre.Click += new System.EventHandler(this.button3_Click);
            // 
            // supprimerunsondagefenetre
            // 
            this.supprimerunsondagefenetre.Dock = System.Windows.Forms.DockStyle.Top;
            this.supprimerunsondagefenetre.Location = new System.Drawing.Point(0, 63);
            this.supprimerunsondagefenetre.Name = "supprimerunsondagefenetre";
            this.supprimerunsondagefenetre.Size = new System.Drawing.Size(71, 63);
            this.supprimerunsondagefenetre.TabIndex = 1;
            this.supprimerunsondagefenetre.Text = "Supprimer un sondage";
            this.supprimerunsondagefenetre.UseVisualStyleBackColor = true;
            this.supprimerunsondagefenetre.Click += new System.EventHandler(this.button2_Click);
            // 
            // ajouterunsondagefenetre
            // 
            this.ajouterunsondagefenetre.Dock = System.Windows.Forms.DockStyle.Top;
            this.ajouterunsondagefenetre.Location = new System.Drawing.Point(0, 0);
            this.ajouterunsondagefenetre.Name = "ajouterunsondagefenetre";
            this.ajouterunsondagefenetre.Size = new System.Drawing.Size(71, 63);
            this.ajouterunsondagefenetre.TabIndex = 0;
            this.ajouterunsondagefenetre.Text = "Ajouter un sondage";
            this.ajouterunsondagefenetre.UseVisualStyleBackColor = true;
            this.ajouterunsondagefenetre.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.plchart, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.emchart, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(757, 431);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // plchart
            // 
            chartArea1.Name = "ChartArea1";
            this.plchart.ChartAreas.Add(chartArea1);
            this.plchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.plchart.Legends.Add(legend1);
            this.plchart.Location = new System.Drawing.Point(343, 3);
            this.plchart.Name = "plchart";
            this.plchart.Size = new System.Drawing.Size(334, 425);
            this.plchart.TabIndex = 3;
            this.plchart.Text = "chart2";
            // 
            // emchart
            // 
            chartArea2.Name = "ChartArea1";
            this.emchart.ChartAreas.Add(chartArea2);
            this.emchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.emchart.Legends.Add(legend2);
            this.emchart.Location = new System.Drawing.Point(3, 3);
            this.emchart.Name = "emchart";
            this.emchart.Size = new System.Drawing.Size(334, 425);
            this.emchart.TabIndex = 2;
            this.emchart.Text = "chart1";
            // 
            // sondagesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 431);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "sondagesform";
            this.Text = "sondagesform";
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emchart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tablededonneesfenetre;
        private System.Windows.Forms.Button supprimertouslessondagesfenetre;
        private System.Windows.Forms.Button supprimerunsondagefenetre;
        private System.Windows.Forms.Button ajouterunsondagefenetre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.DataVisualization.Charting.Chart plchart;
        public System.Windows.Forms.DataVisualization.Charting.Chart emchart;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label nbsondageslabel;

        
    }
}