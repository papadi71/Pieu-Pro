using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Statistics ;

namespace Pieu_Pro
{
    public class formation
    {
        public string nom;
      
        public float cotetoitmoyenne;
        public float cotetoitmin;
        public float cotetoitmax;

        
        public float cotebasemin;
        public float cotebasemax;

        public List<float> cotesbase=new List<float>(); 
        public List<float> cotes=new List<float>();
        public List<float> emmpa = new List<float>();
        public List<float> plmpa = new List<float>();
        public List<float> pfmpa = new List<float>();

        public double cotebasemoyenne()
        {
            return Statistics.Mean(cotesbase);
        }
        public double emmoyen()
        {
            return Statistics.HarmonicMean(emmpa);
        }
        public double plmoyen()
        {
            return Statistics.GeometricMean(plmpa);
        }
        public double pfmoyen()
        {
            return Statistics.GeometricMean(pfmpa);
        }
    }
}
