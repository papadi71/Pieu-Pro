using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace Pieu_Pro
{
    
    public partial class parametressondagesform : Form
    {
        public  parametressondagesform sparametressondagesform ;
        
        

        public parametressondagesform()
        {
            InitializeComponent();
        }
       
        
        private void annulerbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void ajouterbutton_Click(object sender, EventArgs e)
        {
            int nbcolonne = touslesforms.snbsondages * 5;
            touslesforms.snbsondages = touslesforms.snbsondages + 1;
            touslesforms.ssondf.nbsondageslabel.Text = Convert.ToString(touslesforms.snbsondages);
            if (nomsondagetextbox.Text == "")
                nomsondagetextbox.Text = "Sondage" + Convert.ToString(touslesforms.snbsondages);
            string namesaisi =Convert.ToString( nomsondagetextbox.Text);
            if (touslesforms.stddd.Keys.Contains(namesaisi))
            {

                MessageBox.Show("Il existe déja un sondage portant ce nom! Veillez entrer un autre nom sondage!");
                touslesforms.snbsondages = touslesforms.snbsondages - 1;
                touslesforms.ssondf.nbsondageslabel.Text = Convert.ToString(touslesforms.snbsondages);
            }
            else
            {
                string nomsondage = nomsondagetextbox.Text;
               
                int ligne = touslesforms.stddf.tabledesdonneesgrid.RowCount; ;

                float cotetetesondage = float.Parse(cotetetesondagetextbox.Text);
                float profondeur = float.Parse(profondeursondagetextbox.Text);
                float pas = float.Parse(passondagetextbox.Text);


                //Création d'une instance PMT
                PMT pressio = new PMT();
                pressio.cotetete = cotetetesondage;
                pressio.nom = nomsondage;
                pressio.profondeur = profondeur;
                //pressio.basesformationsp=new Dictionary<string, float>();

                //mise à jour du dictionnaire des formations et du dictionnaire baseformation de pressio
                for(int k=0; k < touslesforms.snbformations; k++)
                {
                    //touslesforms.stdddstockage[name].basesformationsp.Keys
                    if ((bool)paraprofinterfacesdgv[1, k].Value == true)
                    {
                        pressio.basesformationsp.Add(Convert.ToString(paraprofinterfacesdgv[0, k].Value), float.Parse(Convert.ToString(paraprofinterfacesdgv[2, k].Value)));
                        

                       // if (touslesforms.sformationsd.Keys.Contains(Convert.ToString(paraprofinterfacesdgv[0, k].Value)))
                            touslesforms.sformationsd[Convert.ToString(paraprofinterfacesdgv[0, k].Value)].cotesbase.Add(cotetetesondage - float.Parse(Convert.ToString(paraprofinterfacesdgv[2, k].Value)));
                       /* else
                        {
                            touslesforms.sformationsd.Add(Convert.ToString(paraprofinterfacesdgv[0, k].Value), new formation());
                            touslesforms.sformationsd[Convert.ToString(paraprofinterfacesdgv[0, k].Value)].cotesbase.Add(cotetetesondage-float.Parse(Convert.ToString(paraprofinterfacesdgv[2, k].Value)));
                        }*/
                    }
                    
                }

                //Mise à jour du dictionnaire avec un nouveau sondage
                touslesforms.stddd.Add(nomsondage, pressio);

                //Ecriture dan le datagridview
                touslesforms.stddf.tabledesdonneesgrid.ColumnCount = nbcolonne + 5;
                touslesforms.stddf.tabledesdonneesgrid.RowCount = 100;

                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 0, 0].Value = nomsondage;
                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 0, 1].Value = "cote tête";
                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 1, 1].Value = cotetetesondage;

                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 0, 2].Value = "Cote(m)";
                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 1, 2].Value = "Profondeur(m)";
                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 2, 2].Value = "Em(MPa)";
                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 3, 2].Value = "pl(MPa)";
                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 4, 2].Value = "pf(MPa)";

                

                //Création des nuages de points Em et pl=f(Z)
                //touslesforms.ssondf.emchart.Series.Add(nomsondage);
                //touslesforms.ssondf.emchart.Series[nomsondage].ChartType = SeriesChartType.Point;

                //touslesforms.ssondf.plchart.Series.Add(nomsondage);
                //touslesforms.ssondf.plchart.Series[nomsondage].ChartType = SeriesChartType.Point;

                for (int i = 1; i * pas <= int.Parse(profondeursondagetextbox.Text); i++)
                {
                    touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 1, 2 + i].Value = i * pas;
                    touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 0, 2 + i].Value = cotetetesondage - i*pas;

                }



                //touslesforms.snbsondages = touslesforms.snbsondages + 1;
                //touslesforms.ssondf.nbsondageslabel.Text = Convert.ToString(touslesforms.snbsondages);

                this.Visible = false; 
                this.Close();
               
                if (touslesforms.stddf.Visible == false)
                    touslesforms.stddf.ShowDialog();
               

            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cotetetesondagetextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void profondeursondagetextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void passondagetextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

     
    }
}
