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
            touslesforms.stddd.Clear();
            touslesforms.ssondf.emchart.Series.Clear();
            touslesforms.ssondf.plchart.Series.Clear();
            touslesforms.ssondf.pfchart.Series.Clear();


            for (int i=0;i<touslesforms.snbsondages; i++) 
            {
                string name;
                PMT pressio = new PMT();
                pressio.cotes = new List<float>();
                pressio.emmpa = new List<float>();
                pressio.plmpa = new List<float>();
                pressio.pfmpa = new List<float>();

                

                if (touslesforms.stddf.tabledesdonneesgrid[5 * i, 0].Value != null)
                {
                    name = Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i, 0].Value);
                    pressio.nom = name;
                    touslesforms.stddd.Add(name, pressio);
                    
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

                    //Comptage du nombre de ligne du sondage et détermination de la profondeur
                    int compteurligne = 3;
                    while (touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, compteurligne].Value != null && touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, 1].Value != null)
                    {

                        pressio.profondeur = float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, compteurligne].Value));

                        //Recalcul cote
                        //if (touslesforms.stddf.tabledesdonneesgrid[5 * i, compteurligne].Value != null) 
                        touslesforms.stddf.tabledesdonneesgrid[5 * i, compteurligne].Value = pressio.cotetete - float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, compteurligne].Value));
                        

                        //if (touslesforms.stddf.tabledesdonneesgrid[5 * i , compteurligne].Value != null)
                        pressio.cotes.Add(float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i, compteurligne].Value)));


                        if (touslesforms.stddf.tabledesdonneesgrid[5 * i + 2, compteurligne].Value != null)
                            pressio.emmpa.Add(float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 2, compteurligne].Value)));


                        //Gérer les exceptions pour les cases non encore remplies
                        if (touslesforms.stddf.tabledesdonneesgrid[5 * i + 3, compteurligne].Value != null)
                            pressio.plmpa.Add(float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 3, compteurligne].Value)));


                        if (touslesforms.stddf.tabledesdonneesgrid[5 * i + 4, compteurligne].Value != null)
                            pressio.pfmpa.Add(float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 4, compteurligne].Value)));
                        
                    compteurligne = compteurligne + 1;

                    }


                    //mise à jour du dictionnaire
                    touslesforms.stddd[name]= pressio;

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
                    //DataGridViewRow r = new DataGridViewRow();
                    //r.CreateCells(d, pastedRow.Split(new char[] { '\t' }));
                    // d.Rows.Insert(j, r);

                }
            }
        }

        void copy(DataGridView dataGridView)
        {
            //DataObject d = dataGridView.GetClipboardContent();
            //Clipboard.SetDataObject(d);

        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste(touslesforms.stddf.tabledesdonneesgrid);
        }

        private void ajouterUnSondageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new parametressondagesform().ShowDialog();
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste(touslesforms.stddf.tabledesdonneesgrid);
        }
    }

}
