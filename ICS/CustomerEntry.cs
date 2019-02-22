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
    public partial class CustomerEntry : Form
    {
        public CustomerEntry()
        {
            InitializeComponent();
        }

        private void CustomerEntry_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            dateTimePicker1.Enabled = false;
            button1.Enabled = false;

            // TODO: This line of code loads data into the 'iCSDataSet5.STOCKTABLE' table. You can move, or remove it, as needed.
            this.sTOCKTABLETableAdapter.Fill(this.iCSDataSet5.STOCKTABLE);
       
            /*string[] x = { "JAN", "FEB", "MAR", "APR", "JUN", "JUL", "AUG", "SEPT", "OCT", "NOV", "DEC" };
            comboBox2.Items.AddRange(x);*/
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void customerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string dat = "";
            string dd = "";
            string mm = "";
            string yy = "";
            dd = comboBox1.SelectedItem.ToString();
            mm = comboBox2.SelectedItem.ToString();
            yy = comboBox3.SelectedItem.ToString();
            dat = dd + "/" + mm + "/" + yy;*/

            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("Insert into CUSTABLE values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "')", con);
            com.ExecuteNonQuery();
            MessageBox.Show("       Record added Successfully!", "Congratulations!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            /*comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";*/

            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            dateTimePicker1.Enabled = false;
            button1.Enabled = false;

            Refresh();
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                            textBox4.Enabled = true;
                            if (textBox4.Text != "")
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
