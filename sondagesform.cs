﻿using System;
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

        private void button4_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            new parametressondagesform().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new supprimerunsondageform().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous supprimer tous les sondages ?","Supprimer tous les sondages",MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {

            }
        }

        
    }
}