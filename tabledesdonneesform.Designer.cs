
namespace Pieu_Pro
{
    partial class tabledesdonneesform
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabledesdonneesgrid = new System.Windows.Forms.DataGridView();
            this.tddggvcontextmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnSondageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnSondageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerTousLesSondagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tabledesdonneesgrid)).BeginInit();
            this.tddggvcontextmenustrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabledesdonneesgrid
            // 
            this.tabledesdonneesgrid.AllowUserToOrderColumns = true;
            this.tabledesdonneesgrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabledesdonneesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabledesdonneesgrid.ContextMenuStrip = this.tddggvcontextmenustrip;
            this.tabledesdonneesgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabledesdonneesgrid.Location = new System.Drawing.Point(3, 33);
            this.tabledesdonneesgrid.Name = "tabledesdonneesgrid";
            this.tabledesdonneesgrid.Size = new System.Drawing.Size(794, 384);
            this.tabledesdonneesgrid.TabIndex = 1;
            this.tabledesdonneesgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabledesdonneesgrid_CellContentClick);
            this.tabledesdonneesgrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabledesdonneesgrid_CellValueChanged);
            // 
            // tddggvcontextmenustrip
            // 
            this.tddggvcontextmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.couperToolStripMenuItem,
            this.ajouterUnSondageToolStripMenuItem,
            this.supprimerUnSondageToolStripMenuItem,
            this.supprimerTousLesSondagesToolStripMenuItem});
            this.tddggvcontextmenustrip.Name = "tddggvcontextmenustrip";
            this.tddggvcontextmenustrip.Size = new System.Drawing.Size(226, 136);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.couperToolStripMenuItem.Text = "Couper";
            // 
            // ajouterUnSondageToolStripMenuItem
            // 
            this.ajouterUnSondageToolStripMenuItem.Name = "ajouterUnSondageToolStripMenuItem";
            this.ajouterUnSondageToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.ajouterUnSondageToolStripMenuItem.Text = "Ajouter un Sondage";
            this.ajouterUnSondageToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnSondageToolStripMenuItem_Click);
            // 
            // supprimerUnSondageToolStripMenuItem
            // 
            this.supprimerUnSondageToolStripMenuItem.Name = "supprimerUnSondageToolStripMenuItem";
            this.supprimerUnSondageToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.supprimerUnSondageToolStripMenuItem.Text = "Supprimer un sondage";
            // 
            // supprimerTousLesSondagesToolStripMenuItem
            // 
            this.supprimerTousLesSondagesToolStripMenuItem.Name = "supprimerTousLesSondagesToolStripMenuItem";
            this.supprimerTousLesSondagesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.supprimerTousLesSondagesToolStripMenuItem.Text = "Supprimer tous les sondages";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabledesdonneesgrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tabledesdonneesform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "tabledesdonneesform";
            this.Text = "Table des données de sondages";
            this.Load += new System.EventHandler(this.tabledesdonneesform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabledesdonneesgrid)).EndInit();
            this.tddggvcontextmenustrip.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView tabledesdonneesgrid;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip tddggvcontextmenustrip;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnSondageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnSondageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerTousLesSondagesToolStripMenuItem;
    }
}