using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DIGITAL_DIARY
{
    public partial class ADD_CONTACT : Form
    {
        SqlConnection con = new SqlConnection("server=MININT-HBJJIE3;initial catalog=DIGITAL DIARY;uid=sa;password=data");
        Connections CON = new Connections();
        public ADD_CONTACT()
        {
            
            InitializeComponent();
            IDGEN();
            

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
            public void IDGEN()
            {
            string str = "select count(ENO) from ADDCONTACTS";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            int n = int.Parse(cmd.ExecuteScalar().ToString());
            if (n == 0)
            {
                txteno.Text = "C1";
            }
            else if (n <= 9)
            {
                string st = "select count(ENO) from ADDCONTACTS";
              
                SqlCommand cm = new SqlCommand(st, con);
                string max = cm.ExecuteScalar().ToString();
                int m = int.Parse(max.Substring(0, 1));
                m = m + 1;
                txteno.Text = "C" + m.ToString();

            }
            else if (n <= 99)
            {
                string st = "select count(ENO) from ADDCONTACTS";
                SqlCommand cm = new SqlCommand(st, con);
                string max = cm.ExecuteScalar().ToString();
                int m = int.Parse(max);
                m = m + 1;
                txteno.Text = "C" + m.ToString();
            }
            con.Close();
            }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtmname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADD_CONTACT_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            op.Title="open.Image";
            op.Filter = "Image files'(*.jpg)|*.jpg";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(op.FileName);
                pictureBox1.Size = new Size(200, 200);
                textBox1.Text = op.FileName;
            }
            op.Dispose();*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        SqlCommand cm12;
        private void button1_Click(object sender, EventArgs e)
        {
            //int k = 0;

            
                if (txtfname.Text == "")
                {
                    MessageBox.Show("Enter Your Name");
                }
                else if (ddldate.Text == "")
                {
                    MessageBox.Show("Enter date");
                }
                else if (ddlmonth.Text == "")
                {
                    MessageBox.Show("Enter month ");
                }
                else if (ddlyear.Text == "")
                {
                    MessageBox.Show("Enter year");
                }
                else if (txtcontact.Text == "")
                {
                    MessageBox.Show("Enter contact number");
                }

                else
                {
                    string dob = ddldate.SelectedItem.ToString() + "-" + ddlmonth.SelectedItem.ToString() + "-" + ddlyear.SelectedItem.ToString();
                    if (rdboff.Text == "Office")
                    {
                        string str = CON.addcont(txteno.Text, txtfname.Text, txtmname.Text, txtlname.Text, dob, txtcontact.Text, txtaddress.Text, rdboff.Text);
                        if (str == "1")
                        {
                            //string img = "update ADDCONTACTS set IMAGE = (@PHOTO) where ENO ='" + txteno.Text + "'";
                            //cm12 = new SqlCommand(con);
                            con.Open();
                            //conv_photo();
                            //int im = int.Parse(cm12.ExecuteNonQuery().ToString());
                            con.Close();
                            //if (im > 0)
                            //{
                                MessageBox.Show("CONTACT SAVED");
                                IDGEN();                               

                            //}
                            //else
                            //{
                            //    MessageBox.Show("CONTACT NOT SAVED");
                            //}
                            txtfname.Text = null;
                            txtmname.Text = null;
                            txtlname.Text = null;
                            ddldate.Items.Clear();
                            //ddlmonth.Items.Clear();
                            ddlyear.Items.Clear();
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
                            
                            txtaddress.Text = null;
                            txtcontact.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("CONTACT NOT SAVED");
                        }
                    }
                    else if (rdbfrnd.Text == "Friends")
                    {
                      string str = CON.addcont(txteno.Text, txtfname.Text, txtmname.Text, txtlname.Text, dob, txtcontact.Text, txtaddress.Text, rdboff.Text);
                        if (str == "1")
                        {
                            //string img = "update ADDCONTACTS set IMAGE = (@PHOTO) where ENO ='" + txteno.Text + "'";
                            //cm12 = new SqlCommand(img, con);
                            con.Open();
                            //conv_photo();
                            //int im = int.Parse(cm12.ExecuteNonQuery().ToString());
                            con.Close();
                            //if (im > 0)
                            //{
                                MessageBox.Show("CONTACT SAVED");
                               IDGEN();                               

                            //}
                            //else
                            //{
                            //    MessageBox.Show("CONTACT NOT SAVED");
                            //}
                            txtfname.Text = null;
                            txtmname.Text = null;
                            txtlname.Text = null;
                            ddldate.Items.Clear();
                            //ddlmonth.Items.Clear();
                            ddlyear.Items.Clear();
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
                            
                            txtaddress.Text = null;
                            txtcontact.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("CONTACT NOT SAVED");
                        }
                    }
                    else if (rdbr.Text == "Relatives")
                    {
                        string str = CON.addcont(txteno.Text, txtfname.Text, txtmname.Text, txtlname.Text, dob, txtcontact.Text, txtaddress.Text, rdboff.Text);
                        if (str == "1")
                        {
                            //string img = "update ADDCONTACTS set IMAGE = (@PHOTO) where ENO ='" + txteno.Text + "'";
                            //cm12 = new SqlCommand(img, con);
                            con.Open();
                            //conv_photo();
                            //int im = int.Parse(cm12.ExecuteNonQuery().ToString());
                            con.Close();
                            //if (im > 0)
                            //{
                                MessageBox.Show("CONTACT SAVED");
                                IDGEN();

                            //}
                            //else
                            //{
                            //    MessageBox.Show("CONTACT NOT SAVED");
                            //}
                            txtfname.Text = null;
                            txtmname.Text = null;
                            txtlname.Text = null;
                            ddldate.Items.Clear();
                            //ddlmonth.Items.Clear();
                            ddlyear.Items.Clear();
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

                            txtaddress.Text = null;
                            txtcontact.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("CONTACT NOT SAVED");
                        }
                    }
                }
                
                      
        }
       //// void conv_photo()
       // {
       //     if(pictureBox1.Image!=null)
       //     {
       //         MemoryStream ms=new MemoryStream();
       //         pictureBox1.Image.Save(ms,ImageFormat.Jpeg);
       //         byte[] photo_array=new byte[ms.Length];
       //         ms.Position=0;
       //         ms.Read(photo_array,0,photo_array.Length);
       //         cm12.Parameters.AddWithValue("@photo", photo_array);                
       //     }
       // }

        private void button2_Click(object sender, EventArgs e)
        {
            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            ddldate.Items.Clear();
            ddlmonth.Items.Clear();
            ddlyear.Items.Clear();
            txtcontact.Text = "";
            txtaddress.Text = "";


      
        }

        private void ddlyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
