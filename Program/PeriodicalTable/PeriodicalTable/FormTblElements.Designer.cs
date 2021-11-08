namespace PeriodicalTable
{
    partial class FormTblElements
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
            this.elemSymbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemEnNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemHeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemRowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemColumnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemAtomicWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemEnergyLevelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elemPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblElementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetElements = new PeriodicalTable.DataSetElements();
            this.tblElementsTableAdapter = new PeriodicalTable.DataSetElementsTableAdapters.tblElementsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblElementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetElements)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.elemSymbolDataGridViewTextBoxColumn,
            this.elemIDDataGridViewTextBoxColumn,
            this.elemFullNameDataGridViewTextBoxColumn,
            this.elemEnNameDataGridViewTextBoxColumn,
            this.elemHeNameDataGridViewTextBoxColumn,
            this.elemRowDataGridViewTextBoxColumn,
            this.elemColumnDataGridViewTextBoxColumn,
            this.elemGroupDataGridViewTextBoxColumn,
            this.elemAtomicWeightDataGridViewTextBoxColumn,
            this.elemEnergyLevelsDataGridViewTextBoxColumn,
            this.elemPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblElementsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1458, 610);
            this.dataGridView1.TabIndex = 0;
            // 
            // elemSymbolDataGridViewTextBoxColumn
            // 
            this.elemSymbolDataGridViewTextBoxColumn.DataPropertyName = "elemSymbol";
            this.elemSymbolDataGridViewTextBoxColumn.HeaderText = "סמל";
            this.elemSymbolDataGridViewTextBoxColumn.Name = "elemSymbolDataGridViewTextBoxColumn";
            // 
            // elemIDDataGridViewTextBoxColumn
            // 
            this.elemIDDataGridViewTextBoxColumn.DataPropertyName = "elemID";
            this.elemIDDataGridViewTextBoxColumn.HeaderText = "מספר זהות";
            this.elemIDDataGridViewTextBoxColumn.Name = "elemIDDataGridViewTextBoxColumn";
            // 
            // elemFullNameDataGridViewTextBoxColumn
            // 
            this.elemFullNameDataGridViewTextBoxColumn.DataPropertyName = "elemFullName";
            this.elemFullNameDataGridViewTextBoxColumn.HeaderText = "שם מלא";
            this.elemFullNameDataGridViewTextBoxColumn.Name = "elemFullNameDataGridViewTextBoxColumn";
            // 
            // elemEnNameDataGridViewTextBoxColumn
            // 
            this.elemEnNameDataGridViewTextBoxColumn.DataPropertyName = "elemEnName";
            this.elemEnNameDataGridViewTextBoxColumn.HeaderText = "שם אנגלי";
            this.elemEnNameDataGridViewTextBoxColumn.Name = "elemEnNameDataGridViewTextBoxColumn";
            // 
            // elemHeNameDataGridViewTextBoxColumn
            // 
            this.elemHeNameDataGridViewTextBoxColumn.DataPropertyName = "elemHeName";
            this.elemHeNameDataGridViewTextBoxColumn.HeaderText = "שם עברי";
            this.elemHeNameDataGridViewTextBoxColumn.Name = "elemHeNameDataGridViewTextBoxColumn";
            // 
            // elemRowDataGridViewTextBoxColumn
            // 
            this.elemRowDataGridViewTextBoxColumn.DataPropertyName = "elemRow";
            this.elemRowDataGridViewTextBoxColumn.HeaderText = "שורה";
            this.elemRowDataGridViewTextBoxColumn.Name = "elemRowDataGridViewTextBoxColumn";
            // 
            // elemColumnDataGridViewTextBoxColumn
            // 
            this.elemColumnDataGridViewTextBoxColumn.DataPropertyName = "elemColumn";
            this.elemColumnDataGridViewTextBoxColumn.HeaderText = "טור";
            this.elemColumnDataGridViewTextBoxColumn.Name = "elemColumnDataGridViewTextBoxColumn";
            // 
            // elemGroupDataGridViewTextBoxColumn
            // 
            this.elemGroupDataGridViewTextBoxColumn.DataPropertyName = "elemGroup";
            this.elemGroupDataGridViewTextBoxColumn.HeaderText = "קבוצה";
            this.elemGroupDataGridViewTextBoxColumn.Name = "elemGroupDataGridViewTextBoxColumn";
            // 
            // elemAtomicWeightDataGridViewTextBoxColumn
            // 
            this.elemAtomicWeightDataGridViewTextBoxColumn.DataPropertyName = "elemAtomicWeight";
            this.elemAtomicWeightDataGridViewTextBoxColumn.HeaderText = "משקל אטומי";
            this.elemAtomicWeightDataGridViewTextBoxColumn.Name = "elemAtomicWeightDataGridViewTextBoxColumn";
            // 
            // elemEnergyLevelsDataGridViewTextBoxColumn
            // 
            this.elemEnergyLevelsDataGridViewTextBoxColumn.DataPropertyName = "elemEnergyLevels";
            this.elemEnergyLevelsDataGridViewTextBoxColumn.HeaderText = "רמות אנרגיה";
            this.elemEnergyLevelsDataGridViewTextBoxColumn.Name = "elemEnergyLevelsDataGridViewTextBoxColumn";
            // 
            // elemPictureDataGridViewTextBoxColumn
            // 
            this.elemPictureDataGridViewTextBoxColumn.DataPropertyName = "elemPicture";
            this.elemPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.elemPictureDataGridViewTextBoxColumn.Name = "elemPictureDataGridViewTextBoxColumn";
            // 
            // tblElementsBindingSource
            // 
            this.tblElementsBindingSource.DataMember = "tblElements";
            this.tblElementsBindingSource.DataSource = this.dataSetElements;
            // 
            // dataSetElements
            // 
            this.dataSetElements.DataSetName = "DataSetElements";
            this.dataSetElements.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblElementsTableAdapter
            // 
            this.tblElementsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 705);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "שמירה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(647, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "טבלת יסודות";
            // 
            // FormTblElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblElements";
            this.Text = "FormTblElements";
            this.Load += new System.EventHandler(this.FormTblElements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblElementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetElements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetElements dataSetElements;
        private System.Windows.Forms.BindingSource tblElementsBindingSource;
        private DataSetElementsTableAdapters.tblElementsTableAdapter tblElementsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemSymbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemEnNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemHeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemRowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemColumnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemAtomicWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemEnergyLevelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elemPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}