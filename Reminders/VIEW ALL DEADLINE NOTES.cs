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
    public partial class VIEW_ALL_DEADLINE_NOTES : Form
    {
        public VIEW_ALL_DEADLINE_NOTES()
        {
            InitializeComponent();
        }

        private void VIEW_ALL_DEADLINE_NOTES_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dIGITAL_DIARYDataSet4.SETDLN' table. You can move, or remove it, as needed.
            this.sETDLNTableAdapter1.Fill(this.dIGITAL_DIARYDataSet4.SETDLN);
            // TODO: This line of code loads data into the 'dIGITALDIARYDataSet2.SETDLN' table. You can move, or remove it, as needed.
            this.sETDLNTableAdapter.Fill(this.dIGITALDIARYDataSet2.SETDLN);

        }
    }
}
