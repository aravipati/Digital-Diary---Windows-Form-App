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
    public partial class EDIT : Form
    {
        SqlConnection con = new SqlConnection("server=MININT-HBJJIE3;initial catalog=DIGITAL DIARY;uid=sa;password=data");
        Connections ec = new Connections();
        public EDIT()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("select [ENO] from ADDCONTACTS", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "ADDCONTACTS");
            int a = ds.Tables[0].Rows.Count;
            string[] b = new string[150];
            for (int i = 0; i < a; i++)
            {
                b[i] = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                ddleno.Items.Add(b[i].ToString());
            }

            for (int i = 1; i < 32; i++)
            {
                ddldate.Items.Add(i.ToString());

            }
           
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            int x = int.Parse(dt.ToString("yyyy"));
            for (int i = 1960; i <= x; i++)
            {
                ddlyear.Items.Add(i.ToString());
            }
        }

        private void txtlname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtentryno_TextChanged(object sender, EventArgs e)
        {

        }

        private void EDIT_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ddldate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ddlmonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ddlyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
                string str = ec.editc(ddleno.Text, txtfname.Text, txtmname.Text, txtlname.Text, txtdob.Text, txtcontact.Text, txtaddress.Text, txtg.Text);
                if (str == "1")
                {
                    MessageBox.Show("CONTACT UPDATED");
                    
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
           

        }

        private void ddleno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from ADDCONTACTS where ENO='" + ddleno.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtfname.Text = dr[1].ToString();
                    txtmname.Text = dr[2].ToString();
                    txtlname.Text = dr[3].ToString();
                    txtdob.Text = dr[4].ToString();
                    txtaddress.Text = dr[6].ToString();
                    txtcontact.Text = dr[5].ToString();

                }
            }
            con.Close();
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string str = ec.delc(ddleno.Text, txtfname.Text, txtmname.Text, txtlname.Text, txtdob.Text, txtcontact.Text, txtaddress.Text, txtg.Text);
            if (str == "1")
            {
                MessageBox.Show("CONTACT DELETED");

            }
            else
            {
                MessageBox.Show("Try Again");
            }
           

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
