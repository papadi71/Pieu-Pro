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

namespace Pieu_Pro
{
    
    public partial class tabledesdonneesform : Form
    {
       
        //public   DataGridView stdddgv; 
        public tabledesdonneesform()
        {
            InitializeComponent();
            //tabledesdonneesgrid.RowCount = 120;
            
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
            touslesforms.stddd = new Dictionary<string, PMT>();

            touslesforms.ssondf.emchart.Series.Clear();
            touslesforms.ssondf.plchart.Series.Clear();


            for (int i=0;i<touslesforms.snbsondages; i++) 
            {
                PMT pressio = new PMT();
                string name = Convert.ToString( touslesforms.stddf.tabledesdonneesgrid[5 * i, 0].Value);
                
                pressio.nom = name;
                pressio.cotetete = float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i+1, 1].Value));
             

                //Comptage du nombre de ligne du sondage et détermination de la profondeur
                int compteurligne = 3;
                while (touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, compteurligne+3].Value!=null)
                {
                    //Recalcul cote
                    touslesforms.stddf.tabledesdonneesgrid[5 * i , compteurligne].Value = pressio.cotetete - float.Parse(Convert.ToString(touslesforms.stddf.tabledesdonneesgrid[5 * i + 1, compteurligne].Value));
                    
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
                if (pressio.emmpa.Count() == pressio.cotes.Count())
                    touslesforms.ssondf.emchart.Series[name].Points.DataBindXY(pressio.emmpa, pressio.cotes);
                touslesforms.ssondf.emchart.Series[name].LegendText = name;
               

                touslesforms.ssondf.plchart.Series.Add(name);
                touslesforms.ssondf.emchart.Series[name].ChartType = SeriesChartType.Point;
                if(pressio.plmpa.Count()==pressio.cotes.Count())
                    touslesforms.ssondf.plchart.Series[name].Points.DataBindXY(pressio.plmpa, pressio.cotes);
                touslesforms.ssondf.plchart.Series[name].LegendText = name;

                //  Chart1.Series("SecondeSeries").Points.DataBindXY(x, y)
            }


            //Metre à jour le dictionnaire



            //Tracer Em=f(cote) et pl=f(cote) à partir du dictionnaire
            //touslesforms.ssondf.emchart.Series[nomsondage].Points.AddXY(touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 2, 2 + i].Value, touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 0, 2 + i].Value);
            //touslesforms.ssondf.plchart.Series[nomsondage].Points.AddXY(touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 3, 2 + i].Value, touslesforms.stddf.tabledesdonneesgrid[nbcolonne + 0, 2 + i].Value);

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
    }
}
