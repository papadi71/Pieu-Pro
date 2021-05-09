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
    public partial class accueilform : Form
    {
        
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
        }
    }
}
