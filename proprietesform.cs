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
    public partial class proprietesform : Form
    {
        public proprietesform()
        {
            InitializeComponent();

        }
        public static void setCellComboBoxItems(DataGridView dataGrid, int rowIndex, int colIndex, object[] itemsToAdd)
        {
            DataGridViewComboBoxCell dgvcbc = (DataGridViewComboBoxCell)dataGrid.Rows[rowIndex].Cells[colIndex];
            // You might pass a boolean to determine whether to clear or not.
            dgvcbc.Items.Clear();
            foreach (object itemToAdd in itemsToAdd)
            {
                dgvcbc.Items.Add(itemToAdd);
            }
        }
        public void proprietesform_Load(object sender, EventArgs e)
        {
            tabledesformations.RowCount = 1;
            tabledesformations[0, 0].Value = "Formation1";

            setCellComboBoxItems(tabledesformations, 0, 1, touslesforms.sclassesdesol);

            methodedecalculcb.Items.AddRange(touslesforms.smethodesdecalcul);
            classesdepieuxcb.Items.AddRange(touslesforms.sclassesdepieux);
            categoriedepieuxcb.Items.AddRange(touslesforms.scategoriesdepieux);

        }

        private void ajouterformation_Click(object sender, EventArgs e)
        {
            touslesforms.snbformations++;
            nbflabel.Text = Convert.ToString(touslesforms.snbformations);
            tabledesformations.RowCount = touslesforms.snbformations;
            tabledesformations[0, touslesforms.snbformations-1].Value = "Formation"+ Convert.ToString(touslesforms.snbformations);
            setCellComboBoxItems(tabledesformations, touslesforms.snbformations - 1, 1, touslesforms.sclassesdesol);

        }

        private void renitialisertdf_Click(object sender, EventArgs e)
        {
            touslesforms.snbformations=1;
            tabledesformations.Rows.Clear();
            tabledesformations.RowCount = 1;
            tabledesformations[0, 0].Value = "Formation1";
            nbflabel.Text = Convert.ToString(touslesforms.snbformations);
            setCellComboBoxItems(tabledesformations, 0, 1, touslesforms.sclassesdesol);
        }

        private void methodedecalculcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void diametretxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar ==(char)",")
            //e.Handled = true;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
