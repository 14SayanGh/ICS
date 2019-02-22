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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con=new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\hp\\documents\\visual studio 2010\\Projects\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("select PASSWORD from Reg1 where USERNAME='" + textBox1.Text + "'",con);
            string pass;
            pass=com.ExecuteScalar().ToString();
            if (textBox2.Text == pass)
            {
                
                MessageBox.Show("       Logged In Succesfully","User Matched!");
                textBox1.Text = "";
                textBox2.Text = ""; 
                Form1 form1 = new Form1();
                form1.Show();
                
            }
            else
            {
                MessageBox.Show("       Password Not Matched", "Caution!");
                textBox1.Text = "";
                textBox2.Text = "";               
            }
            Refresh();
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            linkLabel1.Enabled = false;
            button1.Enabled = false;
                     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            ChangePass frm = new ChangePass();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Enabled = true;
                linkLabel1.Enabled = true;
                if (textBox2.Text != "")
                {
                    button1.Enabled = true;
                }
            }
            else if (textBox1.Text == "")
            {
                textBox2.Enabled = false;
                linkLabel1.Enabled = false;
                button1.Enabled = false;
            }
        }
    }
}
