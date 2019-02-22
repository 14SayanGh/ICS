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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select CUSCODE from CUSTABLE", con);
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
            SqlCommand com = new SqlCommand("select CUSNAME from CUSTABLE where CUSCODE= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s;
            s = com.ExecuteScalar().ToString();
            textBox2.Text = s;

            SqlCommand com1 = new SqlCommand("select CONTACT from CUSTABLE where CUSCODE= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s1;
            s1 = com1.ExecuteScalar().ToString();
            textBox3.Text = s1;

            SqlCommand com2 = new SqlCommand("select ADDRESS from CUSTABLE where CUSCODE= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s2;
            s2 = com2.ExecuteScalar().ToString();
            textBox4.Text = s2;

            SqlCommand com3 = new SqlCommand("select RDATE from CUSTABLE where CUSCODE= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s3;
            s3 = com3.ExecuteScalar().ToString();
            dateTimePicker1.Text = s3;
            Refresh();
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com1 = new SqlCommand("Update CUSTABLE set CUSNAME ='" + textBox2.Text + "'where CUSCODE = '" + comboBox1.SelectedItem + "'", con);
            com1.ExecuteNonQuery();
            SqlCommand com2 = new SqlCommand("Update CUSTABLE set ADDRESS ='" + textBox4.Text + "'where CUSCODE = '" + comboBox1.SelectedItem + "'", con);
            com2.ExecuteNonQuery();
            SqlCommand com3 = new SqlCommand("Update CUSTABLE set CONTACT ='" + textBox3.Text + "'where CUSCODE = '" + comboBox1.SelectedItem + "'", con);
            com3.ExecuteNonQuery();
            SqlCommand com4 = new SqlCommand("Update CUSTABLE set RDATE ='" + dateTimePicker1.Text + "'where CUSCODE = '" + comboBox1.SelectedItem + "'", con);
            com4.ExecuteNonQuery();

            MessageBox.Show("Customer Record updated Succesfully","Congratulations",MessageBoxButtons.OK);

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            Refresh();
            con.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
