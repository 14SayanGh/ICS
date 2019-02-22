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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            comboBox4.Enabled = false;
            button1.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("Insert into PRODUCT values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox4.SelectedItem + "','" + dateTimePicker1.Text + "')", con);
            com.ExecuteNonQuery();
            MessageBox.Show("       Record added Successfully!", "Congratulations!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox4.Text = "";

            textBox2.Enabled = false;
            textBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            comboBox4.Enabled = false;
            button1.Enabled = false;

            Refresh();
            con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Enabled = true;
                if (textBox2.Text != "")
                {
                    dateTimePicker1.Enabled = true;
                    if (dateTimePicker1.Focused == true)
                    {
                        comboBox4.Enabled = true;
                        if (comboBox4.Focused == true)
                        {
                            textBox3.Enabled = true;
                            if (textBox3.Text != "")
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
