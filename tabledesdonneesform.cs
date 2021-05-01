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
                PMT pressio = new PMT();
                string name;
                if (touslesforms.stddf.tabledesdonneesgrid[5 * i, 0].Value != null)
                {
                    name = Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i, 0].Value);
                    pressio.nom = name;
                

                if (touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, 1].Value != null)
                {
                    pressio.cotetete = float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, 1].Value));
                }

                  
             

                //Comptage du nombre de ligne du sondage et détermination de la profondeur
                int compteurligne = 3;
                while (touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, compteurligne+3].Value!=null)
                {
                    //Recalcul cote
                    if (touslesforms.stddf.tabledesdonneesgrid[5 * i, compteurligne].Value != null) touslesforms.stddf.tabledesdonneesgrid[5 * i , compteurligne].Value = pressio.cotetete - float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, compteurligne].Value));
                    
                    pressio.cotes = new List<float>();
                    if (touslesforms.stddf.tabledesdonneesgrid[5 * i , compteurligne].Value != null)
                        pressio.cotes.Add(float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i , compteurligne].Value)));

                    pressio.emmpa = new List<float>();
                    if (touslesforms.stddf.tabledesdonneesgrid[5 * i + 2, compteurligne].Value != null)
                    pressio.emmpa.Add(float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i+2, compteurligne].Value)));

                    pressio.plmpa = new List<float>();
                    //Gérer les exceptions pour les cases non encore remplies
                    if(touslesforms.stddf.tabledesdonneesgrid[5 * i + 3, compteurligne].Value != null)
                    pressio.plmpa.Add(float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i+3, compteurligne].Value)));

                    pressio.pfmpa = new List<float>();
                    if (touslesforms.stddf.tabledesdonneesgrid[5 * i + 4, compteurligne].Value != null)
                        pressio.pfmpa.Add(float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i+4, compteurligne].Value)));

                    compteurligne = compteurligne + 1;

                }
                if (touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, compteurligne].Value != null) 
                 pressio.profondeur = float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i+1, compteurligne].Value));

                touslesforms.stddd.Add(name, pressio);

                    //Tracer Em=f(cote) et pl=f(cote) à partir du dictionnaire
                    touslesforms.ssondf.emchart.Series.Add(name);
                    touslesforms.ssondf.emchart.Series[name].ChartType = SeriesChartType.Point;
                    //if ( pressio.emmpa.Count() == pressio.cotes.Count())
                        //touslesforms.ssondf.emchart.Series[name].Points.DataBindXY(pressio.emmpa, pressio.cotes);
                    touslesforms.ssondf.emchart.Series[name].LegendText = name;

                    //Tracer pl=f(cote) et pl=f(cote) à partir du dictionnaire
                    touslesforms.ssondf.plchart.Series.Add(name);
                touslesforms.ssondf.plchart.Series[name].ChartType = SeriesChartType.Point;
                //if (pressio.plmpa.Count() == pressio.cotes.Count())
                    //touslesforms.ssondf.plchart.Series[name].Points.DataBindXY(pressio.plmpa, pressio.cotes);
                touslesforms.ssondf.plchart.Series[name].LegendText = name;

                    //Tracer pf=f(cote) et pl=f(cote) à partir du dictionnaire
                    touslesforms.ssondf.pfchart.Series.Add(name);
                touslesforms.ssondf.pfchart.Series[name].ChartType = SeriesChartType.Point;
                //if(pressio.pfmpa.Count()==pressio.cotes.Count())
                    //touslesforms.ssondf.pfchart.Series[name].Points.DataBindXY(pressio.pfmpa, pressio.cotes);
                touslesforms.ssondf.pfchart.Series[name].LegendText = name;
                }
                //  Chart1.Series("SecondeSeries").Points.DataBindXY(x, y)
            }

            /*
                exemple de tracage  de courbe
                chart1.ChartAreas[0].Axes[0].Title = "N";
                chart1.ChartAreas[0].Axes[1].Title = "FIB(N)";
                chart1.Series[0].ChartType = SeriesChartType.Line;
                chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
                chart1.Series[0].LegendText = "Fibonacci numbers";
                Tuple<int,int> t = Tuple.Create(0,1);

                for(int i = 1; i <= 30; i++)
                {
                    chart1.Series[0].Points.Add(new DataPoint(i, t.Item1));
                    t = Tuple.Create(t.Item2, t.Item1 + t.Item2);
                }
             */

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

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste(touslesforms.stddf.tabledesdonneesgrid);
        }

        private void ajouterUnSondageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new parametressondagesform().ShowDialog();
        }
    }

}
