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
    public partial class UpdatePurchase : Form
    {
        public UpdatePurchase()
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

        private void UpdatePurchase_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            
            SqlCommand cmd = new SqlCommand("select VOUCHERNO from PURCHTABLE", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            SqlCommand cmd1 = new SqlCommand("select SUPPCODE from SUPPTABLE", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                comboBox3.Items.Add(ds1.Tables[0].Rows[i][0].ToString());
            }

            SqlCommand cmd2 = new SqlCommand("select PRODID from PRODUCT", con);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                comboBox2.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
            }
            Refresh();
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            
            SqlCommand com = new SqlCommand("select VOUCHERDT from PURCHTABLE where VOUCHERNO= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s;
            s = com.ExecuteScalar().ToString();
            dateTimePicker1.Text = s;

            SqlCommand com1 = new SqlCommand("select PRODID from PURCHTABLE where VOUCHERNO= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s1;
            s1 = com1.ExecuteScalar().ToString();
            comboBox2.SelectedItem = s1;

            
            SqlCommand com4 = new SqlCommand("select SCODE from PURCHTABLE where VOUCHERNO= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s4;
            s4 = com4.ExecuteScalar().ToString();
            comboBox3.SelectedItem=s4;

            SqlCommand com7 = new SqlCommand("select QTY from PURCHTABLE where VOUCHERNO= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s7;
            s7 = com7.ExecuteScalar().ToString();
            textBox6.Text = s7;

            SqlCommand com8 = new SqlCommand("select PRICE from PURCHTABLE where VOUCHERNO= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s8;
            s8 = com8.ExecuteScalar().ToString();
            textBox7.Text = s8;
            Refresh();
            con.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            
            SqlCommand com2 = new SqlCommand("select PRODNAME from PRODUCT where PRODID= '" + comboBox2.SelectedItem.ToString() + "'", con);
            string s2;
            s2 = com2.ExecuteScalar().ToString();
            textBox2.Text = s2;

            SqlCommand com3 = new SqlCommand("select COMPNAME from PRODUCT where PRODID= '" + comboBox2.SelectedItem.ToString() + "'", con);
            string s3;
            s3 = com3.ExecuteScalar().ToString();
            textBox4.Text = s3;

            SqlCommand com6 = new SqlCommand("select UNIT from PRODUCT where PRODID= '" + comboBox2.SelectedItem.ToString() + "'", con);
            string s6;
            s6 = com6.ExecuteScalar().ToString();
            textBox1.Text = s6;
            Refresh();
            con.Close();

                        
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com5 = new SqlCommand("select SUPPNAME from SUPPTABLE where SUPPCODE = '" + comboBox3.SelectedItem.ToString() + "'", con);
            string s5;
            s5 = com5.ExecuteScalar().ToString();
            textBox3.Text = s5;
            Refresh();
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com1 = new SqlCommand("Update PURCHTABLE set VOUCHERDT ='" + dateTimePicker1.Text + "'where VOUCHERNO = '" + comboBox1.SelectedItem + "'", con);
            com1.ExecuteNonQuery();
            SqlCommand com2 = new SqlCommand("Update PURCHTABLE set PRODID ='" + comboBox2.SelectedItem + "'where VOUCHERNO = '" + comboBox1.SelectedItem + "'", con);
            com2.ExecuteNonQuery();
            SqlCommand com3 = new SqlCommand("Update PURCHTABLE set PRODNAME='" + textBox2.Text + "'where PRODID = '" + comboBox2.SelectedItem + "'", con);
            com3.ExecuteNonQuery();
            SqlCommand com4 = new SqlCommand("Update PURCHTABLE set COMPANY='" + textBox4.Text + "'where PRODID = '" + comboBox2.SelectedItem + "'", con);
            com4.ExecuteNonQuery();
            SqlCommand com5 = new SqlCommand("Update PURCHTABLE set UNIT='" + textBox1.Text + "'where PRODID = '" + comboBox2.SelectedItem + "'", con);
            com5.ExecuteNonQuery();
            SqlCommand com6 = new SqlCommand("Update PURCHTABLE set SCODE ='" + comboBox3.SelectedItem + "'where VOUCHERNO = '" + comboBox1.SelectedItem + "'", con);
            com6.ExecuteNonQuery();
            SqlCommand com7 = new SqlCommand("Update PURCHTABLE set SNAME ='" + textBox3.Text + "'where SCODE = '" + comboBox3.SelectedItem + "'", con);
            com7.ExecuteNonQuery();
            SqlCommand com8 = new SqlCommand("Update PURCHTABLE set QTY ='" + textBox6.Text + "'where VOUCHERNO = '" + comboBox1.SelectedItem + "'", con);
            com8.ExecuteNonQuery();
            SqlCommand com9 = new SqlCommand("Update PURCHTABLE set PRICE ='" + textBox7.Text + "'where VOUCHERNO = '" + comboBox1.SelectedItem + "'", con);
            com9.ExecuteNonQuery();

            MessageBox.Show("Purchase Record updated Succesfully", "Congratulations", MessageBoxButtons.OK);

            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            Refresh();
            con.Close();
            
        }
    }
}
