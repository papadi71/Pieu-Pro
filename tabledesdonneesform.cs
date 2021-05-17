using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumSharp;
using MathNet;
using MathNet.Numerics.Statistics;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;




namespace Pieu_Pro
{
    
    public partial class tabledesdonneesform : Form
    {
       
        //public   DataGridView stdddgv; 
        public tabledesdonneesform()
        {
            InitializeComponent();
            

        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabledesdonneesgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    
           
        }
        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabledesdonneesform_Load(object sender, EventArgs e)
        {
            //tabledesdonneesgrid = touslesform.stddf.tabledesdonneesgrid;

        }

        private void tabledesdonneesgrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            float toitmoyen;
            /*
            Chart legendchart = new Chart();
            legendchart.Dock = DockStyle.Fill;
            legendchart.Legends.Add(new Legend());
            legendchart.ChartAreas.Add(new ChartArea());
            legendchart.Legends[0].Docking = Docking.Left;
            legendchart.Legends[0].LegendStyle = LegendStyle.Column;
            touslesforms.ssondf.sondagelegendepanel.Controls.Add(legendchart);
            */
            //Copie de l'ancien stddfd
            touslesforms.stdddstockage.Clear();
            foreach (string kkey in touslesforms.stddd.Keys)
            {
                touslesforms.stdddstockage.Add(kkey,new PMT());
                

                //touslesforms.stdddstockage[kkey].basesformations.Clear();
                foreach ( string formation in touslesforms.stddd[kkey].basesformations.Keys)
                {

                    //MessageBox.Show(kkey+" : " + formation);
                    if (touslesforms.stdddstockage[kkey].basesformations.ContainsKey(formation)==false)
                    {
                        touslesforms.stdddstockage[kkey].basesformations.Add(formation, touslesforms.stddd[kkey].basesformations[formation]);
                       // MessageBox.Show(Convert.ToString(touslesforms.stddd[kkey].basesformations[formation]));
                    }
                    /*else
                    {
                        touslesforms.stddd[kkey].basesformations[formation] = touslesforms.stddd[kkey].basesformations[formation];
                        MessageBox.Show(Convert.ToString(touslesforms.stddd[kkey].basesformations[formation]));


                    }*/

                }
            }

            //touslesforms.stddd.Clear();
            touslesforms.ssondf.emchart.Series.Clear();
            touslesforms.ssondf.plchart.Series.Clear();
            touslesforms.ssondf.pfchart.Series.Clear();

            //Vider les cotes,em,pl,pf du dictionnaire des formations
            foreach (string key in touslesforms.sformationsd.Keys)
            {
                touslesforms.sformationsd[key].cotes.Clear();
                touslesforms.sformationsd[key].emmpa.Clear();
                touslesforms.sformationsd[key].plmpa.Clear();
                touslesforms.sformationsd[key].pfmpa.Clear();
            }

            //Opérations pour chaque sondage
            for (int i=0;i<touslesforms.snbsondages; i++) 
            {
                string name;
                PMT pressio = new PMT();
                float toit;

                /*pressio.cotes = new List<float>();
                pressio.emmpa = new List<float>();
                pressio.plmpa = new List<float>();
                pressio.pfmpa = new List<float>();
                pressio.basesformations = new Dictionary<string, float>();
                */


                if (touslesforms.stddf.tabledesdonneesgrid[5 * i, 0].Value != null)
                {
                    name = Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i, 0].Value);
                    pressio.nom = name;


                    //touslesforms.stddd.Add(name, pressio);

                    /*
                    legendchart.Series.Add(name);
                    legendchart.Series[name].LegendText = name;
                    legendchart.Legends[0].Name = name;
                    */
          
                    


                    touslesforms.ssondf.emchart.Series.Add(name);
                    touslesforms.ssondf.emchart.Series[name].ChartType = SeriesChartType.Point;
                    touslesforms.ssondf.emchart.Series[name].ChartArea = "emchartarea";
                    touslesforms.ssondf.emchart.ChartAreas["emchartarea"].AxisX.Title = "Em(MPa)";
                    //try { touslesforms.ssondf.emchart.ChartAreas["emchartarea"].AxisX.IsLogarithmic = true; } catch { }
                    touslesforms.ssondf.emchart.ChartAreas["emchartarea"].AxisY.Title = "Cote(m)";
                    touslesforms.ssondf.emchart.Series[name].LegendText = name;

                    touslesforms.ssondf.plchart.Series.Add(name);
                    touslesforms.ssondf.plchart.Series[name].ChartType = SeriesChartType.Point;
                    touslesforms.ssondf.plchart.Series[name].ChartArea = "plchartarea";
                    touslesforms.ssondf.plchart.ChartAreas["plchartarea"].AxisX.Title = "pl(MPa)";
                    //touslesforms.ssondf.plchart.ChartAreas["plchartarea"].AxisX.IsLogarithmic=true;
                    touslesforms.ssondf.plchart.ChartAreas["plchartarea"].AxisY.Title = "Cote(m)";
                    touslesforms.ssondf.plchart.Series[name].LegendText = name;

                    touslesforms.ssondf.pfchart.Series.Add(name);
                    touslesforms.ssondf.pfchart.Series[name].ChartType = SeriesChartType.Point;
                    touslesforms.ssondf.pfchart.Series[name].ChartArea = "pfchartarea";
                    touslesforms.ssondf.pfchart.ChartAreas["pfchartarea"].AxisX.Title = "pf(MPa)";
                    //touslesforms.ssondf.pfchart.ChartAreas["pfchartarea"].AxisX.IsLogarithmic = true;
                    touslesforms.ssondf.pfchart.ChartAreas["pfchartarea"].AxisY.Title = "Cote(m)";
                    touslesforms.ssondf.pfchart.Series[name].LegendText = name;

                    
                 

                    if (touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, 1].Value != null)
                    {
                        pressio.cotetete = float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, 1].Value));
                        
                    }

                    toit = pressio.cotetete;

                    //Comptage du nombre de lignes du sondage et détermination de la profondeur
                    int compteurligne = 3;
                    while (touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, compteurligne].Value != null && touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, 1].Value != null)
                    {
                        pressio.profondeur = float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, compteurligne].Value));

                        //Recalcul cote
                        //if (touslesforms.stddf.tabledesdonneesgrid[5 * i, compteurligne].Value != null) 
                        touslesforms.stddf.tabledesdonneesgrid[5 * i, compteurligne].Value = pressio.cotetete - float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, compteurligne].Value));
                        

                        //if (touslesforms.stddf.tabledesdonneesgrid[5 * i , compteurligne].Value != null)
                        pressio.cotes.Add(float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i, compteurligne].Value)));

                        float coteligne = float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i, compteurligne].Value));
                       //if (touslesforms.snbsondages > 1)
                        //{
                            foreach (string kkkey in touslesforms.stdddstockage[name].basesformations.Keys)
                            {
                                float basef = pressio.cotetete - touslesforms.stdddstockage[name].basesformations[kkkey];
                               

                                if (coteligne < toit && coteligne >= basef)
                                {
                                    touslesforms.sformationsd[kkkey].cotes.Add(coteligne);
                                }
                                toit = basef;
                            }
                        toit = pressio.cotetete;
                        //}




                        if (touslesforms.stddf.tabledesdonneesgrid[5 * i + 2, compteurligne].Value != null)
                        {
                            pressio.emmpa.Add(float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 2, compteurligne].Value)));
                            float em = float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 2, compteurligne].Value));
                            foreach (string kkkey in touslesforms.stdddstockage[name].basesformations.Keys)
                            {
                                float basef = pressio.cotetete - touslesforms.stdddstockage[name].basesformations[kkkey];
                                if (coteligne < toit && coteligne >= basef)
                                {
                                    touslesforms.sformationsd[kkkey].emmpa.Add(em);
                                }
                                toit = basef;
                            }
                            toit = pressio.cotetete;
                        }
                            


                        //Gérer les exceptions pour les cases non encore remplies
                        if (touslesforms.stddf.tabledesdonneesgrid[5 * i + 3, compteurligne].Value != null)
                        {
                            pressio.plmpa.Add(float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 3, compteurligne].Value)));
                            float pl = float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 3, compteurligne].Value));
                            foreach (string kkkey in touslesforms.stdddstockage[name].basesformations.Keys)
                            {
                                float basef = pressio.cotetete - touslesforms.stdddstockage[name].basesformations[kkkey];
                                if (coteligne < toit && coteligne >= basef)
                                {
                                    touslesforms.sformationsd[kkkey].plmpa.Add(pl);
                                }
                                toit = basef;
                            }
                            toit = pressio.cotetete;
                        }



                        if (touslesforms.stddf.tabledesdonneesgrid[5 * i + 4, compteurligne].Value != null) 
                        {
                            pressio.pfmpa.Add(float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 4, compteurligne].Value)));
                            float pf = float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 4, compteurligne].Value));
                            foreach (string kkkey in touslesforms.stdddstockage[name].basesformations.Keys)
                            {
                                float basef = pressio.cotetete - touslesforms.stdddstockage[name].basesformations[kkkey];
                                if (coteligne < toit && coteligne >= basef)
                                {
                                    touslesforms.sformationsd[kkkey].pfmpa.Add(pf);
                                }
                                toit = basef;
                            }
                            toit = pressio.cotetete;
                        }
                        

                        compteurligne = compteurligne + 1;
                        toit = pressio.cotetete;

                    }
                   

                    //mise à jour du dictionnaire
                    foreach (string f in touslesforms.stdddstockage[name].basesformations.Keys)
                    {
                        pressio.basesformations.Add(f, touslesforms.stdddstockage[name].basesformations[f]);
                        
                        //Mise à jour des cotes base de la formation f dans le dictionnaire des formations
                        float basef = pressio.cotetete - touslesforms.stdddstockage[name].basesformations[f];
                        touslesforms.sformationsd[f].cotesbase.Add(basef);
                    }
                    //touslesforms.stddd[name]= pressio;
                    if (touslesforms.stddd.ContainsKey(name))
                    {
                        touslesforms.stddd.Remove(name);
                        touslesforms.stddd.Add(name, pressio);
                    } 
                    else
                        touslesforms.stddd.Add(name, pressio);

                    //Tracer courbe en fonction des sondages
                    if (compteurligne > 3)
                    {
                        //Tracer Em=f(cote) et pl=f(cote) 
                        if (pressio.emmpa.Count() == pressio.cotes.Count())
                            touslesforms.ssondf.emchart.Series[name].Points.DataBindXY(pressio.emmpa, pressio.cotes); 

                        //Tracer pl=f(cote) et pl=f(cote) 
                        if (pressio.plmpa.Count() == pressio.cotes.Count())
                            touslesforms.ssondf.plchart.Series[name].Points.DataBindXY(pressio.plmpa, pressio.cotes); 
                    
                        //Tracer pf=f(cote) et pl=f(cote) 
                        if(pressio.pfmpa.Count()==pressio.cotes.Count())
                            touslesforms.ssondf.pfchart.Series[name].Points.DataBindXY(pressio.pfmpa, pressio.cotes); 
                    
                    }
                }
                //Renommer les cellules inchangeables(A effacer après avoir trouvé une méthode pour empécher la modification de certaines cellules)
                int nbcolonne = 5 * i;
                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 0, 1].Value = "cote tête";
                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 0, 2].Value = "Cote(m)";
                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 1, 2].Value = "Profondeur(m)";
                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 2, 2].Value = "Em(MPa)";
                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 3, 2].Value = "pl(MPa)";
                touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 4, 2].Value = "pf(MPa)";

                

            }
            //création d'une liste contenant les toits de chaque sondage
            List<float> listtoitmoyen = new List<float>();
            foreach (string nomsondage in touslesforms.stddd.Keys) 
            {
                listtoitmoyen.Add(touslesforms.stddd[nomsondage].cotetete);
            }
            //Calcul du toit moyen
            toitmoyen = (float)Statistics.Mean(listtoitmoyen);

            //Tracage en fonction des formations et création X et Ysynthese
            touslesforms.cotesyntese.Clear();
            
            touslesforms.emsyntese.Clear();

            touslesforms.plsyntese.Clear();

            touslesforms.pfsyntese.Clear();
            touslesforms.smodelem.Series.Clear();
            touslesforms.smodelpl.Series.Clear();
            touslesforms.smodelpf.Series.Clear();

            float tm = toitmoyen;
            int color = 1;
            foreach (string t in touslesforms.sformationsd.Keys)
            {
                
                //MessageBox.Show(t + " " + Convert.ToString(touslesforms.sformationsd[t].emmpa.Count()));
                touslesforms.ajouterseriescater(touslesforms.sformationsd[t].emmpa, touslesforms.sformationsd[t].cotes, touslesforms.smodelem,color);
                touslesforms.ajouterseriescater(touslesforms.sformationsd[t].plmpa, touslesforms.sformationsd[t].cotes, touslesforms.smodelpl,color);
                touslesforms.ajouterseriescater(touslesforms.sformationsd[t].pfmpa, touslesforms.sformationsd[t].cotes, touslesforms.smodelpf,color);

                touslesforms.cotesyntese.Add(tm);
                 touslesforms.cotesyntese.Add((float)touslesforms.sformationsd[t].cotebasemoyenne());
                touslesforms.emsyntese.Add((float)touslesforms.sformationsd[t].emmoyen());
                touslesforms.emsyntese.Add((float)touslesforms.sformationsd[t].emmoyen());
                touslesforms.plsyntese.Add((float)touslesforms.sformationsd[t].plmoyen());
                touslesforms.plsyntese.Add((float)touslesforms.sformationsd[t].plmoyen());
                touslesforms.pfsyntese.Add((float)touslesforms.sformationsd[t].pfmoyen());
                touslesforms.pfsyntese.Add((float)touslesforms.sformationsd[t].pfmoyen());

                tm = (float)touslesforms.sformationsd[t].cotebasemoyenne();
                color++;
            }
            
            touslesforms.ajouterseriesline(touslesforms.emsyntese,touslesforms.cotesyntese, touslesforms.smodelem);
            touslesforms.ajouterseriesline(touslesforms.plsyntese, touslesforms.cotesyntese, touslesforms.smodelpl);
            touslesforms.ajouterseriesline(touslesforms.pfsyntese, touslesforms.cotesyntese, touslesforms.smodelpf);

            touslesforms.courbedanspanel(touslesforms.splotviewem,touslesforms.smodelem,touslesforms.scalf.emcalculpanel);
            touslesforms.courbedanspanel(touslesforms.splotviewpl, touslesforms.smodelpl, touslesforms.scalf.plcalculpanel);
            touslesforms.courbedanspanel(touslesforms.splotviewpf, touslesforms.smodelpf, touslesforms.scalf.pfcalculpanel);
        }

        public void Paste(DataGridView d)
        {
            //METTRE IF SELECTION VIDE
            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.StringFormat))
            {
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.StringFormat).ToString().TrimEnd("\r\n".ToCharArray()), "\r");
                int j = 0;
                int k = 0;
                try { j = d.SelectedCells[0].RowIndex; } catch { }
                try { k = d.SelectedCells[0].ColumnIndex; } catch { }
                int l = k;
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });
                    foreach (string pastedRowCell in pastedRowCells)
                    {
                        d[k, j].Value = pastedRowCell;
                        k++;
                    }
                    j++;
                    k = l;
                    

                }
            }
        }

        void copy(DataGridView DataGridView1)
        {
            if (DataGridView1
             .GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    // Add the selection to the clipboard.
                    Clipboard.SetDataObject(
                        DataGridView1.GetClipboardContent());
                }
                catch (System.Runtime.InteropServices.ExternalException){ }
            }

        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste(touslesforms.stddf.tabledesdonneesgrid);
        }

        private void ajouterUnSondageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parametressondagesform pps = new parametressondagesform();
            pps.paraprofinterfacesdgv.RowCount = touslesforms.snbformations;
            //Initialiser Les formations

            for (int k = 0; k < touslesforms.snbformations; k++)
            {
                if (touslesforms.spropf.tabledesformations.RowCount != 0)
                    pps.paraprofinterfacesdgv[0, k].Value = touslesforms.spropf.tabledesformations[0, k].Value;
                    pps.paraprofinterfacesdgv[1, k].Value = true;
            }
            pps.paraprofinterfacesdgv.ReadOnly = false;
            pps.ShowDialog();
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy(touslesforms.stddf.tabledesdonneesgrid);
        }
    }

}
