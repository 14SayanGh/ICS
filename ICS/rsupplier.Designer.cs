namespace ICS
{
    partial class rsupplier
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
            this.sUPPCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iCSDataSet12 = new ICS.ICSDataSet12();
            this.sUPPTABLETableAdapter = new ICS.ICSDataSet12TableAdapters.SUPPTABLETableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPTABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCSDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sUPPCODEDataGridViewTextBoxColumn,
            this.sUPPNAMEDataGridViewTextBoxColumn,
            this.rEGDATEDataGridViewTextBoxColumn,
            this.cITYDataGridViewTextBoxColumn,
            this.cONTACTNODataGridViewTextBoxColumn,
            this.pINDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sUPPTABLEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(155, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // sUPPCODEDataGridViewTextBoxColumn
            // 
            this.sUPPCODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sUPPCODEDataGridViewTextBoxColumn.DataPropertyName = "SUPPCODE";
            this.sUPPCODEDataGridViewTextBoxColumn.HeaderText = "SUPPLIER\'S CODE";
            this.sUPPCODEDataGridViewTextBoxColumn.Name = "sUPPCODEDataGridViewTextBoxColumn";
            this.sUPPCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUPPCODEDataGridViewTextBoxColumn.Width = 141;
            // 
            // sUPPNAMEDataGridViewTextBoxColumn
            // 
            this.sUPPNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sUPPNAMEDataGridViewTextBoxColumn.DataPropertyName = "SUPPNAME";
            this.sUPPNAMEDataGridViewTextBoxColumn.HeaderText = "SUPPLIER\'S NAME";
            this.sUPPNAMEDataGridViewTextBoxColumn.Name = "sUPPNAMEDataGridViewTextBoxColumn";
            this.sUPPNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUPPNAMEDataGridViewTextBoxColumn.Width = 141;
            // 
            // rEGDATEDataGridViewTextBoxColumn
            // 
            this.rEGDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.rEGDATEDataGridViewTextBoxColumn.DataPropertyName = "REGDATE";
            this.rEGDATEDataGridViewTextBoxColumn.HeaderText = "DATE OF REGISTRATION";
            this.rEGDATEDataGridViewTextBoxColumn.Name = "rEGDATEDataGridViewTextBoxColumn";
            this.rEGDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEGDATEDataGridViewTextBoxColumn.Width = 182;
            // 
            // cITYDataGridViewTextBoxColumn
            // 
            this.cITYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cITYDataGridViewTextBoxColumn.DataPropertyName = "CITY";
            this.cITYDataGridViewTextBoxColumn.HeaderText = "CITY";
            this.cITYDataGridViewTextBoxColumn.Name = "cITYDataGridViewTextBoxColumn";
            this.cITYDataGridViewTextBoxColumn.ReadOnly = true;
            this.cITYDataGridViewTextBoxColumn.Width = 63;
            // 
            // cONTACTNODataGridViewTextBoxColumn
            // 
            this.cONTACTNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cONTACTNODataGridViewTextBoxColumn.DataPropertyName = "CONTACTNO";
            this.cONTACTNODataGridViewTextBoxColumn.HeaderText = "CONTACT NUMBER";
            this.cONTACTNODataGridViewTextBoxColumn.Name = "cONTACTNODataGridViewTextBoxColumn";
            this.cONTACTNODataGridViewTextBoxColumn.ReadOnly = true;
            this.cONTACTNODataGridViewTextBoxColumn.Width = 148;
            // 
            // pINDataGridViewTextBoxColumn
            // 
            this.pINDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pINDataGridViewTextBoxColumn.DataPropertyName = "PIN";
            this.pINDataGridViewTextBoxColumn.HeaderText = "PINCODE";
            this.pINDataGridViewTextBoxColumn.Name = "pINDataGridViewTextBoxColumn";
            this.pINDataGridViewTextBoxColumn.ReadOnly = true;
            this.pINDataGridViewTextBoxColumn.Width = 94;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDDRESSDataGridViewTextBoxColumn.Width = 99;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMAILDataGridViewTextBoxColumn.Width = 73;
            // 
            // sUPPTABLEBindingSource
            // 
            this.sUPPTABLEBindingSource.DataMember = "SUPPTABLE";
            this.sUPPTABLEBindingSource.DataSource = this.iCSDataSet12;
            // 
            // iCSDataSet12
            // 
            this.iCSDataSet12.DataSetName = "ICSDataSet12";
            this.iCSDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUPPTABLETableAdapter
            // 
            this.sUPPTABLETableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rsupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rsupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Report";
            this.Load += new System.EventHandler(this.rsupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPTABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCSDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ICSDataSet12 iCSDataSet12;
        private System.Windows.Forms.BindingSource sUPPTABLEBindingSource;
        private ICSDataSet12TableAdapters.SUPPTABLETableAdapter sUPPTABLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}