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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select PRODID from PRODUCT", con);
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
            SqlCommand com = new SqlCommand("select PRODNAME from PRODUCT where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s;
            s = com.ExecuteScalar().ToString();
            textBox2.Text = s;

            SqlCommand com1 = new SqlCommand("select COMPNAME from PRODUCT where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s1;
            s1 = com1.ExecuteScalar().ToString();
            textBox3.Text = s1;

            SqlCommand com2 = new SqlCommand("select UNIT from PRODUCT where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s2;
            s2 = com2.ExecuteScalar().ToString();
            comboBox4.SelectedItem = s2;

            SqlCommand com3 = new SqlCommand("select MFDATE from PRODUCT where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s3;
            s3 = com3.ExecuteScalar().ToString();
            dateTimePicker1.Text = s3;
            Refresh();
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com1 = new SqlCommand("Update PRODUCT set PRODNAME ='" + textBox2.Text + "'where PRODID = '" + comboBox1.SelectedItem + "'", con);
            com1.ExecuteNonQuery();
            SqlCommand com2 = new SqlCommand("Update PRODUCT set COMPNAME ='" + textBox3.Text + "'where PRODID = '" + comboBox1.SelectedItem + "'", con);
            com2.ExecuteNonQuery();
            SqlCommand com3 = new SqlCommand("Update PRODUCT set MFDATE ='" + dateTimePicker1.Text + "'where PRODID = '" + comboBox1.SelectedItem + "'", con);
            com3.ExecuteNonQuery();
            SqlCommand com4 = new SqlCommand("Update PRODUCT set UNIT ='" + comboBox4.Text + "'where PRODID = '" + comboBox1.SelectedItem + "'", con);
            com4.ExecuteNonQuery();
            
            MessageBox.Show("Product Record updated Succesfully", "Congratulations", MessageBoxButtons.OK);

            textBox2.Text = "";
            textBox3.Text = "";

            Refresh();
            con.Close();
            
       }
    }
}
