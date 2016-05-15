using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DIGITAL_DIARY
{
    public partial class VIEW_ALL_CONTACTS : Form
    {
        public VIEW_ALL_CONTACTS()
        {
            InitializeComponent();
        }

        private void VIEW_ALL_CONTACTS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dIGITAL_DIARYDataSet.ADDCONTACTS' table. You can move, or remove it, as needed.
            this.aDDCONTACTSTableAdapter2.Fill(this.dIGITAL_DIARYDataSet.ADDCONTACTS);
            // TODO: This line of code loads data into the 'dIGITALDIARYDataSet4.ADDCONTACTS' table. You can move, or remove it, as needed.
            this.aDDCONTACTSTableAdapter1.Fill(this.dIGITALDIARYDataSet4.ADDCONTACTS);
            // TODO: This line of code loads data into the 'dIGITALDIARYDataSet.ADDCONTACTS' table. You can move, or remove it, as needed.
            this.aDDCONTACTSTableAdapter.Fill(this.dIGITALDIARYDataSet.ADDCONTACTS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
