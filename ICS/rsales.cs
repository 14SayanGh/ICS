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
    public partial class rsales : Form
    {
        public rsales()
        {
            InitializeComponent();
        }

        private void rsales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iCSDataSet14.SALETABLE' table. You can move, or remove it, as needed.
            this.sALETABLETableAdapter.Fill(this.iCSDataSet14.SALETABLE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
