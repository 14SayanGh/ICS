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
    public partial class rcustomer : Form
    {
        public rcustomer()
        {
            InitializeComponent();
        }

        private void rcustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iCSDataSet15.CUSTABLE' table. You can move, or remove it, as needed.
            this.cUSTABLETableAdapter.Fill(this.iCSDataSet15.CUSTABLE);

        }
    }
}
