using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Pieu_Pro
{
    public partial class sondagesform : Form
    {
        //public static parametressondagesform parametressondageform=new parametressondagesform();
        public sondagesform()
        {
            InitializeComponent();
        }

        
        private void sondagesform_Load(object sender, EventArgs e)
        {

        }

        private void ajouterunsondagefenetre_Click(object sender, EventArgs e)
        {
            new parametressondagesform().ShowDialog();
        }

        private void supprimertouslessondagesfenetre_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous supprimer tous les sondages ?", "Supprimer tous les sondages", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(touslesforms.snbsondages > 0)
                {
                    touslesforms.stddf.tabledesdonneesgrid.Rows.Clear();
                    touslesforms.stddf.tabledesdonneesgrid.Columns.Clear();
                    touslesforms.stddd.Clear();
                    touslesforms.ssondf.emchart.Series.Clear();
                    touslesforms.ssondf.plchart.Series.Clear();
                    touslesforms.ssondf.pfchart.Series.Clear();
                    touslesforms.snbsondages = 0;
                    touslesforms.ssondf.nbsondageslabel.Text = Convert.ToString(touslesforms.snbsondages);
                    MessageBox.Show("Tous les sondages ont été supprimés avec succès");

                }
                    
            }
        }

        private void supprimerunsondagefenetre_Click(object sender, EventArgs e)
        {
            new supprimerunsondageform().ShowDialog();
        }

        private void tablededonneesfenetre_Click(object sender, EventArgs e)
        {
            if (touslesforms.snbsondages == 0)
                MessageBox.Show("La table des sondages est vide");
            else
            {
                tabledesdonneesform tabledesdonneesform = touslesforms.stddf;
                //tabledesdonneesform = parametressondageform.stddf;
                // tabledesdonneesform.tabledesdonneesgrid = tabledesdonneesform.stdddgv;
                tabledesdonneesform.ShowDialog();
            }
        }
    }
}
