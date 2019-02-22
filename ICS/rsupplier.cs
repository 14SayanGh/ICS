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
    public partial class rsupplier : Form
    {
        public rsupplier()
        {
            InitializeComponent();
        }

        private void rsupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iCSDataSet12.SUPPTABLE' table. You can move, or remove it, as needed.
            this.sUPPTABLETableAdapter.Fill(this.iCSDataSet12.SUPPTABLE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
