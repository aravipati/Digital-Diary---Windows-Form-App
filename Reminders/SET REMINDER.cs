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
    public partial class REMAINDER : Form
    {
        SqlConnection con = new SqlConnection("server=MININT-HBJJIE3;initial catalog=DIGITAL DIARY;uid=sa;password=data");
        Connections REM = new Connections();
        public REMAINDER()
        {
            InitializeComponent();
            string str = "select count(ENO) from SETR";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                txteno.Text = "R1";
            }
            else if (n <= 9)
            {
                string st = "select max(ENO) from SETR";
                SqlCommand cm = new SqlCommand(st, con);
                string max = cm.ExecuteScalar().ToString();
                int m = int.Parse(max.Substring(1, 1));
                m = m + 1;
                txteno.Text = "R" + m.ToString();
            }
            else if (n < 99)
            {
                string st = "select max(ENO) from SETR";
                SqlCommand cm = new SqlCommand(st, con);
                string max = cm.ExecuteScalar().ToString();
                int m = int.Parse(max.Substring(1, 2));
                m = m + 1;
                txteno.Text = "R" + m.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void REMAINDER_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsub.Text == "")
            {
                MessageBox.Show("Enter subject");
            }
            else if (dtpdate.Text == "")
            {
                MessageBox.Show("Enter date");
            }
            else if (dtptime.Text == "")
            {
                MessageBox.Show("Enter time ");
            }
            else
            {
                string time = dtptime.Text;
                string date = dtpdate.Text;
                string str1 = REM.setrem(txteno.Text, txtsub.Text, date, time);
                if (str1 == "1")
                {
                    MessageBox.Show("REMINDER SET");
                    string str = "select count(ENO) from SETR";
                    SqlCommand cmd = new SqlCommand(str, con);
                    int n = int.Parse(cmd.ExecuteScalar().ToString());
                    if (n == 0)
                    {
                        txteno.Text = "R1";
                    }
                    else if (n <=9)
                    {
                        string st = "select max(ENO) from SETR";
                        SqlCommand cm = new SqlCommand(st, con);
                        string max = cm.ExecuteScalar().ToString();
                        int m = int.Parse(max.Substring(1, 1));
                        m = m + 1;
                        txteno.Text = "R" + m.ToString();
                    }
                    else if (n <= 99)
                    {
                        string st = "select max(ENO) from SETR";
                        SqlCommand cm = new SqlCommand(st, con);
                        string max = cm.ExecuteScalar().ToString();
                        int m = int.Parse(max.Substring(1, 2));
                        m = m + 1;
                        txteno.Text = "R" + m.ToString();
                    }




                }
                else
                {
                    MessageBox.Show("REMINDER NOT SET");
                }
            }

        }

        private void REMAINDER_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsub.Text = "";

        }
    }
}
