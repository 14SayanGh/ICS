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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void stockEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StockEntry().Show();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void suppliersEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SuppliersEntry().Show();
        }

        private void customersEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerEntry().Show();
        }

        private void purchaseEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PurchaseEntry().Show();
        }

        private void salesEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Product().Show();
        }

        private void customerRecordAfterSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerAfterSales().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stockEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new UpdateStock().Show();
        }

        private void suppliersEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new UpdateSupplier().Show();
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new UpdateProduct().Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateCustomer().Show();
        }

        private void purchaseEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new UpdatePurchase().Show();
        }

        private void productENtryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeleteProduct().Show();
        }

        private void salesEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new UpdateSales().Show();
        }

        private void stockEntryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new DeleteStock().Show();
        }

        private void suppliersEntryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new DeleteSupplier().Show();
        }

        private void customersEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new DeleteCustomer().Show();
        }

        private void purchaseEntryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new DeletePurchase().Show();
        }

        private void salesEntryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new DeleteSales().Show();
        }

        private void productEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Product().Show();
        }

        private void supplierEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SuppliersEntry().Show();
        }

        private void customerEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerEntry().Show();
        }

        private void productToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new UpdateProduct().Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateSupplier().Show();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new UpdateCustomer().Show();
        }

        private void productEntryToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new DeleteProduct().Show();
        }

        private void supplierEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new DeleteSupplier().Show();
        }

        private void customerEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new DeleteCustomer().Show();
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rproduct().Show(); 
        }

        private void allSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rsupplier().Show();
        }

        private void allProductsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new rpurchase().Show();
        }

        private void allSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rsales().Show();
        }

        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rcustomer().Show();
        }

        private void particularProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void byProductNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new particular_product().Show();
        }

        private void byIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new particular_products1().Show();
        }

        private void byComapnyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new particular_products2().Show();
        }

        private void bySupplierCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new particular_supplier().Show();
        }

        private void bySupplierNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new particular_supplier1().Show();
        }

        private void byCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new particular_supplier2().Show();
        }

        private void byVoucherNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new particular_purchase().Show();
        }

        private void byProductIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new particular_purchase1().Show();
        }

        private void byProductNameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new particular_purchase2().Show();
        }

        private void byCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new particular_purchase3().Show();
        }

        private void bySuppliersNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new particular_purchase4().Show();
        }

        private void byCustomersCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new particular_customer().Show();
        }

        private void byCustomersNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new particular_customer1().Show();
        }

        private void byVoucherNumberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new particular_sales().Show();
        }

        private void byProductNameToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new particular_sales1().Show();
        }

        private void byCompanyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new particular_sales2().Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void salesEntryToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new SalesEntry().Show();
        }
    }
}
