using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using PeriodicalTable.backend;
using PeriodicalTable.modules;

namespace PeriodicalTable
{
    public partial class FormAddUser : Form
    {
        private DBManager db;
        public FormAddUser(DBManager db)
        {
            InitializeComponent();
            this.db = db;
            FillCityCombo();
        }

        private void FillCityCombo()                                   // Populate cities combobox
        {
            List<String> values = db.ListForCombo("tblCities", "*");
            if(values == null)
            {
                MessageBox.Show("Fill combobox failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (String val in values) comboCity.Items.Add(val);
        }

        private void buttonAdd_Click(object sender, EventArgs e)                   // Add user to table
        {
            if(!IDValidation.IsValidID(Convertings.IntParse(userId.Text))){
                MessageBox.Show("Please enter valid ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String cols = "userID, userFirstName, userLastName, userBirthDate, userAddress, userCity, userPhone, userMail, userPassword, userIsManager, userPicture";
            Object[] vals = { Convertings.IntParse(userId.Text), userFirstName.Text, userLastName.Text, userBirthDate.Value, userAddress.Text, comboCity.Text, phone.Text, mail.Text, userPassword.Text, isUserManager.Checked, pictureLocation.Text };
            if (!db.Insert("tblUsers", cols, vals))
            {
                MessageBox.Show("Insert failed" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Inserted successfully");
            RefreshDataGridView();
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);
        }

        private void RefreshDataGridView()  
        {
            DataTable tbl = db.GetDataTable("tblUsers");
            if (tbl == null)
            {
                MessageBox.Show("Refresh dataGridView failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridView1.DataSource = tbl;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            pictureLocation.Text = pictureFileName;
        }
    }
}
