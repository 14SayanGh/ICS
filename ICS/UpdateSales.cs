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
    public partial class UpdateSales : Form
    {
        public UpdateSales()
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

        private void UpdateSales_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select PRODID from PRODUCT", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox5.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select CUSCODE from CUSTABLE", con1);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                comboBox4.Items.Add(ds1.Tables[0].Rows[i][0].ToString());
            }

            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select VNO from SALETABLE", con2);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                comboBox6.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
            }
            Refresh();
            con.Close();
            con1.Close();
            con2.Close();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            
            SqlCommand com = new SqlCommand("select VDATE from SALETABLE where VNO= '" + comboBox6.SelectedItem.ToString() + "'", con);
            string s;
            s = com.ExecuteScalar().ToString();
            dateTimePicker1.Text = s;

            SqlCommand com1 = new SqlCommand("select PRODID from SALETABLE where VNO= '" + comboBox6.SelectedItem.ToString() + "'", con);
            string s1;
            s1 = com1.ExecuteScalar().ToString();
            comboBox5.SelectedItem = s1;

            SqlCommand com2 = new SqlCommand("select CUSCODE from SALETABLE where VNO= '" + comboBox6.SelectedItem.ToString() + "'", con);
            string s2;
            s2 = com2.ExecuteScalar().ToString();
            comboBox4.SelectedItem = s2;

            SqlCommand com7 = new SqlCommand("select QTY from SALETABLE where VNO= '" + comboBox6.SelectedItem.ToString() + "'", con);
            string s7;
            s7 = com7.ExecuteScalar().ToString();
            textBox5.Text = s7;

            SqlCommand com8 = new SqlCommand("select UPRICE from SALETABLE where VNO= '" + comboBox6.SelectedItem.ToString() + "'", con);
            string s8;
            s8 = com8.ExecuteScalar().ToString();
            textBox6.Text = s8;

            SqlCommand com9 = new SqlCommand("select TOTPRICE from SALETABLE where VNO= '" + comboBox6.SelectedItem.ToString() + "'", con);
            string s9;
            s9 = com9.ExecuteScalar().ToString();
            textBox7.Text = s9;
                        
            Refresh();
            con.Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();


            SqlCommand com3 = new SqlCommand("select PRODNAME from PRODUCT where PRODID= '" + comboBox5.SelectedItem.ToString() + "'", con);
            string s3;
            s3 = com3.ExecuteScalar().ToString();
            textBox2.Text = s3;

            SqlCommand com5 = new SqlCommand("select COMPNAME from PRODUCT where PRODID= '" + comboBox5.SelectedItem.ToString() + "'", con);
            string s5;
            s5 = com5.ExecuteScalar().ToString();
            textBox4.Text = s5;

            SqlCommand com6 = new SqlCommand("select UNIT from PRODUCT where PRODID= '" + comboBox5.SelectedItem.ToString() + "'", con);
            string s6;
            s6 = com6.ExecuteScalar().ToString();
            textBox3.Text = s6;

            Refresh();
            con.Close();
            
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            
            SqlCommand com4 = new SqlCommand("select CONTACT from CUSTABLE where CUSCODE= '" + comboBox4.SelectedItem.ToString() + "'", con);
            string s4;
            s4 = com4.ExecuteScalar().ToString();
            textBox1.Text = s4;

            Refresh();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox6.Text != "")
            {
                textBox7.Text = (int.Parse(textBox5.Text) * int.Parse(textBox6.Text)).ToString();
            }
            MessageBox.Show("       Total price calculated!", "");

            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            
            /*SqlCommand com1 = new SqlCommand("select CSTOCK from STOCKTABLE where PRODID = '" + comboBox5.SelectedItem + "'", con);
            double c;
            c = Convert.ToDouble(com1.ExecuteScalar());
            textBox8.Text = c.ToString();
            double newstock;
            double salestock;
            salestock = Convert.ToDouble(textBox5.Text);
            newstock = c - salestock;
            if (newstock >= 0)
            {
                textBox8.Text = newstock.ToString();*/
                SqlCommand com2 = new SqlCommand("Update SALETABLE set QTY ='" + textBox5.Text + "'where VNO = '" + comboBox6.SelectedItem + "'", con);
                com2.ExecuteNonQuery();
                SqlCommand com3 = new SqlCommand("Update SALETABLE set VDATE ='" + dateTimePicker1.Text + "'where VNO = '" + comboBox6.SelectedItem + "'", con);
                com3.ExecuteNonQuery();
                SqlCommand com4 = new SqlCommand("Update SALETABLE set PRODID ='" + comboBox5.SelectedItem + "'where VNO = '" + comboBox6.SelectedItem + "'", con);
                com4.ExecuteNonQuery();
                SqlCommand com5 = new SqlCommand("Update SALETABLE set PRODNAME ='" + textBox2.Text + "'where PRODID = '" + comboBox5.SelectedItem + "'", con);
                com5.ExecuteNonQuery();
                SqlCommand com6 = new SqlCommand("Update SALETABLE set COMPANY ='" + textBox4.Text + "'where PRODID = '" + comboBox5.SelectedItem + "'", con);
                com6.ExecuteNonQuery();
                SqlCommand com7 = new SqlCommand("Update SALETABLE set CUSCODE ='" + comboBox4.SelectedItem + "'where VNO = '" + comboBox6.SelectedItem + "'", con);
                com7.ExecuteNonQuery();
                SqlCommand com8 = new SqlCommand("Update SALETABLE set CUSCONTACT ='" + textBox1.Text + "'where CUSCODE = '" + comboBox4.SelectedItem + "'", con);
                com8.ExecuteNonQuery();
                SqlCommand com9 = new SqlCommand("Update SALETABLE set UNIT ='" + textBox3.Text + "'where PRODID = '" + comboBox5.SelectedItem + "'", con);
                com9.ExecuteNonQuery();
                SqlCommand com10 = new SqlCommand("Update SALETABLE set UPRICE ='" + textBox6.Text + "'where VNO = '" + comboBox6.SelectedItem + "'", con);
                com10.ExecuteNonQuery();
                SqlCommand com11 = new SqlCommand("Update SALETABLE set TOTPRICE ='" + textBox7.Text + "'where VNO = '" + comboBox6.SelectedItem + "'", con);
                com11.ExecuteNonQuery();
                                
                MessageBox.Show("       Record update Successfully!", "Congratulations!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                /*textBox8.Text = "";*/
                
                comboBox4.SelectedItem = "";
                comboBox5.SelectedItem = "";
            /*}
            else
            {
                MessageBox.Show("  Transaction Cancelled, Stock Low", "CAUTION");
            }*/

            Refresh();
            con.Close();
        }
    }
}
