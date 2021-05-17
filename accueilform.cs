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
        public pieuprofile ppfile=new pieuprofile();
        public session session=new session();
    

        public accueilform()
        {
            InitializeComponent();
           
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
            PrepareTooltips();
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

        private void enregistrer_Click(object sender, EventArgs e)
        {

        }

        private void enregistrersous_Click(object sender, EventArgs e)
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

                    file.nbformations = touslesforms.snbformations;
                    file.formations = touslesforms.sformationsd;

                    file.classepieu = touslesforms.spropf.classesdepieuxcb.Text;
                    file.categoriepieu = touslesforms.spropf.categoriedepieuxcb.Text;

                    file.nbsondages = touslesforms.snbsondages;
                    file.tdd = touslesforms.stddd;

                    
                    session.Files.Add(file);
                    Serialise.jsonserialise(file,newfilename);

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

                touslesforms.snbformations= file.nbformations;
                touslesforms.sformationsd= file.formations;

                touslesforms.spropf.classesdepieuxcb.Text= file.classepieu;
                touslesforms.spropf.categoriedepieuxcb.Text= file.categoriepieu;

                touslesforms.snbsondages= file.nbsondages;
                touslesforms.stddd= file.tdd;

                //Mettre à jour la table des formations de l'onglet propriété
                //Mettre à jour la table des données de sondage avant de mettre à jour le nombre de sondage
                touslesforms.stddd = file.tdd;

                session.Files.Add(file);

            }
        }
    }
}
