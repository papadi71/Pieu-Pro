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
        public string classedesol;

        public float cotetoitmoyenne;
        public float cotetoitmin;
        public float cotetoitmax;

        
        public float cotebasemin;
        public float cotebasemax;

        //Dictionnaire pour stocker les cotes tête:Servira à calculer cote tête moyenne du TN
        public Dictionary<string, float> sondages = new Dictionary<string, float>();

        //transformer en element serialisable

        /*
         
        [XmlRoot("Personne")] 
    public class Personne 
    { 
        public string Nom {get; set;} 
        public string Prenom {get; set;} 
        public string DateNaissance {get; set;} 
  
        [XmlIgnore] 
        public Dictionary<string, string> Adresses{ get; set; } 
  
        [XmlArray("Adresses")] 
        [XmlArrayItem("Adresse")] 
        public KeyValueXml<string, string>[] AdressesXMLProxy 
        { 
            get 
            { 
                return this.Adresses.Select( x => new KeyValueXml<string, string>(x.Key, x.Value)).ToArray() ; 
            } 
            set 
            { 
                if (value != null) 
                { 
                    this.Adresses = new Dictionary<string, string>(); 
                    foreach (var pair in value) 
                    { 
                        this.Adresses[pair.Key] = pair.Value; 
                    } 
                } 
                else 
                { 
                    this.Adresses = null; 
                } 
            } 
        }         
  
        [Serializable] 
        public struct KeyValueXml<TKey, TValue> 
        { 
            public KeyValueXml(TKey key, TValue value) 
            { 
                this.Key = key; 
                this.Value = value; 
            } 
  
            public TKey Key { get; set; } 
            public TValue Value { get; set; } 
        } 
    }

         */
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
