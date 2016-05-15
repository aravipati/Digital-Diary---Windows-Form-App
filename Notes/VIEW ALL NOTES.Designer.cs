namespace DIGITAL_DIARY
{
    partial class VIEW_ALL_NOTES
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
            this.nOTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIGITALDIARYDataSet5 = new DIGITAL_DIARY.DIGITALDIARYDataSet5();
            this.nOTESTableAdapter = new DIGITAL_DIARY.DIGITALDIARYDataSet5TableAdapters.NOTESTableAdapter();
            this.dIGITAL_DIARYDataSet2 = new DIGITAL_DIARY.DIGITAL_DIARYDataSet2();
            this.sETRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sETRTableAdapter = new DIGITAL_DIARY.DIGITAL_DIARYDataSet2TableAdapters.SETRTableAdapter();
            this.dIGITAL_DIARYDataSet3 = new DIGITAL_DIARY.DIGITAL_DIARYDataSet3();
            this.sETRBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sETRTableAdapter1 = new DIGITAL_DIARY.DIGITAL_DIARYDataSet3TableAdapters.SETRTableAdapter();
            this.eNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITALDIARYDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITAL_DIARYDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITAL_DIARYDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETRBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eNODataGridViewTextBoxColumn,
            this.SUBJ,
            this.DATE,
            this.TIME});
            this.dataGridView1.DataSource = this.sETRBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(89, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(851, 158);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nOTESBindingSource
            // 
            this.nOTESBindingSource.DataMember = "NOTES";
            this.nOTESBindingSource.DataSource = this.dIGITALDIARYDataSet5;
            // 
            // dIGITALDIARYDataSet5
            // 
            this.dIGITALDIARYDataSet5.DataSetName = "DIGITALDIARYDataSet5";
            this.dIGITALDIARYDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nOTESTableAdapter
            // 
            this.nOTESTableAdapter.ClearBeforeFill = true;
            // 
            // dIGITAL_DIARYDataSet2
            // 
            this.dIGITAL_DIARYDataSet2.DataSetName = "DIGITAL_DIARYDataSet2";
            this.dIGITAL_DIARYDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sETRBindingSource
            // 
            this.sETRBindingSource.DataMember = "SETR";
            this.sETRBindingSource.DataSource = this.dIGITAL_DIARYDataSet2;
            // 
            // sETRTableAdapter
            // 
            this.sETRTableAdapter.ClearBeforeFill = true;
            // 
            // dIGITAL_DIARYDataSet3
            // 
            this.dIGITAL_DIARYDataSet3.DataSetName = "DIGITAL_DIARYDataSet3";
            this.dIGITAL_DIARYDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sETRBindingSource1
            // 
            this.sETRBindingSource1.DataMember = "SETR";
            this.sETRBindingSource1.DataSource = this.dIGITAL_DIARYDataSet3;
            // 
            // sETRTableAdapter1
            // 
            this.sETRTableAdapter1.ClearBeforeFill = true;
            // 
            // eNODataGridViewTextBoxColumn
            // 
            this.eNODataGridViewTextBoxColumn.DataPropertyName = "ENO";
            this.eNODataGridViewTextBoxColumn.HeaderText = "ENO";
            this.eNODataGridViewTextBoxColumn.Name = "eNODataGridViewTextBoxColumn";
            // 
            // SUBJ
            // 
            this.SUBJ.DataPropertyName = "SUBJ";
            this.SUBJ.HeaderText = "SUBJ";
            this.SUBJ.Name = "SUBJ";
            // 
            // DATE
            // 
            this.DATE.DataPropertyName = "DATE";
            this.DATE.HeaderText = "DATE";
            this.DATE.Name = "DATE";
            // 
            // TIME
            // 
            this.TIME.DataPropertyName = "TIME";
            this.TIME.HeaderText = "TIME";
            this.TIME.Name = "TIME";
            // 
            // VIEW_ALL_NOTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 746);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VIEW_ALL_NOTES";
            this.Text = "VIEW_ALL_NOTES";
            this.Load += new System.EventHandler(this.VIEW_ALL_NOTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITALDIARYDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITAL_DIARYDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIGITAL_DIARYDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETRBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DIGITALDIARYDataSet5 dIGITALDIARYDataSet5;
        private System.Windows.Forms.BindingSource nOTESBindingSource;
        private DIGITAL_DIARY.DIGITALDIARYDataSet5TableAdapters.NOTESTableAdapter nOTESTableAdapter;
        private DIGITAL_DIARYDataSet2 dIGITAL_DIARYDataSet2;
        private System.Windows.Forms.BindingSource sETRBindingSource;
        private DIGITAL_DIARY.DIGITAL_DIARYDataSet2TableAdapters.SETRTableAdapter sETRTableAdapter;
        private DIGITAL_DIARYDataSet3 dIGITAL_DIARYDataSet3;
        private System.Windows.Forms.BindingSource sETRBindingSource1;
        private DIGITAL_DIARY.DIGITAL_DIARYDataSet3TableAdapters.SETRTableAdapter sETRTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME;
    }
}