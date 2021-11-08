namespace PeriodicalTable
{
    partial class FormAddElements
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
            this.label2 = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboCity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureLocation = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.label11 = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.tblElementsTableAdapter = new PeriodicalTable.DataSetElementsTableAdapters.tblElementsTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.energyLevels = new System.Windows.Forms.TextBox();
            this.enName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblElementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetElements)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(596, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת יסודות";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1104, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "סימן";
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(934, 55);
            this.userId.Margin = new System.Windows.Forms.Padding(4);
            this.userId.Name = "userId";
            this.userId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userId.Size = new System.Drawing.Size(132, 22);
            this.userId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(738, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "מספר סידורי";
            // 
            // userFirstName
            // 
            this.userFirstName.Location = new System.Drawing.Point(565, 53);
            this.userFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userFirstName.Size = new System.Drawing.Size(143, 22);
            this.userFirstName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1104, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "שם מלא";
            // 
            // userLastName
            // 
            this.userLastName.Location = new System.Drawing.Point(934, 101);
            this.userLastName.Margin = new System.Windows.Forms.Padding(4);
            this.userLastName.Name = "userLastName";
            this.userLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userLastName.Size = new System.Drawing.Size(132, 22);
            this.userLastName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(738, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "שם אנגלי";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "שם עברי";
            // 
            // userAddress
            // 
            this.userAddress.Location = new System.Drawing.Point(240, 97);
            this.userAddress.Margin = new System.Windows.Forms.Padding(4);
            this.userAddress.Name = "userAddress";
            this.userAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userAddress.Size = new System.Drawing.Size(179, 22);
            this.userAddress.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1093, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "קבוצה";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAdd.Location = new System.Drawing.Point(601, 230);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 42);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboCity
            // 
            this.comboCity.FormattingEnabled = true;
            this.comboCity.Location = new System.Drawing.Point(934, 160);
            this.comboCity.Margin = new System.Windows.Forms.Padding(4);
            this.comboCity.Name = "comboCity";
            this.comboCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboCity.Size = new System.Drawing.Size(132, 24);
            this.comboCity.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "שורה";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "טור";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(341, 50);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone.Size = new System.Drawing.Size(78, 22);
            this.phone.TabIndex = 20;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(169, 48);
            this.mail.Margin = new System.Windows.Forms.Padding(4);
            this.mail.Name = "mail";
            this.mail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mail.Size = new System.Drawing.Size(61, 22);
            this.mail.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1167, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1093, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "תמונה";
            // 
            // pictureLocation
            // 
            this.pictureLocation.Location = new System.Drawing.Point(840, 212);
            this.pictureLocation.Margin = new System.Windows.Forms.Padding(4);
            this.pictureLocation.Name = "pictureLocation";
            this.pictureLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pictureLocation.Size = new System.Drawing.Size(226, 22);
            this.pictureLocation.TabIndex = 24;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(741, 212);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 25;
            this.buttonBrowse.Text = ". . .עיון";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1458, 431);
            this.dataGridView1.TabIndex = 26;
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
            this.elemEnergyLevelsDataGridViewTextBoxColumn.HeaderText = "רמות אנרגייה";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(738, 165);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "משקל אטומי";
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(565, 162);
            this.userPassword.Margin = new System.Windows.Forms.Padding(4);
            this.userPassword.Name = "userPassword";
            this.userPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userPassword.Size = new System.Drawing.Size(143, 22);
            this.userPassword.TabIndex = 29;
            // 
            // tblElementsTableAdapter
            // 
            this.tblElementsTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(456, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "רמות אנרגייה";
            // 
            // energyLevels
            // 
            this.energyLevels.Location = new System.Drawing.Point(240, 155);
            this.energyLevels.Name = "energyLevels";
            this.energyLevels.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.energyLevels.Size = new System.Drawing.Size(179, 22);
            this.energyLevels.TabIndex = 31;
            // 
            // enName
            // 
            this.enName.Location = new System.Drawing.Point(565, 102);
            this.enName.Name = "enName";
            this.enName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.enName.Size = new System.Drawing.Size(143, 22);
            this.enName.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(704, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "יסודות";
            // 
            // FormAddElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.enName);
            this.Controls.Add(this.energyLevels);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureLocation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboCity);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddElements";
            this.Text = "FormAddElements";
            this.Load += new System.EventHandler(this.FormAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblElementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetElements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pictureLocation;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userPassword;
        private DataSetElements dataSetElements;
        private System.Windows.Forms.BindingSource tblElementsBindingSource;
        private DataSetElementsTableAdapters.tblElementsTableAdapter tblElementsTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox energyLevels;
        private System.Windows.Forms.TextBox enName;
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
        private System.Windows.Forms.Label label13;
    }
}

