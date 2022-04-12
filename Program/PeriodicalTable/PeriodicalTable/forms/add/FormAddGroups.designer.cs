namespace PeriodicalTable
{
    partial class FormAddGroups
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
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGroups = new PeriodicalTable.DataSetGroups();
            this.tblGroupsTableAdapter = new PeriodicalTable.DataSetGroupsTableAdapters.tblGroupsTableAdapter();
            this.groupColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorPicker = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(591, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת קבוצות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(937, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "שם קבוצה";
            // 
            // userFirstName
            // 
            this.userFirstName.Location = new System.Drawing.Point(763, 73);
            this.userFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userFirstName.Size = new System.Drawing.Size(132, 22);
            this.userFirstName.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAdd.Location = new System.Drawing.Point(610, 176);
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
            this.groupNameDataGridViewTextBoxColumn,
            this.groupColorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblGroupsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1458, 431);
            this.dataGridView1.TabIndex = 26;
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
            // groupColor
            // 
            this.groupColor.Location = new System.Drawing.Point(423, 73);
            this.groupColor.Name = "groupColor";
            this.groupColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupColor.Size = new System.Drawing.Size(143, 22);
            this.groupColor.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "צבע קבוצה";
            // 
            // colorPicker
            // 
            this.colorPicker.Location = new System.Drawing.Point(342, 70);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(75, 25);
            this.colorPicker.TabIndex = 29;
            this.colorPicker.Text = "בחר צבע";
            this.colorPicker.UseVisualStyleBackColor = true;
            this.colorPicker.Click += new System.EventHandler(this.ColorPickerClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(641, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "קבוצות";
            // 
            // FormAddGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupColor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.userFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddGroups";
            this.Text = "FormAddGroups";
            this.Load += new System.EventHandler(this.FormAddGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userFirstName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetGroups dataSetGroups;
        private System.Windows.Forms.BindingSource tblGroupsBindingSource;
        private DataSetGroupsTableAdapters.tblGroupsTableAdapter tblGroupsTableAdapter;
        private System.Windows.Forms.TextBox groupColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button colorPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
    }
}

