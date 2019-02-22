﻿using System;
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
    public partial class DeleteSupplier : Form
    {
        public DeleteSupplier()
        {
            InitializeComponent();
        }

        private void DeleteSupplier_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select SUPPCODE from SUPPTABLE", con);
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

            SqlCommand com = new SqlCommand("select SUPPNAME from SUPPTABLE where SUPPCODE= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s;
            s = com.ExecuteScalar().ToString();
            textBox1.Text = s;

            SqlCommand com1 = new SqlCommand("select REGDATE from SUPPTABLE where SUPPCODE= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s1;
            s1 = com1.ExecuteScalar().ToString();
            textBox2.Text = s1;

            SqlCommand com2 = new SqlCommand("select CITY from SUPPTABLE where SUPPCODE= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s2;
            s2 = com2.ExecuteScalar().ToString();
            textBox3.Text = s2;

            SqlCommand com3 = new SqlCommand("select CONTACTNO from SUPPTABLE where SUPPCODE= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s3;
            s3 = com3.ExecuteScalar().ToString();
            textBox4.Text = s3;

            SqlCommand com4 = new SqlCommand("select PIN from SUPPTABLE where SUPPCODE= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s4;
            s4 = com4.ExecuteScalar().ToString();
            textBox5.Text = s4;

            SqlCommand com5 = new SqlCommand("select ADDRESS from SUPPTABLE where SUPPCODE= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s5;
            s5 = com5.ExecuteScalar().ToString();
            textBox6.Text = s5;

            SqlCommand com6 = new SqlCommand("select EMAIL from SUPPTABLE where SUPPCODE= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s6;
            s6 = com6.ExecuteScalar().ToString();
            textBox7.Text = s6;
            Refresh();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("Delete from SUPPTABLE where SUPPCODE = '" + comboBox1.SelectedItem + "'", con);
            com.ExecuteNonQuery();
            MessageBox.Show("       Record deleted Successfully!", "Congratulations!");
            comboBox1.SelectedItem = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            Refresh();
            con.Close();
        }
    }
}
