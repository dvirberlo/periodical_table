using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PeriodicalTable
{
    public partial class FormAddElements : Form
    {
        private OleDbConnection dataConnection;
        public FormAddElements(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillGroupsCombo();
        }

        private void FillGroupsCombo()                                   // Populate cities combobox
        {
            try                             
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT * " +
                                          "FROM tblGroups ";
                                          // BY cityName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboCity.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill groups combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)                   // Add user to table
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                // dataGridView1.RowCount
                string str = string.Format
                                    ("INSERT INTO tblElements " +
                                     "(elemSymbol, elemID, elemFullName, elemEnName, elemHeName, elemRow, elemColumn, elemGroup, elemAtomicWeight, elemEnergyLevels, elemPicture) " +
                                     " VALUES ( \"{0}\", {1}, \"{2}\", \"{3}\", \"{4}\", {5}, {6}, \"{7}\", {8}, {9}, \"{10}\")",
                                       userId.Text, userFirstName.Text, userLastName.Text, enName.Text,
                                       userAddress.Text, phone.Text, mail.Text, comboCity.Text, userPassword.Text, energyLevels.Text, pictureLocation.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                // dataSetElements
                MessageBox.Show("Insert into tblElements ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblElements failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetElements.tblElements' table. You can move, or remove it, as needed.
            this.tblElementsTableAdapter.Fill(this.dataSetElements.tblElements);
            // TODO: This line of code loads data into the 'dataSetElements.tblElements' table. You can move, or remove it, as needed.
            this.tblElementsTableAdapter.Fill(this.dataSetElements.tblElements);
            // TODO: This line of code loads data into the 'dataSetElements.tblElements' table. You can move, or remove it, as needed.
            this.tblElementsTableAdapter.Fill(this.dataSetElements.tblElements);
        }

        private void RefreshDataGridView()  
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblElements ";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh dataGridView failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
