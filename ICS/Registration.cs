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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (radioButton1.Checked == true)
            {
                sex = "Male";
            }
            if (radioButton2.Checked == true)
            {
                sex = "Female";
            }
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("Insert into Reg1 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + sex + "','" + textBox5.Text + "')",con);
            com.ExecuteNonQuery();
            MessageBox.Show("       User Created Successfully!","Congratulations!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            sex = "";

            Refresh();
            con.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Enabled = true;
                if (textBox2.Text != "")
                {
                    textBox3.Enabled = true;
                    if (textBox3.Text != "")
                    {
                        textBox4.Enabled = true;
                        if (textBox4.Text != "")
                        {
                            radioButton1.Enabled = true;
                            radioButton2.Enabled = true;
                            if (radioButton1.Checked == true || radioButton2.Checked == true)
                            {
                                textBox5.Enabled = true;
                                if (textBox5.Text != "")
                                {
                                    button2.Enabled = true;
                                }
                                else
                                {
                                    button2.Enabled = false;
                                }
                            }
                            else
                            {
                                textBox5.Enabled = false;
                            }
                        }
                        else
                        {
                            radioButton1.Checked = false;
                            radioButton2.Checked = false;
                            radioButton1.Enabled = false;
                            radioButton2.Enabled = false;
                        }
                    }
                    else
                    {
                        textBox4.Enabled = false;
                    }
                }
                else
                {
                    textBox3.Enabled = false;
                }
            }
            else if (textBox1.Text == "")
            {
                textBox2.Enabled = false;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
