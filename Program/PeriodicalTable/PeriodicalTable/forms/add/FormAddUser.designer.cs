namespace PeriodicalTable
{
    partial class FormAddUser
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
            this.isUserManager = new System.Windows.Forms.CheckBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureLocation = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIsManagerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUsers = new PeriodicalTable.DataSetUsers();
            this.tblUsersTableAdapter = new PeriodicalTable.DataSetUsersTableAdapters.tblUsersTableAdapter();
            this.userBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(743, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת משתמש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1047, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "מספר ת\"ז";
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(905, 51);
            this.userId.Margin = new System.Windows.Forms.Padding(4);
            this.userId.Name = "userId";
            this.userId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userId.Size = new System.Drawing.Size(132, 22);
            this.userId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(800, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "שם פרטי";
            // 
            // userFirstName
            // 
            this.userFirstName.Location = new System.Drawing.Point(659, 51);
            this.userFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userFirstName.Size = new System.Drawing.Size(132, 22);
            this.userFirstName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "שם משפחה";
            // 
            // userLastName
            // 
            this.userLastName.Location = new System.Drawing.Point(388, 51);
            this.userLastName.Margin = new System.Windows.Forms.Padding(4);
            this.userLastName.Name = "userLastName";
            this.userLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userLastName.Size = new System.Drawing.Size(132, 22);
            this.userLastName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1044, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "תאריך לידה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(809, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "כתובת";
            // 
            // userAddress
            // 
            this.userAddress.Location = new System.Drawing.Point(608, 103);
            this.userAddress.Margin = new System.Windows.Forms.Padding(4);
            this.userAddress.Name = "userAddress";
            this.userAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userAddress.Size = new System.Drawing.Size(179, 22);
            this.userAddress.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "עיר";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAdd.Location = new System.Drawing.Point(749, 234);
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
            this.comboCity.Location = new System.Drawing.Point(396, 103);
            this.comboCity.Margin = new System.Windows.Forms.Padding(4);
            this.comboCity.Name = "comboCity";
            this.comboCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboCity.Size = new System.Drawing.Size(120, 24);
            this.comboCity.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1044, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "טלפון";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(809, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "מייל";
            // 
            // isUserManager
            // 
            this.isUserManager.AutoSize = true;
            this.isUserManager.Location = new System.Drawing.Point(463, 203);
            this.isUserManager.Name = "isUserManager";
            this.isUserManager.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isUserManager.Size = new System.Drawing.Size(94, 21);
            this.isUserManager.TabIndex = 19;
            this.isUserManager.Text = "?האם מנהל";
            this.isUserManager.UseVisualStyleBackColor = true;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(902, 163);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone.Size = new System.Drawing.Size(132, 22);
            this.phone.TabIndex = 20;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(659, 163);
            this.mail.Margin = new System.Windows.Forms.Padding(4);
            this.mail.Name = "mail";
            this.mail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mail.Size = new System.Drawing.Size(132, 22);
            this.mail.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1123, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1044, 204);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "תמונה";
            // 
            // pictureLocation
            // 
            this.pictureLocation.Location = new System.Drawing.Point(726, 204);
            this.pictureLocation.Margin = new System.Windows.Forms.Padding(4);
            this.pictureLocation.Name = "pictureLocation";
            this.pictureLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pictureLocation.Size = new System.Drawing.Size(308, 22);
            this.pictureLocation.TabIndex = 24;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(644, 204);
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
            this.userIDDataGridViewTextBoxColumn,
            this.userFirstNameDataGridViewTextBoxColumn,
            this.userLastNameDataGridViewTextBoxColumn,
            this.userBirthDateDataGridViewTextBoxColumn,
            this.userAddressDataGridViewTextBoxColumn,
            this.userCityDataGridViewTextBoxColumn,
            this.userPhoneDataGridViewTextBoxColumn,
            this.userMailDataGridViewTextBoxColumn,
            this.userPasswordDataGridViewTextBoxColumn,
            this.userIsManagerDataGridViewCheckBoxColumn,
            this.userPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUsersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1458, 431);
            this.dataGridView1.TabIndex = 26;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "מספר ת\"ז";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // userFirstNameDataGridViewTextBoxColumn
            // 
            this.userFirstNameDataGridViewTextBoxColumn.DataPropertyName = "userFirstName";
            this.userFirstNameDataGridViewTextBoxColumn.HeaderText = "שם פרטי";
            this.userFirstNameDataGridViewTextBoxColumn.Name = "userFirstNameDataGridViewTextBoxColumn";
            // 
            // userLastNameDataGridViewTextBoxColumn
            // 
            this.userLastNameDataGridViewTextBoxColumn.DataPropertyName = "userLastName";
            this.userLastNameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.userLastNameDataGridViewTextBoxColumn.Name = "userLastNameDataGridViewTextBoxColumn";
            // 
            // userBirthDateDataGridViewTextBoxColumn
            // 
            this.userBirthDateDataGridViewTextBoxColumn.DataPropertyName = "userBirthDate";
            this.userBirthDateDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.userBirthDateDataGridViewTextBoxColumn.Name = "userBirthDateDataGridViewTextBoxColumn";
            // 
            // userAddressDataGridViewTextBoxColumn
            // 
            this.userAddressDataGridViewTextBoxColumn.DataPropertyName = "userAddress";
            this.userAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.userAddressDataGridViewTextBoxColumn.Name = "userAddressDataGridViewTextBoxColumn";
            // 
            // userCityDataGridViewTextBoxColumn
            // 
            this.userCityDataGridViewTextBoxColumn.DataPropertyName = "userCity";
            this.userCityDataGridViewTextBoxColumn.HeaderText = "עיר";
            this.userCityDataGridViewTextBoxColumn.Name = "userCityDataGridViewTextBoxColumn";
            // 
            // userPhoneDataGridViewTextBoxColumn
            // 
            this.userPhoneDataGridViewTextBoxColumn.DataPropertyName = "userPhone";
            this.userPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.userPhoneDataGridViewTextBoxColumn.Name = "userPhoneDataGridViewTextBoxColumn";
            // 
            // userMailDataGridViewTextBoxColumn
            // 
            this.userMailDataGridViewTextBoxColumn.DataPropertyName = "userMail";
            this.userMailDataGridViewTextBoxColumn.HeaderText = "מייל";
            this.userMailDataGridViewTextBoxColumn.Name = "userMailDataGridViewTextBoxColumn";
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            this.userPasswordDataGridViewTextBoxColumn.DataPropertyName = "userPassword";
            this.userPasswordDataGridViewTextBoxColumn.HeaderText = "סיסמה";
            this.userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            // 
            // userIsManagerDataGridViewCheckBoxColumn
            // 
            this.userIsManagerDataGridViewCheckBoxColumn.DataPropertyName = "userIsManager";
            this.userIsManagerDataGridViewCheckBoxColumn.HeaderText = "האם מנהל";
            this.userIsManagerDataGridViewCheckBoxColumn.Name = "userIsManagerDataGridViewCheckBoxColumn";
            // 
            // userPictureDataGridViewTextBoxColumn
            // 
            this.userPictureDataGridViewTextBoxColumn.DataPropertyName = "userPicture";
            this.userPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.userPictureDataGridViewTextBoxColumn.Name = "userPictureDataGridViewTextBoxColumn";
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.dataSetUsers;
            // 
            // dataSetUsers
            // 
            this.dataSetUsers.DataSetName = "DataSetUsers";
            this.dataSetUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // userBirthDate
            // 
            this.userBirthDate.Location = new System.Drawing.Point(878, 99);
            this.userBirthDate.Name = "userBirthDate";
            this.userBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userBirthDate.Size = new System.Drawing.Size(159, 22);
            this.userBirthDate.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(535, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "סיסמה";
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(385, 154);
            this.userPassword.Margin = new System.Windows.Forms.Padding(4);
            this.userPassword.Name = "userPassword";
            this.userPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userPassword.Size = new System.Drawing.Size(143, 22);
            this.userPassword.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(762, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "משתמשים";
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.userBirthDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureLocation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.isUserManager);
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
            this.Name = "FormAddUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FormAddUser";
            this.Load += new System.EventHandler(this.FormAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).EndInit();
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
        private System.Windows.Forms.CheckBox isUserManager;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pictureLocation;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetUsers dataSetUsers;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private DataSetUsersTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.DateTimePicker userBirthDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn userIsManagerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label12;
    }
}

