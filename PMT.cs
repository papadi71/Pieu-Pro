using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pieu_Pro
{
    public class PMT
    {
        public string nom;
        public float cotetete;
        public float profondeur;

        public List<float> cotes =new List<float>();
        public List<float> emmpa = new List<float>();
        public List<float> plmpa = new List<float>();
        public List<float> pfmpa = new List<float>();
        public  Dictionary<string,float> basesformationsp=new Dictionary<string, float>();
        //public List<string,float> bf = new List<string, float>();
    }
    [Serializable]
    public class Map<TKey, TValue>
    {

    }
    
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
