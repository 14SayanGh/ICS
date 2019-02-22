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
    public partial class UpdateSupplier : Form
    {
        public UpdateSupplier()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
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
            textBox2.Text = s;

            SqlCommand com1 = new SqlCommand("select REGDATE from SUPPTABLE where SUPPCODE= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s1;
            s1 = com1.ExecuteScalar().ToString();
            dateTimePicker1.Text = s1;

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
            textBox7.Text = s5;

            SqlCommand com6 = new SqlCommand("select EMAIL from SUPPTABLE where SUPPCODE= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s6;
            s6 = com6.ExecuteScalar().ToString();
            textBox6.Text = s6;
            Refresh();
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com1 = new SqlCommand("Update SUPPTABLE set SUPPNAME ='" + textBox2.Text + "'where SUPPCODE = '" + comboBox1.SelectedItem + "'", con);
            com1.ExecuteNonQuery();
            SqlCommand com2 = new SqlCommand("Update SUPPTABLE set ADDRESS ='" + textBox7.Text + "'where SUPPCODE = '" + comboBox1.SelectedItem + "'", con);
            com2.ExecuteNonQuery();
            SqlCommand com3 = new SqlCommand("Update SUPPTABLE set CONTACTNO ='" + textBox4.Text + "'where SUPPCODE = '" + comboBox1.SelectedItem + "'", con);
            com3.ExecuteNonQuery();
            SqlCommand com4 = new SqlCommand("Update SUPPTABLE set REGDATE ='" + dateTimePicker1.Text + "'where SUPPCODE = '" + comboBox1.SelectedItem + "'", con);
            com4.ExecuteNonQuery();
            SqlCommand com5 = new SqlCommand("Update SUPPTABLE set CITY ='" + textBox3.Text + "'where SUPPCODE = '" + comboBox1.SelectedItem + "'", con);
            com5.ExecuteNonQuery();
            SqlCommand com6 = new SqlCommand("Update SUPPTABLE set EMAIL ='" + textBox6.Text + "'where SUPPCODE = '" + comboBox1.SelectedItem + "'", con);
            com6.ExecuteNonQuery();
            SqlCommand com7 = new SqlCommand("Update SUPPTABLE set PIN ='" + textBox5.Text + "'where SUPPCODE = '" + comboBox1.SelectedItem + "'", con);
            com7.ExecuteNonQuery();

            MessageBox.Show("Supplier Record updated Succesfully", "Congratulations", MessageBoxButtons.OK);

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
