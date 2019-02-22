namespace ICS
{
    partial class rsales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSCONTACTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURRSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALETABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iCSDataSet14 = new ICS.ICSDataSet14();
            this.sALETABLETableAdapter = new ICS.ICSDataSet14TableAdapters.SALETABLETableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALETABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCSDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vNODataGridViewTextBoxColumn,
            this.vDATEDataGridViewTextBoxColumn,
            this.pRODIDDataGridViewTextBoxColumn,
            this.cUSCODEDataGridViewTextBoxColumn,
            this.pRODNAMEDataGridViewTextBoxColumn,
            this.cUSCONTACTDataGridViewTextBoxColumn,
            this.cOMPANYDataGridViewTextBoxColumn,
            this.uNITDataGridViewTextBoxColumn,
            this.qTYDataGridViewTextBoxColumn,
            this.uPRICEDataGridViewTextBoxColumn,
            this.tOTPRICEDataGridViewTextBoxColumn,
            this.cURRSTOCKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sALETABLEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(1390, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // vNODataGridViewTextBoxColumn
            // 
            this.vNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.vNODataGridViewTextBoxColumn.DataPropertyName = "VNO";
            this.vNODataGridViewTextBoxColumn.HeaderText = "VOUCHER NUMBER";
            this.vNODataGridViewTextBoxColumn.Name = "vNODataGridViewTextBoxColumn";
            this.vNODataGridViewTextBoxColumn.ReadOnly = true;
            this.vNODataGridViewTextBoxColumn.Width = 150;
            // 
            // vDATEDataGridViewTextBoxColumn
            // 
            this.vDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.vDATEDataGridViewTextBoxColumn.DataPropertyName = "VDATE";
            this.vDATEDataGridViewTextBoxColumn.HeaderText = "VOUCHER DATE";
            this.vDATEDataGridViewTextBoxColumn.Name = "vDATEDataGridViewTextBoxColumn";
            this.vDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.vDATEDataGridViewTextBoxColumn.Width = 130;
            // 
            // pRODIDDataGridViewTextBoxColumn
            // 
            this.pRODIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pRODIDDataGridViewTextBoxColumn.DataPropertyName = "PRODID";
            this.pRODIDDataGridViewTextBoxColumn.HeaderText = "PRODUCT ID";
            this.pRODIDDataGridViewTextBoxColumn.Name = "pRODIDDataGridViewTextBoxColumn";
            this.pRODIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODIDDataGridViewTextBoxColumn.Width = 108;
            // 
            // cUSCODEDataGridViewTextBoxColumn
            // 
            this.cUSCODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cUSCODEDataGridViewTextBoxColumn.DataPropertyName = "CUSCODE";
            this.cUSCODEDataGridViewTextBoxColumn.HeaderText = "CUSTOMER CODE";
            this.cUSCODEDataGridViewTextBoxColumn.Name = "cUSCODEDataGridViewTextBoxColumn";
            this.cUSCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSCODEDataGridViewTextBoxColumn.Width = 141;
            // 
            // pRODNAMEDataGridViewTextBoxColumn
            // 
            this.pRODNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pRODNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODNAME";
            this.pRODNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT NAME";
            this.pRODNAMEDataGridViewTextBoxColumn.Name = "pRODNAMEDataGridViewTextBoxColumn";
            this.pRODNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODNAMEDataGridViewTextBoxColumn.Width = 132;
            // 
            // cUSCONTACTDataGridViewTextBoxColumn
            // 
            this.cUSCONTACTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cUSCONTACTDataGridViewTextBoxColumn.DataPropertyName = "CUSCONTACT";
            this.cUSCONTACTDataGridViewTextBoxColumn.HeaderText = "CUSTOMER CONTACT";
            this.cUSCONTACTDataGridViewTextBoxColumn.Name = "cUSCONTACTDataGridViewTextBoxColumn";
            this.cUSCONTACTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSCONTACTDataGridViewTextBoxColumn.Width = 165;
            // 
            // cOMPANYDataGridViewTextBoxColumn
            // 
            this.cOMPANYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cOMPANYDataGridViewTextBoxColumn.DataPropertyName = "COMPANY";
            this.cOMPANYDataGridViewTextBoxColumn.HeaderText = "COMPANY";
            this.cOMPANYDataGridViewTextBoxColumn.Name = "cOMPANYDataGridViewTextBoxColumn";
            this.cOMPANYDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMPANYDataGridViewTextBoxColumn.Width = 101;
            // 
            // uNITDataGridViewTextBoxColumn
            // 
            this.uNITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.uNITDataGridViewTextBoxColumn.DataPropertyName = "UNIT";
            this.uNITDataGridViewTextBoxColumn.HeaderText = "UNIT OF MEASURE";
            this.uNITDataGridViewTextBoxColumn.Name = "uNITDataGridViewTextBoxColumn";
            this.uNITDataGridViewTextBoxColumn.ReadOnly = true;
            this.uNITDataGridViewTextBoxColumn.Width = 145;
            // 
            // qTYDataGridViewTextBoxColumn
            // 
            this.qTYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qTYDataGridViewTextBoxColumn.DataPropertyName = "QTY";
            this.qTYDataGridViewTextBoxColumn.HeaderText = "QUANTITY";
            this.qTYDataGridViewTextBoxColumn.Name = "qTYDataGridViewTextBoxColumn";
            this.qTYDataGridViewTextBoxColumn.ReadOnly = true;
            this.qTYDataGridViewTextBoxColumn.Width = 103;
            // 
            // uPRICEDataGridViewTextBoxColumn
            // 
            this.uPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.uPRICEDataGridViewTextBoxColumn.DataPropertyName = "UPRICE";
            this.uPRICEDataGridViewTextBoxColumn.HeaderText = "UNIT PRICE";
            this.uPRICEDataGridViewTextBoxColumn.Name = "uPRICEDataGridViewTextBoxColumn";
            this.uPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTPRICEDataGridViewTextBoxColumn
            // 
            this.tOTPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tOTPRICEDataGridViewTextBoxColumn.DataPropertyName = "TOTPRICE";
            this.tOTPRICEDataGridViewTextBoxColumn.HeaderText = "TOTAL PRICE";
            this.tOTPRICEDataGridViewTextBoxColumn.Name = "tOTPRICEDataGridViewTextBoxColumn";
            this.tOTPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTPRICEDataGridViewTextBoxColumn.Width = 113;
            // 
            // cURRSTOCKDataGridViewTextBoxColumn
            // 
            this.cURRSTOCKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cURRSTOCKDataGridViewTextBoxColumn.DataPropertyName = "CURRSTOCK";
            this.cURRSTOCKDataGridViewTextBoxColumn.HeaderText = "CURRENT STOCK";
            this.cURRSTOCKDataGridViewTextBoxColumn.Name = "cURRSTOCKDataGridViewTextBoxColumn";
            this.cURRSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            this.cURRSTOCKDataGridViewTextBoxColumn.Width = 138;
            // 
            // sALETABLEBindingSource
            // 
            this.sALETABLEBindingSource.DataMember = "SALETABLE";
            this.sALETABLEBindingSource.DataSource = this.iCSDataSet14;
            // 
            // iCSDataSet14
            // 
            this.iCSDataSet14.DataSetName = "ICSDataSet14";
            this.iCSDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sALETABLETableAdapter
            // 
            this.sALETABLETableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rsales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rsales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.rsales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALETABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCSDataSet14)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ICSDataSet14 iCSDataSet14;
        private System.Windows.Forms.BindingSource sALETABLEBindingSource;
        private ICSDataSet14TableAdapters.SALETABLETableAdapter sALETABLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSCONTACTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURRSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}