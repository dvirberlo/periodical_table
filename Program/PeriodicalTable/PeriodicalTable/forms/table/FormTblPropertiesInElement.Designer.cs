namespace PeriodicalTable
{
    partial class FormTblPropertiesInElement
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
            this.propertyElementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPropertiesInElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPropertiesInElement = new PeriodicalTable.DataSetPropertiesInElement();
            this.tblPropertiesInElementTableAdapter = new PeriodicalTable.DataSetPropertiesInElementTableAdapters.tblPropertiesInElementTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPropertiesInElementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPropertiesInElement)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propertyNameDataGridViewTextBoxColumn,
            this.propertyElementDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPropertiesInElementBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1458, 625);
            this.dataGridView1.TabIndex = 0;
            // 
            // propertyNameDataGridViewTextBoxColumn
            // 
            this.propertyNameDataGridViewTextBoxColumn.DataPropertyName = "propertyName";
            this.propertyNameDataGridViewTextBoxColumn.HeaderText = "שם";
            this.propertyNameDataGridViewTextBoxColumn.Name = "propertyNameDataGridViewTextBoxColumn";
            // 
            // propertyElementDataGridViewTextBoxColumn
            // 
            this.propertyElementDataGridViewTextBoxColumn.DataPropertyName = "propertyElement";
            this.propertyElementDataGridViewTextBoxColumn.HeaderText = "יסוד";
            this.propertyElementDataGridViewTextBoxColumn.Name = "propertyElementDataGridViewTextBoxColumn";
            // 
            // tblPropertiesInElementBindingSource
            // 
            this.tblPropertiesInElementBindingSource.DataMember = "tblPropertiesInElement";
            this.tblPropertiesInElementBindingSource.DataSource = this.dataSetPropertiesInElement;
            // 
            // dataSetPropertiesInElement
            // 
            this.dataSetPropertiesInElement.DataSetName = "DataSetPropertiesInElement";
            this.dataSetPropertiesInElement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPropertiesInElementTableAdapter
            // 
            this.tblPropertiesInElementTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 716);
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
            this.label1.Location = new System.Drawing.Point(632, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "טבלת תכונות ביסוד";
            // 
            // FormTblPropertiesInElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblPropertiesInElement";
            this.Text = "FormTblPropertiesInElement";
            this.Load += new System.EventHandler(this.FormTblPropertiesInElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPropertiesInElementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPropertiesInElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetPropertiesInElement dataSetPropertiesInElement;
        private System.Windows.Forms.BindingSource tblPropertiesInElementBindingSource;
        private DataSetPropertiesInElementTableAdapters.tblPropertiesInElementTableAdapter tblPropertiesInElementTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyElementDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}