using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pieu_Pro
{
    public partial class calculform : Form
    {
        public calculform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            touslesforms.snbcalcul++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (touslesforms.snbcalcul > 0)
                touslesforms.sresf.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
