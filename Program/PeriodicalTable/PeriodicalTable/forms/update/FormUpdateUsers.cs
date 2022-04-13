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

namespace PeriodicalTable
{
    public partial class FormUpdateUsers : Form
    {
        private DBManager db;
        private int lastRow = 0;
        public FormUpdateUsers(DBManager db)
        {
            InitializeComponent();
            this.db = db;
            FillCityCombo();
            RefreshDataGridView();
        }

        private void FormUpdateStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);
        }

        private void FillCityCombo()                                   // Populate cities combobox
        {
            List<String> values = db.ListForCombo("tblCities", "*");
            if (values == null)
            {
                MessageBox.Show("Fill combobox failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (String val in values) comboCity.Items.Add(val);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)          //Update students table
        {
            String cols = "userID, userFirstName, userLastName, userBirthDate, userAddress, userCity, userPhone, userMail, userPassword, userIsManager, userPicture";
            Object[] vals = { int.Parse(userID.Text), firstName.Text, lastName.Text, userBirthDate.Value, address.Text, comboCity.Text, phone.Text, mail.Text, userPass.Text, isManager.Checked, pictureLocation.Text };
            if (!db.Update("tblUsers", cols, vals))
            {
                MessageBox.Show("Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RefreshDataGridView();
            dataGridView1.CurrentCell = dataGridView1[0, lastRow];
            MessageBox.Show("Updated successfluly");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }

        private void EnableButtons()
        {
            buttonUpdate.Enabled = true;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            if (lastRow == 0)
                buttonPrev.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 1)
                buttonNext.Enabled = false;
        }

        private void FillSelectedRow()
        {
            try
            {
                userID.Text          = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                firstName.Text       = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lastName.Text        = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                userBirthDate.Text   = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                address.Text         = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboCity.Text       = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                phone.Text           = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                mail.Text            = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                userPass.Text        = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                isManager.Checked    = dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "True";
                pictureLocation.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                pictureBox1.ImageLocation = pictureLocation.Text;
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();

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
