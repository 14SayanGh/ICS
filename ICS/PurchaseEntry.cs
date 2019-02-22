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
    public partial class PurchaseEntry : Form
    {
        public PurchaseEntry()
        {
            InitializeComponent();
        }

        private void PurchaseEntry_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            comboBox5.Enabled = false;
            comboBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button1.Enabled = false;

            // TODO: This line of code loads data into the 'iCSDataSet6.STOCKTABLE' table. You can move, or remove it, as needed.
            this.sTOCKTABLETableAdapter.Fill(this.iCSDataSet6.STOCKTABLE);
            // TODO: This line of code loads data into the 'iCSDataSet3.SUPPTABLE' table. You can move, or remove it, as needed.
            this.sUPPTABLETableAdapter.Fill(this.iCSDataSet3.SUPPTABLE);

            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();

            Refresh();

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
            SqlCommand cmd1 = new SqlCommand("select SUPPCODE from SUPPTABLE", con1);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("select PRODNAME from PRODUCT where PRODID= '" + comboBox5.SelectedItem.ToString() + "'", con);
            string s;
            s = com.ExecuteScalar().ToString();
            textBox2.Text = s;

            SqlCommand com1 = new SqlCommand("select COMPNAME from PRODUCT where PRODID= '" + comboBox5.SelectedItem.ToString() + "'", con);
            string s1;
            s1 = com1.ExecuteScalar().ToString();
            textBox4.Text = s1;

            SqlCommand com2 = new SqlCommand("select UNIT from PRODUCT where PRODID= '" + comboBox5.SelectedItem.ToString() + "'", con);
            string s2;
            s2 = com2.ExecuteScalar().ToString();
            textBox7.Text = s2;
            Refresh();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("Insert into PURCHTABLE values('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + comboBox5.SelectedItem + "','" + textBox2.Text + "','" + textBox4.Text + "','" + comboBox4.SelectedItem + "','" + textBox3.Text + "','" + textBox7.Text+ "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
            com.ExecuteNonQuery();

            
            SqlCommand com1 = new SqlCommand("select CSTOCK from STOCKTABLE where PRODID = '" + comboBox5.SelectedItem + "'",con);
            double c;
            c =Convert.ToDouble(com1.ExecuteScalar());
            
            double newstock;
            double addstock;
            addstock=Convert.ToDouble(textBox5.Text);
            newstock = c + addstock;
            
            SqlCommand com2 = new SqlCommand("Update STOCKTABLE set CSTOCK ='"+ newstock +"'where PRODID = '" + comboBox5.SelectedItem + "'", con);
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
            comboBox4.Text = "";
            comboBox5.Text = "";
            dateTimePicker1.Enabled = false;
            comboBox5.Enabled = false;
            comboBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button1.Enabled = false;
         
            Refresh();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\hp\\documents\\visual studio 2010\\Projects\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("select SUPPNAME from SUPPTABLE where SUPPCODE= '" + comboBox4.SelectedItem.ToString() + "'", con);
            string s;
            s = com.ExecuteScalar().ToString();
            textBox3.Text = s;
            Refresh();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                comboBox5.Enabled = true;
                dateTimePicker1.Enabled = true;
                if (textBox2.Text != "")
                {
                    comboBox4.Enabled = true;
                    if (textBox3.Text != "" && textBox2.Text != "")
                    {
                        textBox5.Enabled = true;
                        if (textBox5.Text != "")
                        {
                            textBox6.Enabled = true;
                            {
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
}
