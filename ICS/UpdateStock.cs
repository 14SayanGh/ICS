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
    public partial class UpdateStock : Form
    {
        public UpdateStock()
        {
            InitializeComponent();
        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select PRODID from STOCKTABLE", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            Refresh();
            con.Close();

 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("select PRODNAME from STOCKTABLE where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s;
            s = com.ExecuteScalar().ToString();
            textBox1.Text = s;

            SqlCommand com1 = new SqlCommand("select SCODE from STOCKTABLE where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s1;
            s1 = com1.ExecuteScalar().ToString();
            textBox2.Text = s1;
            
            SqlCommand com2 = new SqlCommand("select SNAME from STOCKTABLE where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s2;
            s2 = com2.ExecuteScalar().ToString();
            textBox3.Text = s2;
           
            SqlCommand com3 = new SqlCommand("select UNIT from STOCKTABLE where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s3;
            s3 = com3.ExecuteScalar().ToString();
            textBox6.Text = s3;
           
            SqlCommand com4 = new SqlCommand("select CSTOCK from STOCKTABLE where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s4;
            s4 = com4.ExecuteScalar().ToString();
            textBox9.Text = s4;
            
            SqlCommand com5 = new SqlCommand("select COMPANY from STOCKTABLE where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s5;
            s5 = com5.ExecuteScalar().ToString();
            textBox4.Text = s5;
           
            SqlCommand com6 = new SqlCommand("select MFDATE from STOCKTABLE where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s6;
            s6 = com6.ExecuteScalar().ToString();
            textBox5.Text = s6;
                                 
            Refresh();
            con.Close();

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
            SqlCommand com1 = new SqlCommand("select CSTOCK from STOCKTABLE where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            
            double c;
            c = Convert.ToDouble(com1.ExecuteScalar());
            double addnewstock;
            double delnewstock;
            
            if (textBox7.Text != "")
            {
                addnewstock = c + Convert.ToDouble(textBox7.Text);
                SqlCommand com2 = new SqlCommand("Update STOCKTABLE set CSTOCK ='" + addnewstock + "'where PRODID = '" + comboBox1.SelectedItem.ToString() + "'", con);
                com2.ExecuteNonQuery();
                MessageBox.Show(" you have succesfully added stock");
            }
            else if (textBox8.Text != "")
            {
                delnewstock = c - Convert.ToDouble(textBox8.Text);
                if (delnewstock >= 0)
                {
                    SqlCommand com2 = new SqlCommand("Update STOCKTABLE set CSTOCK ='" + delnewstock + "'where PRODID = '" + comboBox1.SelectedItem.ToString() + "'", con);
                    com2.ExecuteNonQuery();
                    MessageBox.Show(" you have succesfully discarded stock");
                }
                else
                {
                    MessageBox.Show(" Discarding amount must be less than or equal to current amount");
                }
            }
            else
            {
                MessageBox.Show(" Stock remains unchanged!");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            
            Refresh();
            con.Close();
        }
    }
}
