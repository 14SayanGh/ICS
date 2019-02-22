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
    public partial class rpurchase : Form
    {
        public rpurchase()
        {
            InitializeComponent();
        }

        private void rpurchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iCSDataSet13.PURCHTABLE' table. You can move, or remove it, as needed.
            this.pURCHTABLETableAdapter.Fill(this.iCSDataSet13.PURCHTABLE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
