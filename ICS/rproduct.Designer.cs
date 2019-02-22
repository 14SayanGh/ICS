namespace ICS
{
    partial class rproduct
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
            this.iCSDataSet10 = new ICS.ICSDataSet10();
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new ICS.ICSDataSet10TableAdapters.PRODUCTTableAdapter();
            this.sTOCKTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iCSDataSet11 = new ICS.ICSDataSet11();
            this.sTOCKTABLETableAdapter = new ICS.ICSDataSet11TableAdapters.STOCKTABLETableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRODIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iCSDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKTABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCSDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iCSDataSet10
            // 
            this.iCSDataSet10.DataSetName = "ICSDataSet10";
            this.iCSDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.iCSDataSet10;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // sTOCKTABLEBindingSource
            // 
            this.sTOCKTABLEBindingSource.DataMember = "STOCKTABLE";
            this.sTOCKTABLEBindingSource.DataSource = this.iCSDataSet11;
            // 
            // iCSDataSet11
            // 
            this.iCSDataSet11.DataSetName = "ICSDataSet11";
            this.iCSDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOCKTABLETableAdapter
            // 
            this.sTOCKTABLETableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRODIDDataGridViewTextBoxColumn,
            this.pRODNAMEDataGridViewTextBoxColumn,
            this.sCODEDataGridViewTextBoxColumn,
            this.sNAMEDataGridViewTextBoxColumn,
            this.uNITDataGridViewTextBoxColumn,
            this.cSTOCKDataGridViewTextBoxColumn,
            this.cOMPANYDataGridViewTextBoxColumn,
            this.mFDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTOCKTABLEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(1206, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // pRODIDDataGridViewTextBoxColumn
            // 
            this.pRODIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pRODIDDataGridViewTextBoxColumn.DataPropertyName = "PRODID";
            this.pRODIDDataGridViewTextBoxColumn.HeaderText = "PRODUCT ID";
            this.pRODIDDataGridViewTextBoxColumn.Name = "pRODIDDataGridViewTextBoxColumn";
            this.pRODIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pRODIDDataGridViewTextBoxColumn.Width = 108;
            // 
            // pRODNAMEDataGridViewTextBoxColumn
            // 
            this.pRODNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pRODNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODNAME";
            this.pRODNAMEDataGridViewTextBoxColumn.HeaderText = "PRODUCT NAME";
            this.pRODNAMEDataGridViewTextBoxColumn.Name = "pRODNAMEDataGridViewTextBoxColumn";
            this.pRODNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODNAMEDataGridViewTextBoxColumn.Width = 132;
            // 
            // sCODEDataGridViewTextBoxColumn
            // 
            this.sCODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sCODEDataGridViewTextBoxColumn.DataPropertyName = "SCODE";
            this.sCODEDataGridViewTextBoxColumn.HeaderText = "SUPPLIER\'S CODE";
            this.sCODEDataGridViewTextBoxColumn.Name = "sCODEDataGridViewTextBoxColumn";
            this.sCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sCODEDataGridViewTextBoxColumn.Width = 141;
            // 
            // sNAMEDataGridViewTextBoxColumn
            // 
            this.sNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sNAMEDataGridViewTextBoxColumn.DataPropertyName = "SNAME";
            this.sNAMEDataGridViewTextBoxColumn.HeaderText = "SUPPLIER\'S NAME";
            this.sNAMEDataGridViewTextBoxColumn.Name = "sNAMEDataGridViewTextBoxColumn";
            this.sNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNAMEDataGridViewTextBoxColumn.Width = 141;
            // 
            // uNITDataGridViewTextBoxColumn
            // 
            this.uNITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uNITDataGridViewTextBoxColumn.DataPropertyName = "UNIT";
            this.uNITDataGridViewTextBoxColumn.HeaderText = "UNIT OF MEASURE";
            this.uNITDataGridViewTextBoxColumn.Name = "uNITDataGridViewTextBoxColumn";
            this.uNITDataGridViewTextBoxColumn.ReadOnly = true;
            this.uNITDataGridViewTextBoxColumn.Width = 145;
            // 
            // cSTOCKDataGridViewTextBoxColumn
            // 
            this.cSTOCKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cSTOCKDataGridViewTextBoxColumn.DataPropertyName = "CSTOCK";
            this.cSTOCKDataGridViewTextBoxColumn.HeaderText = "CURRENT STOCK";
            this.cSTOCKDataGridViewTextBoxColumn.Name = "cSTOCKDataGridViewTextBoxColumn";
            this.cSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            this.cSTOCKDataGridViewTextBoxColumn.Width = 138;
            // 
            // cOMPANYDataGridViewTextBoxColumn
            // 
            this.cOMPANYDataGridViewTextBoxColumn.DataPropertyName = "COMPANY";
            this.cOMPANYDataGridViewTextBoxColumn.HeaderText = "COMPANY";
            this.cOMPANYDataGridViewTextBoxColumn.Name = "cOMPANYDataGridViewTextBoxColumn";
            this.cOMPANYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mFDATEDataGridViewTextBoxColumn
            // 
            this.mFDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mFDATEDataGridViewTextBoxColumn.DataPropertyName = "MFDATE";
            this.mFDATEDataGridViewTextBoxColumn.HeaderText = "DATE OF MANUFACTURE";
            this.mFDATEDataGridViewTextBoxColumn.Name = "mFDATEDataGridViewTextBoxColumn";
            this.mFDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mFDATEDataGridViewTextBoxColumn.Width = 183;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rproduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Report";
            this.Load += new System.EventHandler(this.rproduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iCSDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKTABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCSDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ICSDataSet10 iCSDataSet10;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private ICSDataSet10TableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private ICSDataSet11 iCSDataSet11;
        private System.Windows.Forms.BindingSource sTOCKTABLEBindingSource;
        private ICSDataSet11TableAdapters.STOCKTABLETableAdapter sTOCKTABLETableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}