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
    public partial class SET_DEADLINE_NOTE : Form
    {
        SqlConnection con = new SqlConnection("server=MININT-HBJJIE3;initial catalog=DIGITAL DIARY;uid=sa;password=data");
        Connections DLN = new Connections();
        public SET_DEADLINE_NOTE()
        {
            InitializeComponent();
            string str = "select count(ENO) from SETDLN";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                txteno.Text = "D1";
            }
            else if (n < 9)
            {
                string st = "select max(ENO) from SETDLN";
                SqlCommand cm = new SqlCommand(st, con);
                string max = cm.ExecuteScalar().ToString();
                int m = int.Parse(max.Substring(1, 1));
                m = m + 1;
                txteno.Text = "D" + m.ToString();
            }
            else if (n < 99)
            {
                string st = "select max(ENO) from SETDLN";
                SqlCommand cm = new SqlCommand(st, con);
                string max = cm.ExecuteScalar().ToString();
                int m = int.Parse(max.Substring(1, 2));
                m = m + 1;
                txteno.Text = "D" + m.ToString();
            }
        }

        private void SET_DEADLINE_NOTE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsub.Text == "")
            {
                MessageBox.Show("Enter subject");
            }
            else if (dtpsdate.Text == "")
            {
                MessageBox.Show("Set start date");
            }
            else if (dtpedate.Text == "")
            {
                MessageBox.Show("Set end date");
            }
            else
            {
                string sdate = dtpsdate.Text;
                string edate = dtpedate.Text;
                string str2 = DLN.setdln(txteno.Text, txtsub.Text, txtsm.Text, sdate, txtem.Text, edate);
                if (str2 == "1")
                {
                    MessageBox.Show("DEADLINE SET");
                    string str = "select count(ENO) from SETDLN";
                    SqlCommand cmd = new SqlCommand(str, con);
                    int n = int.Parse(cmd.ExecuteScalar().ToString());
                    if (n == 0)
                    {
                        txteno.Text = "D1";
                    }
                    else if (n < 9)
                    {
                        string st = "select max(ENO) from SETDLN";
                        SqlCommand cm = new SqlCommand(st, con);
                        string max = cm.ExecuteScalar().ToString();
                        int m = int.Parse(max.Substring(1, 1));
                        m = m + 1;
                        txteno.Text = "D" + m.ToString();
                    }
                    else if (n < 99)
                    {
                        string st = "select max(ENO) from SETDLN";
                        SqlCommand cm = new SqlCommand(st, con);
                        string max = cm.ExecuteScalar().ToString();
                        int m = int.Parse(max.Substring(1, 2));
                        m = m + 1;
                        txteno.Text = "D" + m.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("DEADLINE NOT SET");

                }

            }  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsub.Text = "";
            txtsm.Text = "";
            txtem.Text = "";

        }
    }
}
