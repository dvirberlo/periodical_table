namespace PeriodicalTable
{
    partial class FormTblCategories
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
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCategories = new PeriodicalTable.DataSetCategories();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblCategoriesTableAdapter = new PeriodicalTable.DataSetCategoriesTableAdapters.tblCategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCategoriesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1458, 598);
            this.dataGridView1.TabIndex = 0;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "categoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "קטגוריה";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // tblCategoriesBindingSource
            // 
            this.tblCategoriesBindingSource.DataMember = "tblCategories";
            this.tblCategoriesBindingSource.DataSource = this.dataSetCategories;
            // 
            // dataSetCategories
            // 
            this.dataSetCategories.DataSetName = "DataSetCategories";
            this.dataSetCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 703);
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
            this.label1.Location = new System.Drawing.Point(601, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "טבלת קטגוריות";
            // 
            // tblCategoriesTableAdapter
            // 
            this.tblCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // FormTblCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblCategories";
            this.Text = "FormTblCategories";
            this.Load += new System.EventHandler(this.FormTblCategories_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private DataSetCategories dataSetCategories;
        private System.Windows.Forms.BindingSource tblCategoriesBindingSource;
        private DataSetCategoriesTableAdapters.tblCategoriesTableAdapter tblCategoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
    }
}