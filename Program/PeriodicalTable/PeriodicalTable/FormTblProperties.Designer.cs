namespace PeriodicalTable
{
    partial class FormTblProperties
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
            this.propertyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProperties = new PeriodicalTable.DataSetProperties();
            this.dataSetElements = new PeriodicalTable.DataSetElements();
            this.tblElementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblElementsTableAdapter = new PeriodicalTable.DataSetElementsTableAdapters.tblElementsTableAdapter();
            this.tblPropertiesTableAdapter = new PeriodicalTable.DataSetPropertiesTableAdapters.tblPropertiesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPropertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblElementsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propertyNameDataGridViewTextBoxColumn,
            this.propertyCategoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPropertiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1458, 593);
            this.dataGridView1.TabIndex = 0;
            // 
            // propertyNameDataGridViewTextBoxColumn
            // 
            this.propertyNameDataGridViewTextBoxColumn.DataPropertyName = "propertyName";
            this.propertyNameDataGridViewTextBoxColumn.HeaderText = "שם";
            this.propertyNameDataGridViewTextBoxColumn.Name = "propertyNameDataGridViewTextBoxColumn";
            // 
            // propertyCategoryDataGridViewTextBoxColumn
            // 
            this.propertyCategoryDataGridViewTextBoxColumn.DataPropertyName = "propertyCategory";
            this.propertyCategoryDataGridViewTextBoxColumn.HeaderText = "קטגוריה";
            this.propertyCategoryDataGridViewTextBoxColumn.Name = "propertyCategoryDataGridViewTextBoxColumn";
            // 
            // tblPropertiesBindingSource
            // 
            this.tblPropertiesBindingSource.DataMember = "tblProperties";
            this.tblPropertiesBindingSource.DataSource = this.dataSetProperties;
            // 
            // dataSetProperties
            // 
            this.dataSetProperties.DataSetName = "DataSetProperties";
            this.dataSetProperties.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetElements
            // 
            this.dataSetElements.DataSetName = "DataSetElements";
            this.dataSetElements.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblElementsBindingSource
            // 
            this.tblElementsBindingSource.DataMember = "tblElements";
            this.tblElementsBindingSource.DataSource = this.dataSetElements;
            // 
            // tblElementsTableAdapter
            // 
            this.tblElementsTableAdapter.ClearBeforeFill = true;
            // 
            // tblPropertiesTableAdapter
            // 
            this.tblPropertiesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 703);
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
            this.label1.Location = new System.Drawing.Point(662, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "טבלת תכונות";
            // 
            // FormTblProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblProperties";
            this.Text = "FormTblProperties";
            this.Load += new System.EventHandler(this.FormTblProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPropertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblElementsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetElements dataSetElements;
        private System.Windows.Forms.BindingSource tblElementsBindingSource;
        private DataSetElementsTableAdapters.tblElementsTableAdapter tblElementsTableAdapter;
        private DataSetProperties dataSetProperties;
        private System.Windows.Forms.BindingSource tblPropertiesBindingSource;
        private DataSetPropertiesTableAdapters.tblPropertiesTableAdapter tblPropertiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}