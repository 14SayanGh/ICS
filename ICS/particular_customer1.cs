using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ICS
{
    public partial class particular_customer1 : Form
    {
        public particular_customer1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from CUSTABLE where CUSNAME = '" + textBox1.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "a1");
                textBox1.Text = ds.Tables["a1"].Rows[0][1].ToString();
                textBox2.Text = ds.Tables["a1"].Rows[0][0].ToString();
                textBox3.Text = ds.Tables["a1"].Rows[0][2].ToString();
                textBox4.Text = ds.Tables["a1"].Rows[0][3].ToString();
                textBox5.Text = ds.Tables["a1"].Rows[0][4].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("        Customer Not Found", "ALERT");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
