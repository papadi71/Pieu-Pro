
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
using MathNet.Numerics.Statistics;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlot.Annotations;
using OxyPlot.WindowsForms;
using OxyPlot.Reporting;


namespace Pieu_Pro
{
    public class touslesforms
    {
        
        public static accueilform saccf = new accueilform();
        public static sondagesform ssondf = new sondagesform();
        public static proprietesform spropf = new proprietesform();
        //public static parametressondagesform sparaf = null;
        public static chargesform schaf =new chargesform();
        public static tabledesdonneesform stddf =new tabledesdonneesform();
        public static calculform scalf = new calculform();
        public static resultatsform sresf= new resultatsform();
        public static int snbcalcul = 0;

        public static int snbsondages=0;
        public static int snbformations = 1;

        public static Dictionary<string, PMT> stddd = new Dictionary<string, PMT>();
        public static Dictionary<string, formation> sformationsd = new Dictionary<string, formation>();


        public static List<float> cotesyntese = new List<float>();
        public static  List<float> emsyntese = new List<float>();
        public static  List<float> plsyntese = new List<float>();
        public static List<float> pfsyntese = new List<float>();


        public static string[] sclassesdesol = {"Argiles,Limons","Sables, Graves, Sols Intermédiaire"," Craie","Marne et Calcaire Marneux","Roches altérés et fragmentées"};
        public static string[] smethodesdecalcul = { "NF P94 262"};
        public static string[] sclassesdepieux = { "FS:Foré simple","FB:Foré boue" , "FTC:Foré tarrière creuse" };
        public static string[] scategoriesdepieux = { "1:", "2:", "3:" };
        public static Dictionary<string, PMT> stdddstockage = new Dictionary<string, PMT>();

        public static PlotView splotviewem= new PlotView();
        public static PlotModel smodelem = new PlotModel { Title = "Em(MPa)" };

        public static PlotView splotviewpl = new PlotView();
        public static PlotModel smodelpl = new PlotModel { Title = "pl*(MPa)" };

        public static PlotView splotviewpf = new PlotView();
        public static PlotModel smodelpf= new PlotModel { Title = "pf*(MPa)" };

        public static void courbe (List<float> x, List<float> y, Panel p, string titre) 
        {
            var plot = new PlotView();
            var model = new PlotModel { Title = titre };
            var scatterSeries = new ScatterSeries { MarkerType = MarkerType.Circle , MarkerFill=OxyColor.Parse("Orange")};

            if (x.Count == y.Count) 
            {
                
                var r = new Random(314);
                //var size = r.Next(5, 15);
                var size = 3;

                var colorValue = r.Next(100, 1000);

                for (int i = 0; i < x.Count; i++)
                {
                    scatterSeries.Points.Add(new ScatterPoint(x[i], y[i], size, colorValue));
                }

                model.Series.Add(scatterSeries);
                //model.Axes.Add(new LinearColorAxis
                //{
                   // Position = AxisPosition.Right,
                    //Palette = OxyPalettes.Jet(200)
               // });

            }
            plot.Model = model;
            plot.Dock = DockStyle.Fill;
            p.Controls.Add(plot);
            p.Tag = plot;
            plot.BringToFront();
            plot.Show();
        }

        public static (MarkerType, OxyColor) markertype(int color)
        {
            MarkerType markertype = new MarkerType();
            OxyColor oxycolor = new OxyColor();

            switch (color)
            {
                case 1:
                    markertype=MarkerType.Circle;
                    oxycolor = OxyColor.Parse("255,200,180,50");

                    break;
                case 2:
                    markertype = MarkerType.Diamond;
                    oxycolor = OxyColor.Parse("225,255,0,50");
                    break;
                case 3:
                    markertype = MarkerType.Circle;
                    oxycolor = OxyColor.Parse("109,255,10,225");
                    break;
                case 4:
                    markertype = MarkerType.Diamond;
                    oxycolor = OxyColor.Parse("45,0,255");
                    break;
                case 5:
                    markertype = MarkerType.Circle;
                    oxycolor = OxyColor.Parse("225,10,255,0");
                    break;
                case 6:
                    markertype = MarkerType.Diamond;
                    oxycolor = OxyColor.Parse("225,225,0,100");
                    break;
                case 7:
                    markertype = MarkerType.Circle;
                    oxycolor = OxyColor.Parse("255,225,0,130");
                    break;
                case 8:
                    markertype = MarkerType.Diamond;
                    oxycolor = OxyColor.Parse("192,225,0,160");
                    break;
                case 9:
                    markertype = MarkerType.Circle;
                    oxycolor = OxyColor.Parse("100,225,34,190");
                    break;
                case 10:
                    markertype = MarkerType.Diamond;
                    oxycolor = OxyColor.Parse("33,225,200");
                    break;
                case 11:
                    markertype = MarkerType.Circle;
                    oxycolor = OxyColor.Parse("45,180,35,225");
                    break;
                default:
                    markertype = MarkerType.Circle;
                    //oxycolor = OxyColor.Automatic;
                    oxycolor = OxyColor.Parse("204,85,50");
                    break;
            }
            return (markertype,oxycolor);
        }

        public static void ajouterseriescater(List<float> x, List<float> y, PlotModel model,int color)
        {
            //model.Series.Clear();

            (MarkerType, OxyColor) m = markertype(color);
            var scatterSeries = new ScatterSeries { MarkerType = m.Item1 ,MarkerFill=m.Item2};

            if (x.Count == y.Count)
            {

                //var r = new Random(314);
                //var size = r.Next(5, 15);
                //var size = 3;

                //var colorValue = r.Next(100, 1000);
                var colorValue = 100 * color;

                for (int i = 0; i < x.Count; i++)
                {
                    //scatterSeries.Points.Add(new ScatterPoint(x[i], y[i], size, colorValue));
                    scatterSeries.Points.Add(new ScatterPoint(x[i], y[i],3));
                }
                scatterSeries.IsVisible = true;
                model.Series.Add(scatterSeries);
                
              
            }
            
          
        }


        public static void ajouterseriesline(List<float> x, List<float> y, PlotModel model)
        {

            var lineserie = new LineSeries {  Color = OxyColor.Parse("10,10,10") };
            //(MarkerType, OxyColor) m = markertype(color);
            //var lineserie = new LineSeries { MarkerType = m.Item1, MarkerFill = m.Item2 , Color=OxyColor.Parse("225,225,225")};

            if (x.Count == y.Count)
            {

               
                //var colorValue = 100 * color;

                for (int i = 0; i < x.Count; i++)
                {
                    
                    lineserie.Points.Add(new DataPoint(x[i], y[i]));
                }
                lineserie.IsVisible = true;
                model.Series.Add(lineserie);


            }


        }

        public static void courbedanspanel(PlotView v, PlotModel m,Panel p)
        {
           
            v.Model = m;
            v.Dock = DockStyle.Fill;
            p.Controls.Add(v);
            p.Tag = v;
            v.BringToFront();
            v.Show();
        }

    }



}

