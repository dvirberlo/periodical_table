﻿namespace PeriodicalTable
{
    partial class FormAddPropertiesInElement
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblPropertiesInElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPropertiesInElement = new PeriodicalTable.DataSetPropertiesInElement();
            this.label2 = new System.Windows.Forms.Label();
            this.groupColor = new System.Windows.Forms.ComboBox();
            this.groupName = new System.Windows.Forms.ComboBox();
            this.tblPropertiesInElementTableAdapter = new PeriodicalTable.DataSetPropertiesInElementTableAdapters.tblPropertiesInElementTableAdapter();
            this.propertyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyElementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPropertiesInElementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPropertiesInElement)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(371, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת תכונה ביסוד";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "שם תכונה";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAdd.Location = new System.Drawing.Point(459, 261);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 42);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(770, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propertyNameDataGridViewTextBoxColumn,
            this.propertyElementDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPropertiesInElementBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 230);
            this.dataGridView1.TabIndex = 26;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "שם יסוד";
            // 
            // groupColor
            // 
            this.groupColor.FormattingEnabled = true;
            this.groupColor.Location = new System.Drawing.Point(150, 56);
            this.groupColor.Name = "groupColor";
            this.groupColor.Size = new System.Drawing.Size(143, 24);
            this.groupColor.TabIndex = 29;
            // 
            // groupName
            // 
            this.groupName.FormattingEnabled = true;
            this.groupName.Location = new System.Drawing.Point(496, 56);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(163, 24);
            this.groupName.TabIndex = 30;
            // 
            // tblPropertiesInElementTableAdapter
            // 
            this.tblPropertiesInElementTableAdapter.ClearBeforeFill = true;
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
            // FormAddPropertiesInElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 552);
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.groupColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddPropertiesInElement";
            this.Text = "FormAddStudent";
            this.Load += new System.EventHandler(this.FormAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPropertiesInElementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPropertiesInElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox groupColor;
        private System.Windows.Forms.ComboBox groupName;
        private DataSetPropertiesInElement dataSetPropertiesInElement;
        private System.Windows.Forms.BindingSource tblPropertiesInElementBindingSource;
        private DataSetPropertiesInElementTableAdapters.tblPropertiesInElementTableAdapter tblPropertiesInElementTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyElementDataGridViewTextBoxColumn;
    }
}
