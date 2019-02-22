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
    public partial class StockEntry : Form
    {
        public StockEntry()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void StockEntry_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            button1.Enabled = false;
            // TODO: This line of code loads data into the 'iCSDataSet9.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.iCSDataSet9.PRODUCT);
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select SUPPCODE from SUPPTABLE",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox2.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            // TODO: This line of code loads data into the 'iCSDataSet2.SUPPTABLE' table. You can move, or remove it, as needed.
            this.sUPPTABLETableAdapter.Fill(this.iCSDataSet2.SUPPTABLE);


            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select PRODID from PRODUCT", con1);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds1.Tables[0].Rows[i][0].ToString());
            }
            Refresh();
            con.Close();
            Refresh();
            con1.Close();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Sayan Ghosh\\Desktop\\ICSnew\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();

            SqlCommand com1 = new SqlCommand("select QTY from PURCHTABLE where PRODID = '" + comboBox1.SelectedItem +/*"' and SCODE='" + comboBox2.SelectedItem + */"'", con);
            double c;
            c = Convert.ToDouble(com1.ExecuteScalar());
            textBox2.Text = c.ToString();
            MessageBox.Show("       Current Stock Updated!", "Congratulations!");
            
            SqlCommand com = new SqlCommand("Insert into STOCKTABLE values('" + comboBox1.SelectedItem + "','" + textBox4.Text + "','" + comboBox2.SelectedItem + "','" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox6.Text + "','" + textBox3.Text + "')", con);
            com.ExecuteNonQuery();
            MessageBox.Show("       Record added Successfully!", "Congratulations!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox2.Text = "";
            comboBox2.Enabled = false;
            button1.Enabled = false;

            Refresh();
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\hp\\documents\\visual studio 2010\\Projects\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("select SUPPNAME from SUPPTABLE where SUPPCODE= '" + comboBox2.SelectedItem.ToString() + "'", con);
            string s;
            s = com.ExecuteScalar().ToString();
            textBox5.Text = s;
            Refresh();
            con.Close();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\hp\\documents\\visual studio 2010\\Projects\\ICS\\ICS\\ICS.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            SqlCommand com = new SqlCommand("select PRODNAME from PRODUCT where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s1;
            s1 = com.ExecuteScalar().ToString();
            textBox4.Text = s1;

            SqlCommand com1 = new SqlCommand("select COMPNAME from PRODUCT where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s2;
            s2 = com1.ExecuteScalar().ToString();
            textBox6.Text = s2;

            SqlCommand com2 = new SqlCommand("select UNIT from PRODUCT where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s3;
            s3 = com2.ExecuteScalar().ToString();
            textBox1.Text = s3;

            SqlCommand com3 = new SqlCommand("select MFDATE from PRODUCT where PRODID= '" + comboBox1.SelectedItem.ToString() + "'", con);
            string s4;
            s4 = com3.ExecuteScalar().ToString();
            textBox3.Text = s4;
            Refresh();
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                comboBox2.Enabled = true;
                if (textBox5.Text != "")
                {
                    button1.Enabled = true;
                }
            }
        }
    }
}
