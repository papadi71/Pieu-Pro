using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Pieu_Pro.Classes_pour_enregistrements
{
    [SerializableAttribute]
    public class pieuprofile
    {
        /// <summary>
        /// Chemin d'accés et nom du fichier.
        /// </summary>
        [XmlAttribute(AttributeName = "FileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Chemin d'accés et nom du fichier backup.
        /// </summary>
        [XmlAttribute(AttributeName = "BackupFileName")]
        public string BackupFileName { get; set; } = string.Empty;

        /// <summary>
        /// Nom et extension du fichier. Le nom du fichier n'inclut pas le chemin d'accès.
        /// </summary>
        [XmlIgnore()]
        public string SafeFileName { get; set; }

        /// <summary>
        /// Nom et extension du fichier backup. Le nom du fichier n'inclut pas le chemin d'accès.
        /// </summary>
        [XmlIgnore()]
        public string SafeBackupFileName { get; set; }

        /// <summary>
        /// Contenu du fichier.
        /// </summary>
        [XmlIgnore()]
        public string Contents { get; set; } = string.Empty;

        //element de l'onglet propriété
        public string nom { get; set; }
        public string methodedecalcul { get; set; }
        
        public  int nbformations ;
        
        public  Dictionary<string, formation> formations = new Dictionary<string, formation>();
        //public string jsonformations;
        public float diametrepieu { get; set; }
        public string classepieu { get; set; }
        public string categoriepieu { get; set; }

       
        public int nbsondages;
      
        public Dictionary<string, PMT> tdd = new Dictionary<string, PMT>();
        //public string jsontdd;

       

        /// <summary>
        /// Constructeur de la classe TextFile.
        /// </summary>
        public pieuprofile()
        {

        }

        /// <summary>
        /// Constructeur de la classe TextFile.
        /// </summary>
        /// <param name="fileName">Chemin d'accés et nom du fichier.</param>
        public pieuprofile(string fileName)
        {
            //jsontdd = JsonConvert.SerializeObject(tdd);
           // jsonformations = JsonConvert.SerializeObject(formations);
            FileName = fileName;
            SafeFileName = Path.GetFileName(fileName);

            if (FileName.StartsWith("Sans titre"))
            {
                SafeBackupFileName = $"{FileName}@{DateTime.Now:dd-MM-yyyy-HH-mm-ss}";
                BackupFileName = Path.Combine(session.BackupPath, SafeBackupFileName);
            }
        }
    }
}

