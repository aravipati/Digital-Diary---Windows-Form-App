namespace DIGITAL_DIARY
{
    partial class VIEW_ALL_REMINDERS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIEW_ALL_REMINDERS));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIGITALDIARYDataSet3 = new DIGITAL_DIARY.DIGITALDIARYDataSet3();
            this.sETRTableAdapter = new DIGITAL_DIARY.DIGITALDIARYDataSet3TableAdapters.SETRTableAdapter();
            this.dIGITAL_DIARYDataSet1 = new DIGITAL_DIARY.DIGITAL_DIARYDataSet1();
            this.sETRBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sETRTableAdapter1 = new DIGITAL_DIARY.DIGITAL_DIARYDataSet1TableAdapters.SETRTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITALDIARYDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITAL_DIARYDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETRBindingSource1)).BeginInit();
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
            this.dATEDataGridViewTextBoxColumn,
            this.tIMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sETRBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(389, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 291);
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
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            this.dATEDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            // 
            // tIMEDataGridViewTextBoxColumn
            // 
            this.tIMEDataGridViewTextBoxColumn.DataPropertyName = "TIME";
            this.tIMEDataGridViewTextBoxColumn.HeaderText = "TIME";
            this.tIMEDataGridViewTextBoxColumn.Name = "tIMEDataGridViewTextBoxColumn";
            // 
            // sETRBindingSource
            // 
            this.sETRBindingSource.DataMember = "SETR";
            this.sETRBindingSource.DataSource = this.dIGITALDIARYDataSet3;
            // 
            // dIGITALDIARYDataSet3
            // 
            this.dIGITALDIARYDataSet3.DataSetName = "DIGITALDIARYDataSet3";
            this.dIGITALDIARYDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sETRTableAdapter
            // 
            this.sETRTableAdapter.ClearBeforeFill = true;
            // 
            // dIGITAL_DIARYDataSet1
            // 
            this.dIGITAL_DIARYDataSet1.DataSetName = "DIGITAL_DIARYDataSet1";
            this.dIGITAL_DIARYDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sETRBindingSource1
            // 
            this.sETRBindingSource1.DataMember = "SETR";
            this.sETRBindingSource1.DataSource = this.dIGITAL_DIARYDataSet1;
            // 
            // sETRTableAdapter1
            // 
            this.sETRTableAdapter1.ClearBeforeFill = true;
            // 
            // VIEW_ALL_REMINDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1285, 780);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VIEW_ALL_REMINDERS";
            this.Text = "VIEW_ALL_REMINDERS";
            this.Load += new System.EventHandler(this.VIEW_ALL_REMINDERS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITALDIARYDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITAL_DIARYDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETRBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DIGITALDIARYDataSet3 dIGITALDIARYDataSet3;
        private System.Windows.Forms.BindingSource sETRBindingSource;
        private DIGITAL_DIARY.DIGITALDIARYDataSet3TableAdapters.SETRTableAdapter sETRTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEDataGridViewTextBoxColumn;
        private DIGITAL_DIARYDataSet1 dIGITAL_DIARYDataSet1;
        private System.Windows.Forms.BindingSource sETRBindingSource1;
        private DIGITAL_DIARY.DIGITAL_DIARYDataSet1TableAdapters.SETRTableAdapter sETRTableAdapter1;
    }
}