namespace DIGITAL_DIARY
{
    partial class VIEW_ALL_DEADLINE_NOTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIEW_ALL_DEADLINE_NOTES));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMSGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMSGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETDLNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIGITALDIARYDataSet2 = new DIGITAL_DIARY.DIGITALDIARYDataSet2();
            this.sETDLNTableAdapter = new DIGITAL_DIARY.DIGITALDIARYDataSet2TableAdapters.SETDLNTableAdapter();
            this.dIGITAL_DIARYDataSet4 = new DIGITAL_DIARY.DIGITAL_DIARYDataSet4();
            this.sETDLNBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sETDLNTableAdapter1 = new DIGITAL_DIARY.DIGITAL_DIARYDataSet4TableAdapters.SETDLNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETDLNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITALDIARYDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITAL_DIARYDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETDLNBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eNODataGridViewTextBoxColumn,
            this.sUBJDataGridViewTextBoxColumn,
            this.sMSGDataGridViewTextBoxColumn,
            this.sDATEDataGridViewTextBoxColumn,
            this.eMSGDataGridViewTextBoxColumn,
            this.eDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sETDLNBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(357, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // eNODataGridViewTextBoxColumn
            // 
            this.eNODataGridViewTextBoxColumn.DataPropertyName = "ENO";
            this.eNODataGridViewTextBoxColumn.HeaderText = "ENO";
            this.eNODataGridViewTextBoxColumn.Name = "eNODataGridViewTextBoxColumn";
            // 
            // sUBJDataGridViewTextBoxColumn
            // 
            this.sUBJDataGridViewTextBoxColumn.DataPropertyName = "SUBJ";
            this.sUBJDataGridViewTextBoxColumn.HeaderText = "SUBJ";
            this.sUBJDataGridViewTextBoxColumn.Name = "sUBJDataGridViewTextBoxColumn";
            // 
            // sMSGDataGridViewTextBoxColumn
            // 
            this.sMSGDataGridViewTextBoxColumn.DataPropertyName = "SMSG";
            this.sMSGDataGridViewTextBoxColumn.HeaderText = "SMSG";
            this.sMSGDataGridViewTextBoxColumn.Name = "sMSGDataGridViewTextBoxColumn";
            // 
            // sDATEDataGridViewTextBoxColumn
            // 
            this.sDATEDataGridViewTextBoxColumn.DataPropertyName = "SDATE";
            this.sDATEDataGridViewTextBoxColumn.HeaderText = "SDATE";
            this.sDATEDataGridViewTextBoxColumn.Name = "sDATEDataGridViewTextBoxColumn";
            // 
            // eMSGDataGridViewTextBoxColumn
            // 
            this.eMSGDataGridViewTextBoxColumn.DataPropertyName = "EMSG";
            this.eMSGDataGridViewTextBoxColumn.HeaderText = "EMSG";
            this.eMSGDataGridViewTextBoxColumn.Name = "eMSGDataGridViewTextBoxColumn";
            // 
            // eDATEDataGridViewTextBoxColumn
            // 
            this.eDATEDataGridViewTextBoxColumn.DataPropertyName = "EDATE";
            this.eDATEDataGridViewTextBoxColumn.HeaderText = "EDATE";
            this.eDATEDataGridViewTextBoxColumn.Name = "eDATEDataGridViewTextBoxColumn";
            // 
            // sETDLNBindingSource
            // 
            this.sETDLNBindingSource.DataMember = "SETDLN";
            this.sETDLNBindingSource.DataSource = this.dIGITALDIARYDataSet2;
            // 
            // dIGITALDIARYDataSet2
            // 
            this.dIGITALDIARYDataSet2.DataSetName = "DIGITALDIARYDataSet2";
            this.dIGITALDIARYDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sETDLNTableAdapter
            // 
            this.sETDLNTableAdapter.ClearBeforeFill = true;
            // 
            // dIGITAL_DIARYDataSet4
            // 
            this.dIGITAL_DIARYDataSet4.DataSetName = "DIGITAL_DIARYDataSet4";
            this.dIGITAL_DIARYDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sETDLNBindingSource1
            // 
            this.sETDLNBindingSource1.DataMember = "SETDLN";
            this.sETDLNBindingSource1.DataSource = this.dIGITAL_DIARYDataSet4;
            // 
            // sETDLNTableAdapter1
            // 
            this.sETDLNTableAdapter1.ClearBeforeFill = true;
            // 
            // VIEW_ALL_DEADLINE_NOTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1285, 780);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VIEW_ALL_DEADLINE_NOTES";
            this.Text = "VIEW_ALL_DEADLINE_NOTES";
            this.Load += new System.EventHandler(this.VIEW_ALL_DEADLINE_NOTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETDLNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITALDIARYDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITAL_DIARYDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETDLNBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DIGITALDIARYDataSet2 dIGITALDIARYDataSet2;
        private System.Windows.Forms.BindingSource sETDLNBindingSource;
        private DIGITAL_DIARY.DIGITALDIARYDataSet2TableAdapters.SETDLNTableAdapter sETDLNTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMSGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMSGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDATEDataGridViewTextBoxColumn;
        private DIGITAL_DIARYDataSet4 dIGITAL_DIARYDataSet4;
        private System.Windows.Forms.BindingSource sETDLNBindingSource1;
        private DIGITAL_DIARY.DIGITAL_DIARYDataSet4TableAdapters.SETDLNTableAdapter sETDLNTableAdapter1;
    }
}