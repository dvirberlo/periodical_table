namespace PeriodicalTable
{
    partial class FormAddCategories
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userFirstName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCategories = new PeriodicalTable.DataSetCategories();
            this.tblCategoriesTableAdapter = new PeriodicalTable.DataSetCategoriesTableAdapters.tblCategoriesTableAdapter();
            this.lbl01 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(599, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת קטגוריות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(780, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "שם";
            // 
            // userFirstName
            // 
            this.userFirstName.Location = new System.Drawing.Point(605, 89);
            this.userFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userFirstName.Size = new System.Drawing.Size(132, 22);
            this.userFirstName.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAdd.Location = new System.Drawing.Point(643, 151);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 42);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCategoriesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1458, 431);
            this.dataGridView1.TabIndex = 26;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "categoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "שם";
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
            // tblCategoriesTableAdapter
            // 
            this.tblCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl01.Location = new System.Drawing.Point(654, 269);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(72, 20);
            this.lbl01.TabIndex = 27;
            this.lbl01.Text = "קטגוריות";
            // 
            // FormAddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.userFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddCategories";
            this.Text = "FormAddCategories";
            this.Load += new System.EventHandler(this.FormAddCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userFirstName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetCategories dataSetCategories;
        private System.Windows.Forms.BindingSource tblCategoriesBindingSource;
        private DataSetCategoriesTableAdapters.tblCategoriesTableAdapter tblCategoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl01;
    }
}

