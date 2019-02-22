namespace ICS
{
    partial class rcustomer
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
            this.cUSTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iCSDataSet15 = new ICS.ICSDataSet15();
            this.cUSTABLETableAdapter = new ICS.ICSDataSet15TableAdapters.CUSTABLETableAdapter();
            this.cUSCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTACTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCSDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUSCODEDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.cONTACTDataGridViewTextBoxColumn,
            this.cUSNAMEDataGridViewTextBoxColumn,
            this.rDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cUSTABLEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(289, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(856, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // cUSTABLEBindingSource
            // 
            this.cUSTABLEBindingSource.DataMember = "CUSTABLE";
            this.cUSTABLEBindingSource.DataSource = this.iCSDataSet15;
            // 
            // iCSDataSet15
            // 
            this.iCSDataSet15.DataSetName = "ICSDataSet15";
            this.iCSDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTABLETableAdapter
            // 
            this.cUSTABLETableAdapter.ClearBeforeFill = true;
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
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDDRESSDataGridViewTextBoxColumn.Width = 99;
            // 
            // cONTACTDataGridViewTextBoxColumn
            // 
            this.cONTACTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cONTACTDataGridViewTextBoxColumn.DataPropertyName = "CONTACT";
            this.cONTACTDataGridViewTextBoxColumn.HeaderText = "CONTACT";
            this.cONTACTDataGridViewTextBoxColumn.Name = "cONTACTDataGridViewTextBoxColumn";
            this.cONTACTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cONTACTDataGridViewTextBoxColumn.Width = 99;
            // 
            // cUSNAMEDataGridViewTextBoxColumn
            // 
            this.cUSNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cUSNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUSNAME";
            this.cUSNAMEDataGridViewTextBoxColumn.HeaderText = "CUSTOMER NAME";
            this.cUSNAMEDataGridViewTextBoxColumn.Name = "cUSNAMEDataGridViewTextBoxColumn";
            this.cUSNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUSNAMEDataGridViewTextBoxColumn.Width = 141;
            // 
            // rDATEDataGridViewTextBoxColumn
            // 
            this.rDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.rDATEDataGridViewTextBoxColumn.DataPropertyName = "RDATE";
            this.rDATEDataGridViewTextBoxColumn.HeaderText = "DATE OF REGISTRATION";
            this.rDATEDataGridViewTextBoxColumn.Name = "rDATEDataGridViewTextBoxColumn";
            this.rDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rDATEDataGridViewTextBoxColumn.Width = 182;
            // 
            // rcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 654);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rcustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Report";
            this.Load += new System.EventHandler(this.rcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCSDataSet15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ICSDataSet15 iCSDataSet15;
        private System.Windows.Forms.BindingSource cUSTABLEBindingSource;
        private ICSDataSet15TableAdapters.CUSTABLETableAdapter cUSTABLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTACTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDATEDataGridViewTextBoxColumn;
    }
}