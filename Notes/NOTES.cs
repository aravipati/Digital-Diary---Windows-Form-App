using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DIGITAL_DIARY
{
    public partial class NOTES : Form
    {
        SqlConnection con = new SqlConnection("server=MININT-HBJJIE3;initial catalog=DIGITAL DIARY;uid=sa;password=data");
        Connections NOTE = new Connections();
        public NOTES()
        {
            InitializeComponent();
            string str = "select count(ENO) from NOTES";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                txteno.Text = "N1";
            }
            else if (n <= 9)
            {
                string st = "select max(ENO) from ADDCONTACTS";
                SqlCommand cm = new SqlCommand(st, con);
                string max = cm.ExecuteScalar().ToString();
                int m = int.Parse(max.Substring(1, 1));
                m = m + 1;
                txteno.Text = "N" + m.ToString();
            }
            else if (n < 99)
            {
                string st = "select max(ENO) from ADDCONTACTS";
                SqlCommand cm = new SqlCommand(st, con);
                string max = cm.ExecuteScalar().ToString();
                int m = int.Parse(max.Substring(1, 2));
                m = m + 1;
                txteno.Text = "N" + m.ToString();
            }
        }

        private void NOTES_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str3 = NOTE.note(txteno.Text, txtmsg.Text);
            if (str3 == "1")
            {
                MessageBox.Show("Note set");
            }
            else
            {
                MessageBox.Show("Note not set");

            }
        }

        private void txteno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //txteno.Text = "";
            txtmsg.Text = "";

        }
    }
}

