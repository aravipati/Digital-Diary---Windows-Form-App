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
    public partial class EDIT_DEADLINE_NOTE : Form
    {
        SqlConnection con = new SqlConnection("server=MININT-HBJJIE3;initial catalog=DIGITAL DIARY;uid=sa;password=data");
        Connections edn = new Connections();

        public EDIT_DEADLINE_NOTE()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("select [ENO] from SETDLN", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "SETDLN");
            int a = ds.Tables[0].Rows.Count;
            string[] b = new string[150];
            for (int i = 0; i < a; i++)
            {
                b[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                ddleno.Items.Add(b[i].ToString());
            }
        }

        private void ddleno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from SETDLN where ENO='" + ddleno.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtsub.Text = dr[1].ToString();
                    txtsm.Text = dr[2].ToString();
                    dtpdate.Text = dr[3].ToString();
                    txtem.Text = dr[4].ToString();
                    dtpedate.Text = dr[5].ToString();

                }
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = edn.editdln(ddleno.Text, txtsub.Text, txtsm.Text, dtpdate.Text, txtem.Text, dtpedate.Text);
            if (str == "1")
            {
                MessageBox.Show("DEADLINE NOTE UPDATED");

            }
            else
            {
                MessageBox.Show("Try Again");
            }
           
        }

        private void dtpedate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = edn.deldln(ddleno.Text, txtsub.Text, txtsm.Text, dtpdate.Text, txtem.Text, dtpedate.Text);
            if (str == "1")
            {
                MessageBox.Show("DEADLINE NOTE DELETED");

            }
            else
            {
                MessageBox.Show("Try Again");
            }
        }

       
    }
}
