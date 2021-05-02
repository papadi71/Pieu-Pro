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

        public float cotebasemoyenne;
        public float cotebasemin;
        public float cotebasemax;

        public List<float> cotes;
        public List<float> emmpa;
        public List<float> plmpa;
        public List<float> pfmpa;

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
