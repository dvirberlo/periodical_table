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
    public partial class FormAddProperties : Form
    {
        private OleDbConnection dataConnection;
        public FormAddProperties(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillCatCombo();
        }

        private void FillCatCombo()                                   // Populate cities combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT * " +
                                          "FROM tblCategories ";
                // BY cityName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    groupColor.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
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
                                    ("INSERT INTO tblProperties " +
                                     "(PropertyName, PropertyCategory) " +
                                     " VALUES ( \"{0}\", \"{1}\")",
                                       userFirstName.Text, groupColor.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblProperties ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblProperties failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetProperties.tblProperties' table. You can move, or remove it, as needed.
            this.tblPropertiesTableAdapter.Fill(this.dataSetProperties.tblProperties);
            // TODO: This line of code loads data into the 'dataSetProperties.tblProperties' table. You can move, or remove it, as needed.
            this.tblPropertiesTableAdapter.Fill(this.dataSetProperties.tblProperties);
            // TODO: This line of code loads data into the 'dataSetProperties.tblProperties' table. You can move, or remove it, as needed.
            this.tblPropertiesTableAdapter.Fill(this.dataSetProperties.tblProperties);
            // TODO: This line of code loads data into the 'dataSetProperties.tblProperties' table. You can move, or remove it, as needed.
            this.tblPropertiesTableAdapter.Fill(this.dataSetProperties.tblProperties);
            // TODO: This line of code loads data into the 'dataSetProperties.tblProperties' table. You can move, or remove it, as needed.
            this.tblPropertiesTableAdapter.Fill(this.dataSetProperties.tblProperties);
        }

        private void RefreshDataGridView()  
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblProperties ";
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
    }
}
