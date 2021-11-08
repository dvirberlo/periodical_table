namespace PeriodicalTable
{
    partial class FormTblGroups
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
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGroups = new PeriodicalTable.DataSetGroups();
            this.tblGroupsTableAdapter = new PeriodicalTable.DataSetGroupsTableAdapters.tblGroupsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNameDataGridViewTextBoxColumn,
            this.groupColorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblGroupsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1458, 611);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "groupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "שם";
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            // 
            // groupColorDataGridViewTextBoxColumn
            // 
            this.groupColorDataGridViewTextBoxColumn.DataPropertyName = "groupColor";
            this.groupColorDataGridViewTextBoxColumn.HeaderText = "צבע";
            this.groupColorDataGridViewTextBoxColumn.Name = "groupColorDataGridViewTextBoxColumn";
            // 
            // tblGroupsBindingSource
            // 
            this.tblGroupsBindingSource.DataMember = "tblGroups";
            this.tblGroupsBindingSource.DataSource = this.dataSetGroups;
            // 
            // dataSetGroups
            // 
            this.dataSetGroups.DataSetName = "DataSetGroups";
            this.dataSetGroups.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblGroupsTableAdapter
            // 
            this.tblGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 716);
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
            this.label1.Location = new System.Drawing.Point(658, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "טבלת קבוצות";
            // 
            // FormTblGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblGroups";
            this.Text = "FormTblGroups";
            this.Load += new System.EventHandler(this.FormTblGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetGroups dataSetGroups;
        private System.Windows.Forms.BindingSource tblGroupsBindingSource;
        private DataSetGroupsTableAdapters.tblGroupsTableAdapter tblGroupsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}