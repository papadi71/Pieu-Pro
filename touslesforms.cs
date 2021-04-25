
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

namespace Pieu_Pro
{
    public class touslesforms
    {
        
        public static accueilform saccf = new accueilform();
        public static sondagesform ssondf = new sondagesform();
        public static proprietesform spropf = new proprietesform();
        public static parametressondagesform sparaf = null;
        public static chargesform schaf =new chargesform();
        public static tabledesdonneesform stddf =new tabledesdonneesform();
        public static calculform scalf = new calculform();

        public static int snbsondages=0;

        public static DataTable dataTable = new DataTable();

        public static Dictionary<string, PMT> stddd = new Dictionary<string, PMT>();

        
    }

}

