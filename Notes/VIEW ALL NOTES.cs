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
    public partial class VIEW_ALL_NOTES : Form
    {
        public VIEW_ALL_NOTES()
        {
            InitializeComponent();
        }

        private void VIEW_ALL_NOTES_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dIGITAL_DIARYDataSet3.SETR' table. You can move, or remove it, as needed.
            this.sETRTableAdapter1.Fill(this.dIGITAL_DIARYDataSet3.SETR);
            // TODO: This line of code loads data into the 'dIGITAL_DIARYDataSet2.SETR' table. You can move, or remove it, as needed.
            this.sETRTableAdapter.Fill(this.dIGITAL_DIARYDataSet2.SETR);
            // TODO: This line of code loads data into the 'dIGITALDIARYDataSet5.NOTES' table. You can move, or remove it, as needed.
            this.nOTESTableAdapter.Fill(this.dIGITALDIARYDataSet5.NOTES);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
