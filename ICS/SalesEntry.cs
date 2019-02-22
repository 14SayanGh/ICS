

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
    public partial class SalesEntry : Form
    {
        public SalesEntry()
        {
            InitializeComponent();
        }

        private void SalesEntry_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            comboBox5.Enabled = false;
            comboBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button1.Enabled = false;

            // TODO: This line of code loads data into the 'iCSDataSet8.PURCHTABLE' table. You can move, or remove it, as needed.
            this.pURCHTABLETableAdapter.Fill(this.iCSDataSet8.PURCHTABLE);
            // TODO: This line of code loads data into the 'iCSDataSet7.STOCKTABLE' table. You can move, or remove it, as needed.
            this.sTOCKTABLETableAdapter.Fill(this.iCSDataSet7.STOCKTABLE);
            // TODO: This line of code loads data into the 'iCSDataSet4.CUSTABLE' table. You can move, or remove it, as needed.
            this.cUSTABLETableAdapter.Fill(this.iCSDataSet4.CUSTABLE);

            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select PRODID from STOCKTABLE", con);
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
            Refresh();
            con.Close();
            Refresh();
            con1.Close();

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
                  
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("       Enter Quantity to sell!", "ALERT");
            }
            else if(textBox6.Text=="")
            {
                MessageBox.Show("       Enter price of unit commodity", "ALERT");
            }

            else if (textBox5.Text != "" && textBox6.Text != "")
            {
                textBox7.Text = (int.Parse(textBox5.Text) * int.Parse(textBox6.Text)).ToString();
            }
            MessageBox.Show("       Total price calculated!","");
            
            
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\hp\\documents\\visual studio 2010\\Projects\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            
            /*SqlCommand com1 = new SqlCommand("select CSTOCK from STOCKTABLE where PRODID = '" + comboBox5.SelectedItem + "'", con);
            double c;
            c =Convert.ToDouble(com1.ExecuteScalar().ToString());
            textBox8.Text = c.ToString();
             
             MessageBox.Show("       Current Stock fetched", "Processed");*/

            SqlCommand com3 = new SqlCommand("select CSTOCK from STOCKTABLE where PRODID = '" + comboBox5.SelectedItem + "'", con);
            double c;
            c = Convert.ToDouble(com3.ExecuteScalar().ToString());

             double newstock;
             double salestock;
             salestock = Convert.ToDouble(textBox5.Text);
             newstock = c - salestock;
             if (newstock >= 0)
             {
                 textBox8.Text = newstock.ToString();
                 SqlCommand com = new SqlCommand("Insert into SALETABLE values('" + textBox9.Text + "','" + dateTimePicker1.Text + "','" + comboBox5.SelectedItem + "','" + comboBox4.SelectedItem + "','" + textBox2.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')", con);
                 com.ExecuteNonQuery();
                 

                 SqlCommand com2 = new SqlCommand("Update STOCKTABLE set CSTOCK ='" + newstock + "'where PRODID = '" + comboBox5.SelectedItem + "'", con);
                 com2.ExecuteNonQuery();
                 MessageBox.Show(" you have succesfully updated stock");

                 MessageBox.Show("       Record added Successfully!", "Congratulations!");
                 
                 textBox1.Text = "";
                 textBox2.Text = "";
                 textBox3.Text = "";
                 textBox4.Text = "";
                 textBox5.Text = "";
                 textBox6.Text = "";
                 textBox7.Text = "";
                 textBox8.Text = "";

                 dateTimePicker1.Enabled = false;
                 comboBox5.Enabled = false;
                 comboBox4.Enabled = false;
                 textBox5.Enabled = false;
                 textBox6.Enabled = false;
                 button1.Enabled = false;
                 
             }
             else
             {
                 MessageBox.Show("  Transaction Cancelled, Stock Low", "CAUTION");
             }

            Refresh();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\hp\\documents\\visual studio 2010\\Projects\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("select PRODNAME from STOCKTABLE where PRODID= '" + comboBox5.SelectedItem.ToString() + "'", con);
            string s;
            s = com.ExecuteScalar().ToString();
            textBox2.Text = s;

            SqlCommand com1 = new SqlCommand("select COMPANY from STOCKTABLE where PRODID= '" + comboBox5.SelectedItem.ToString() + "'", con);
            string s1;
            s1 = com1.ExecuteScalar().ToString();
            textBox4.Text = s1;

            SqlCommand com2 = new SqlCommand("select UNIT from STOCKTABLE where PRODID= '" + comboBox5.SelectedItem.ToString() + "'", con);
            string s2;
            s2 = com2.ExecuteScalar().ToString();
            textBox3.Text = s2;

            SqlCommand com3 = new SqlCommand("select CSTOCK from STOCKTABLE where PRODID = '" + comboBox5.SelectedItem + "'", con);
            string s3;
            s3 = com3.ExecuteScalar().ToString();
            textBox8.Text=s3;

            MessageBox.Show("       Current Stock fetched", "Processed");

            Refresh();
            con.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\hp\\documents\\visual studio 2010\\Projects\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            Refresh();
            SqlCommand com = new SqlCommand("select CONTACT from CUSTABLE where CUSCODE= '" + comboBox4.SelectedItem.ToString() + "'", con);
            string s;
            s = com.ExecuteScalar().ToString();
            textBox1.Text = s;
            Refresh();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                dateTimePicker1.Enabled = true;
                if (dateTimePicker1.Focused == true)
                {
                    comboBox5.Enabled = true;
                    comboBox4.Enabled = true;
                    if (textBox1.Text != "")
                    {
                        textBox5.Enabled = true;
                        if (textBox5.Text != "")
                        {
                            textBox6.Enabled = true;
                            if (textBox6.Text != "")
                            {
                                button1.Enabled = true;
                            }
                        }

                    }
                }
            }
        }
    }
}
