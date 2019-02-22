using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICS
{
    public partial class rproduct : Form
    {
        public rproduct()
        {
            InitializeComponent();
        }

        private void rproduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iCSDataSet11.STOCKTABLE' table. You can move, or remove it, as needed.
            this.sTOCKTABLETableAdapter.Fill(this.iCSDataSet11.STOCKTABLE);
            // TODO: This line of code loads data into the 'iCSDataSet10.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.iCSDataSet10.PRODUCT);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
