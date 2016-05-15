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
    public partial class VIEW_ALL_REMINDERS : Form
    {
        public VIEW_ALL_REMINDERS()
        {
            InitializeComponent();
        }

        private void VIEW_ALL_REMINDERS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dIGITAL_DIARYDataSet1.SETR' table. You can move, or remove it, as needed.
            this.sETRTableAdapter1.Fill(this.dIGITAL_DIARYDataSet1.SETR);
            // TODO: This line of code loads data into the 'dIGITALDIARYDataSet3.SETR' table. You can move, or remove it, as needed.
            this.sETRTableAdapter.Fill(this.dIGITALDIARYDataSet3.SETR);

        }
    }
}
