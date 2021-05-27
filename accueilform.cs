using Pieu_Pro.Classes_pour_enregistrements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pieu_Pro
{
    public partial class accueilform : Form
    {
       
        public session session;
        public pieuprofile currentfile;
        



        public accueilform()
        {
            InitializeComponent();
            PrepareTooltips();
            session = new session();
            currentfile = new pieuprofile("Sans titre");
            session.Files.Add(currentfile);
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void proprietefenetrebutton_Click(object sender, EventArgs e)
        {
            openchildform(touslesforms.spropf);

        }

        private void sondagefenetrebutton_Click(object sender, EventArgs e)
        {
            openchildform(touslesforms.ssondf);

        }

        private void chargefenetrebutton_Click(object sender, EventArgs e)
        {
            openchildform(touslesforms.schaf);
        }

        private void calculfenetrebutton_Click(object sender, EventArgs e)
        {
          openchildform(touslesforms.scalf);
        }

       
        private Form activeform = null;
        private void openchildform (Form childform) 
        {
            if (activeform == childform) { }
            //activeform.Show();à effacer
            else
            {    //(activeform != null) à effacer
                //activeform.Close(); à effacer

                activeform = childform;
                childform.TopLevel = false;
                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Dock = DockStyle.Fill;
                affichagepanel.Controls.Add(childform);
                affichagepanel.Tag = childform;
                childform.BringToFront();
                childform.Show();
            }
            


        }

        private void editionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void accueilform_Load(object sender, EventArgs e)
        {
            openchildform(touslesforms.spropf);

            //currentfile.FileName = "Sans Titre";
            session.Files.Add(currentfile);
            //this.Text = currentfile.SafeFileName;
            
        }
        Label Lbl = new Label();
        private void nouveauprojet_MouseHover(object sender, EventArgs e)
        {
            nouveauprojettt.SetToolTip(nouveauprojet,"Nouveau Projet");
        }

        public System.Windows.Forms.ToolTip ToolTip1;
       
        

        public void PrepareTooltips()
        {
            ToolTip1 = new System.Windows.Forms.ToolTip();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button && ctrl.Tag is string)
                {
                    ctrl.MouseHover += new EventHandler(delegate (Object o, EventArgs a)
                    {
                        var btn = (Control)o;
                        ToolTip1.SetToolTip(btn, btn.Tag.ToString());
                    });
                }
            }
        }

        private void ouvrirunprojetexistant_MouseHover(object sender, EventArgs e)
        {
            nouveauprojettt.SetToolTip(ouvrirunprojetexistant, "Ouvrir un projet existant");
        }

        private void enregistrer_MouseHover(object sender, EventArgs e)
        {
            nouveauprojettt.SetToolTip(enregistrer, "Enregistrer");
        }

        private void enregistrersous_MouseHover(object sender, EventArgs e)
        {
            nouveauprojettt.SetToolTip(enregistrersous, "Enregistrer sous");
        }

        private void tabledesdonnees_MouseHover(object sender, EventArgs e)
        {
            nouveauprojettt.SetToolTip(tabledesdonnees, "Table des données");
        }

        private void tabledesdonnees_Click(object sender, EventArgs e)
        {
            if (touslesforms.snbsondages == 0)
                MessageBox.Show("La table des sondages est vide");
            else
            {
                //tabledesdonneesform tabledesdonneesform = touslesforms.stddf;
                
                // tabledesdonneesform.tabledesdonneesgrid = tabledesdonneesform.stdddgv;
                touslesforms.stddf.ShowDialog();
            }
        }

        public void enregistrer_Click(object sender, EventArgs e)
        {
            if (session.Files[0].FileName=="Sans titre")
            {
                enregistrersous.PerformClick();
            }
            else
            {
                var newfilename = session.Files[0].FileName;

                //effacer le fichier existant dans le repertoire newfilename
                if (File.Exists(newfilename)) File.Delete(newfilename);

                var file = new pieuprofile(newfilename);
               
                file.nom = touslesforms.spropf.nomcalcultxtbox.Text;
                file.methodedecalcul = touslesforms.spropf.methodedecalculcb.Text;
                file.diametrepieu = float.Parse(touslesforms.spropf.diametretxtbox.Text);

                file.nbformations = touslesforms.snbformations;
                file.formations = touslesforms.sformationsd;

                file.classepieu = touslesforms.spropf.classesdepieuxcb.Text;
                file.categoriepieu = touslesforms.spropf.categoriedepieuxcb.Text;

                file.nbsondages = touslesforms.snbsondages;
                file.tdd = touslesforms.stddd;

                session.Files.Clear();
                session.Files.Add(file);
                Serialise.jsonserialise(file, newfilename);
                this.Text = file.SafeFileName;

            }

        }

        public void enregistrersous_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.DefaultExt = "ppr";
            sfd.Filter = "Pieu-pro files (*.ppr)|*.ppr";
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var newfilename = sfd.FileName;

                //var alreadyexist = false;
                //Si le fichier de ce nom existe deja
                if (true)
                {
                    var file = new pieuprofile(newfilename);
                    //file.FileName = newfilename;
                    file.nom = touslesforms.spropf.nomcalcultxtbox.Text;
                    file.methodedecalcul = touslesforms.spropf.methodedecalculcb.Text;
                    file.diametrepieu = float.Parse(touslesforms.spropf.diametretxtbox.Text);

                    file.nbformations = touslesforms.snbformations;
                    file.formations = touslesforms.sformationsd;

                    file.classepieu = touslesforms.spropf.classesdepieuxcb.Text;
                    file.categoriepieu = touslesforms.spropf.categoriedepieuxcb.Text;

                    file.nbsondages = touslesforms.snbsondages;
                    file.tdd = touslesforms.stddd;

                    session.Files.Clear();
                    session.Files.Add(file);
                    Serialise.jsonserialise(file, newfilename);
                    this.Text = file.SafeFileName;
                }
                else 
                {
                    
                }
                
            }
        }

        private void ouvrirunprojetexistant_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.DefaultExt = "ppr";
            ofd.Filter = "Pieu-pro files (*.ppr)|*.ppr";
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var ofilename = ofd.FileName;
                pieuprofile file = new pieuprofile(ofilename);
                file =(pieuprofile) Serialise.jsondeserialise(typeof(pieuprofile),ofilename);

                touslesforms.spropf.nomcalcultxtbox.Text= file.nom;
                touslesforms.spropf.methodedecalculcb.Text= file.methodedecalcul;

                touslesforms.snbformations = 0;

                touslesforms.spropf.diametretxtbox.Text = Convert.ToString(file.diametrepieu);
                touslesforms.spropf.classesdepieuxcb.Text= file.classepieu;
                touslesforms.spropf.categoriedepieuxcb.Text= file.categoriepieu;

               // touslesforms.snbsondages = 0;
                touslesforms.stddd= file.tdd;

                //Mettre à jour la table des formations de l'onglet propriété
                //Mettre à jour la table des données de sondage avant de mettre à jour le nombre de sondage


                //touslesforms.spropf.tabledesformations.Rows.Clear();
                touslesforms.spropf.tabledesformations.RowCount = 0;
                int k = 0; 
                foreach (string formation in file.formations.Keys)
                {

                    touslesforms.spropf.tabledesformations.RowCount++;
                    touslesforms.spropf.tabledesformations[0, k].Value = formation;
                    proprietesform.setCellComboBoxItems(touslesforms.spropf.tabledesformations, k, 1, touslesforms.sclassesdesol);
                    touslesforms.spropf.tabledesformations[1, k].Value = file.formations[formation].classedesol;
                    k++;
                    touslesforms.snbformations++;
                }
                touslesforms.spropf.nbflabel.Text = Convert.ToString(touslesforms.snbformations);
                touslesforms.sformationsd = file.formations;


                touslesforms.stddf.tabledesdonneesgrid.Rows.Clear();
                int nbcolonne = 0;
                touslesforms.stddf.tabledesdonneesgrid.RowCount = 100;
                foreach (string pressio in file.tdd.Keys)
                {
                    touslesforms.stddf.tabledesdonneesgrid.ColumnCount = nbcolonne + 5;
                  

                    touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 0, 0].Value = pressio;
                    touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 0, 1].Value = "cote tête";
                    touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 1, 1].Value = file.tdd[pressio].cotetete;

                    touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 0, 2].Value = "Cote(m)";
                    touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 1, 2].Value = "Profondeur(m)";
                    touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 2, 2].Value = "Em(MPa)";
                    touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 3, 2].Value = "pl(MPa)";
                    touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 4, 2].Value = "pf(MPa)";
                    
                  
                    for(int i=0;i< file.tdd[pressio].cotes.Count();i++)
                    {
                        touslesforms.stddf.tabledesdonneesgrid[nbcolonne, 3 + i].Value = file.tdd[pressio].cotes[i] ;
                        touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 1, 3 + i].Value = file.tdd[pressio].cotetete- file.tdd[pressio].cotes[i];
                        touslesforms.stddf.tabledesdonneesgrid[nbcolonne+2, 3 + i].Value = file.tdd[pressio].emmpa[i];
                        touslesforms.stddf.tabledesdonneesgrid[nbcolonne+3, 3 + i].Value = file.tdd[pressio].plmpa[i];
                        touslesforms.stddf.tabledesdonneesgrid[nbcolonne+4, 3 + i].Value = file.tdd[pressio].pfmpa[i];

                    }

                    //touslesforms.snbsondages ++;
                    touslesforms.ssondf.nbsondageslabel.Text = Convert.ToString(touslesforms.snbsondages);
                    nbcolonne = nbcolonne + 5;
                   
                }
                touslesforms.snbsondages = file.nbsondages;
                touslesforms.ssondf.nbsondageslabel.Text = Convert.ToString(touslesforms.snbsondages);
                touslesforms.stddd = file.tdd;
                this.Text =file.SafeFileName+" - Pieu-Pro";

                session.Files.Clear();
                session.Files.Add(file);

            }
        }

        public void nouveauprojet_Click(object sender, EventArgs e)
        {
            if (true && MessageBox.Show("Voulez-vous enregistrer le fichier en cours ?", "Enregistrer fichier en cours", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                enregistrer.PerformClick();
            }
            
            

            touslesforms.stddd.Clear();
            touslesforms.stdddstockage.Clear();
            touslesforms.sformationsd.Clear();
            touslesforms.snbsondages = 0;

            touslesforms.spropf = new proprietesform();
            touslesforms.ssondf = new sondagesform();
            touslesforms.schaf = new chargesform();
            touslesforms.scalf = new calculform();
            touslesforms.stddf = new tabledesdonneesform();

            proprietefenetrebutton.PerformClick();

            var filename = "Sans titre";
            var newpieuprofile = new pieuprofile(filename);
            session.Files.Clear();
            currentfile = newpieuprofile;
            session.Files.Add(newpieuprofile);
            this.Text = newpieuprofile.FileName + "Pieu-Pro";

        }
    }
}
