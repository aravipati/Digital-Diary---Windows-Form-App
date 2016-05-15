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
    public partial class ALERTS : Form
    {
        SqlConnection con = new SqlConnection("server=MININT-HBJJIE3;initial catalog=DIGITAL DIARY;uid=sa;password=data");
        
        public ALERTS()
        {
            InitializeComponent();
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            string dt1 = dt.ToString("dd/MM/yyyy");
            //REMINDERS
            string St = "select count(DATE) from SETR where DATE='" + dt1 + "'";
            SqlCommand cmd1 = new SqlCommand(St, con);
            con.Open();
            int count = int.Parse(cmd1.ExecuteScalar().ToString());
           
            if (count == 0)
            {
                MessageBox.Show("NO REMINDER ON THIS DAY");
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("select Message from SETR where DATE='" + dt1 + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "SETR");
                int a = ds.Tables[0].Rows.Count;
                string[] b = new string[100];
                for (int i = 0; i < a; i++)
                {
                    MessageBox.Show("YOUR REMINDER ON THIS DAY IS " + ds.Tables[0].Rows[i].ItemArray[0].ToString());
                }
            }

            DateTime dt2 = new DateTime();
            dt2 = DateTime.Now;
            string dt3 = dt2.ToString("dd/MM/yyyy");
            string St1 = "select count(DOB) from ADDCONTACTS where DOB='" + dt3 + "'";
            SqlCommand cmd2 = new SqlCommand(St1, con);
            int count1 = int.Parse(cmd2.ExecuteScalar().ToString());
            if (count1 == 0)
            {
                MessageBox.Show("NO BIRTHDAY ON THIS DAY");
            }
            else
            {
                SqlDataAdapter da1 = new SqlDataAdapter("select [FIRST NAME] from ADDCONTACTS where DOB='" + dt3 + "'", con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "ADDCONTACTS");
                int a1 = ds1.Tables[0].Rows.Count;
                string[] b1 = new string[100];
                for (int i = 0; i < a1; i++)
                {
                    MessageBox.Show(ds1.Tables[0].Rows[i].ItemArray[0].ToString() + " BIRTHDAY TODAY");
                }
            }
        }
    }
}
