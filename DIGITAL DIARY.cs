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
    public partial class Form1 : Form
    {
        ADD_CONTACT addcont = new ADD_CONTACT();
        EDIT EDITCNT = new EDIT();
        VIEW_CONTACT viewcnt = new VIEW_CONTACT();
        REMAINDER setrem = new REMAINDER();
        EDIT_REMAINDER editr = new EDIT_REMAINDER();
        SET_DEADLINE_NOTE setdn = new SET_DEADLINE_NOTE();
        EDIT_DEADLINE_NOTE editdn = new EDIT_DEADLINE_NOTE();
        NOTES notes = new NOTES();
        VIEW_ALL_CONTACTS vac = new VIEW_ALL_CONTACTS();
        VIEW_ALL_REMINDERS vare = new VIEW_ALL_REMINDERS();
        VIEW_ALL_DEADLINE_NOTES vad = new VIEW_ALL_DEADLINE_NOTES();
        VIEW_ALL_NOTES van = new VIEW_ALL_NOTES();
        ALERTS alr = new ALERTS();
 
    public Form1()
        {
//            alr.Close();
            InitializeComponent();
        }
        private void aDDCONTACTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addcont.MdiParent = this;
            addcont.WindowState = FormWindowState.Maximized;
            addcont.Show();
            //addcont.Visible = true;
            EDITCNT.Hide();
            setrem.Hide();
            viewcnt.Hide();
            setdn.Hide();
            editdn.Hide();
            editr.Hide();
            notes.Hide();
            vac.Hide();
            vare.Hide();
            vad.Hide();
            van.Hide();

        }

        private void eDITCONTACTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDITCNT.MdiParent = this;
            EDITCNT.WindowState = FormWindowState.Maximized;
            EDITCNT.Show();
            addcont.Hide();
            setrem.Hide();
            viewcnt.Hide();
            setdn.Hide();
            editdn.Hide();
            editr.Hide();
            notes.Hide();
            vac.Hide();
            vare.Hide();
            vad.Hide();
            van.Hide();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //alr.Hide();
            alr.Close();
            addcont.Hide();
            EDITCNT.Hide();
            setrem.Hide();
            viewcnt.Hide();
            setdn.Hide();
            editdn.Hide();
            editr.Hide();
            notes.Hide();
            vac.Hide();
            vare.Hide();
            vad.Hide();
            van.Hide();
        }

        private void sETREMAINDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setrem.MdiParent = this;
            setrem.WindowState = FormWindowState.Maximized;
            setrem.Show();
            addcont.Hide();
            EDITCNT.Hide();
            viewcnt.Hide();
            setdn.Hide();
            editdn.Hide();
            editr.Hide();
            notes.Hide();
            vac.Hide();
            vare.Hide();
            vad.Hide();
            van.Hide();
      }

        

        private void eDITREMAINDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editr.MdiParent = this;
            editr.WindowState = FormWindowState.Maximized;
            editr.Show();
            setrem.Hide();
            addcont.Hide();
            EDITCNT.Hide();
            viewcnt.Hide();
            setdn.Hide();
            editdn.Hide();
            notes.Hide();
            vac.Hide();
            vare.Hide();
            vad.Hide();
            van.Hide();


        }

        private void vIEWCONTACTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewcnt.MdiParent = this;
            viewcnt.WindowState = FormWindowState.Maximized;
            viewcnt.Show();
            editr.Hide();
            setrem.Hide();
            addcont.Hide();
            EDITCNT.Hide();
            setdn.Hide();
            editdn.Hide();
            notes.Hide();
            vac.Hide();
            vare.Hide();
            vad.Hide();
            van.Hide();
        }

        private void sETDEADLINENOTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setdn.MdiParent = this;
            setdn.WindowState = FormWindowState.Maximized;
            setdn.Show();
            addcont.Hide();
            EDITCNT.Hide();
            viewcnt.Hide();
            setrem.Hide();
            editr.Hide();
            editdn.Hide();
            notes.Hide();
            vac.Hide();
            vare.Hide();
            vad.Hide();
            van.Hide();
        }

        private void eDITDEADLINENOTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editdn.MdiParent = this;
            editdn.WindowState = FormWindowState.Maximized;
            editdn.Show();
            addcont.Hide();
            EDITCNT.Hide();
            viewcnt.Hide();
            setrem.Hide();
            editr.Hide();
            setdn.Hide();
            notes.Hide();
            vac.Hide();
            vare.Hide();
            vad.Hide();
            van.Hide();
        }

        private void nOTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aLERTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alr.MdiParent = this;
            alr.WindowState = FormWindowState.Maximized;
            alr.Show();
            Application.Restart();
            //alr.Hide();
            addcont.Hide();
            EDITCNT.Hide();
            viewcnt.Hide();
            setrem.Hide();
            editr.Hide();
            setdn.Hide();
            editdn.Hide();
            notes.Hide();
            vare.Hide();
            vad.Hide();
            van.Hide();
            vac.Hide();
        }

        private void vIEWALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vac.MdiParent = this;
            vac.WindowState = FormWindowState.Maximized;
            vac.Show();
            addcont.Hide();
            EDITCNT.Hide();
            viewcnt.Hide();
            setrem.Hide();
            editr.Hide();
            setdn.Hide();
            editdn.Hide();
            notes.Hide();
            vare.Hide();
            vad.Hide();
            van.Hide();
        }

        private void vIEWALLREMINDERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vare.MdiParent = this;
            vare.WindowState = FormWindowState.Maximized;
            vare.Show();
            addcont.Hide();
            EDITCNT.Hide();
            viewcnt.Hide();
            setrem.Hide();
            editr.Hide();
            setdn.Hide();
            editdn.Hide();
            notes.Hide();
            vac.Hide();
            vad.Hide();
            van.Hide();
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vad.MdiParent = this;
            vad.WindowState = FormWindowState.Maximized;
            vad.Show();
            addcont.Hide();
            EDITCNT.Hide();
            viewcnt.Hide();
            setrem.Hide();
            editr.Hide();
            setdn.Hide();
            editdn.Hide();
            notes.Hide();
            vare.Hide();
            vac.Hide();
            van.Hide();
        }

        private void vIEWALLNOTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            van.MdiParent = this;
            van.WindowState = FormWindowState.Maximized;
            van.Show();
            addcont.Hide();
            EDITCNT.Hide();
            viewcnt.Hide();
            setrem.Hide();
            editr.Hide();
            setdn.Hide();
            editdn.Hide();
            notes.Hide();
            vare.Hide();
            vac.Hide();
            vad.Hide();
          
        }

        private void aDDNOTESToolStripMenuItem_Click(object sender, EventArgs e)
        {

            notes.MdiParent = this;
            notes.WindowState = FormWindowState.Maximized;
            notes.Show();
            addcont.Hide();
            EDITCNT.Hide();
            viewcnt.Hide();
            setrem.Hide();
            editr.Hide();
            setdn.Hide();
            editdn.Hide();
            vac.Hide();
            vare.Hide();
            vad.Hide();
            van.Hide();
        }

       

       
    }
}
