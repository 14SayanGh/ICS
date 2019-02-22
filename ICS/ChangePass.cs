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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("select PASSWORD from Reg1 where USERNAME='" + textBox1.Text + "'", con);
            string pass;
            pass = com.ExecuteScalar().ToString();
            if (textBox2.Text == pass)
            {
                SqlCommand com1 = new SqlCommand("Update Reg1 set PASSWORD='"+textBox3.Text+"' where USERNAME = '"+textBox1.Text+"'", con);
                com1.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("       Password Changed", "Successful!");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("       Password Not Matched", "Caution!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            Refresh();
            con.Close();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
