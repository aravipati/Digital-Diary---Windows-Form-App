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
    public partial class EDIT_REMAINDER : Form
    {
        SqlConnection con = new SqlConnection("server=MININT-HBJJIE3;initial catalog=DIGITAL DIARY;uid=sa;password=data");
        Connections er = new Connections();
        public EDIT_REMAINDER()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("select [ENO] from SETR", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "SETR");
            int a = ds.Tables[0].Rows.Count;
            string[] b = new string[150];
            for (int i = 0; i < a; i++)
            {
                b[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                ddleno.Items.Add(b[i].ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = er.editrem(ddleno.Text, txtsub.Text, dtpdate.Text, dtptime.Text);
            if (str == "1")
            {
                MessageBox.Show("REMINDER UPDATED");

            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }

        private void ddleno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from SETR where ENO='" + ddleno.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtsub.Text = dr[1].ToString();
                    dtpdate.Text = dr[2].ToString();
                    dtptime.Text = dr[3].ToString();

                }
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = er.delr(ddleno.Text, txtsub.Text, dtpdate.Text, dtptime.Text);
            if (str == "1")
            {
                MessageBox.Show("REMINDER DELETED");

            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }
    }
}
