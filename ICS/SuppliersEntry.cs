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
    public partial class SuppliersEntry : Form
    {
        public SuppliersEntry()
        {
            InitializeComponent();
        }

        private void SuppliersEntry_Load(object sender, EventArgs e)
        {
            /*textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            dateTimePicker1.Enabled = false;
            button1.Enabled = false;*/
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("Insert into SUPPTABLE values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox4.Text + "','" + textBox8.Text + "')", con);
            com.ExecuteNonQuery();
            MessageBox.Show("       Record added Successfully!", "Congratulations!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox4.Text = "";
            textBox8.Text = "";
            /*textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            dateTimePicker1.Enabled = false;*/

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
                        textBox3.Enabled = true;
                        if (textBox3.Text != "")
                        {
                            textBox7.Enabled = true;
                            if (textBox7.Text != "")
                            {
                                textBox6.Enabled = true;
                                if (textBox6.Text != "")
                                {
                                    textBox4.Enabled = true;
                                    if (textBox4.Text != "")
                                    {
                                        textBox8.Enabled = true;
                                        if (textBox8.Text != "")
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
    }
}
