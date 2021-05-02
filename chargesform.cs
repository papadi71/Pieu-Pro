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
    public partial class chargesform : Form
    {
        public chargesform()
        {
            InitializeComponent();
        }

        private void chargesform_Load(object sender, EventArgs e)
        {
            tabledescharges.RowCount = 20;
        }
    }
}
