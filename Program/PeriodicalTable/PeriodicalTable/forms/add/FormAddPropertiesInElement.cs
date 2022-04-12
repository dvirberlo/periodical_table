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
    public partial class FormAddPropertiesInElement : Form
    {
        private OleDbConnection dataConnection;
        public FormAddPropertiesInElement(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillCatCombo();
            FillPropCombo();
        }

        private void FillCatCombo()                                   // Populate cities combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT * " +
                                          "FROM tblElements ";
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
        private void FillPropCombo()                                   // Populate cities combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT * " +
                                          "FROM tblProperties ";
                // BY cityName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    groupName.Items.Add(dataReader.GetString(0));
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
                                    ("INSERT INTO tblPropertiesInElement " +
                                     "(PropertyName, PropertyElement) " +
                                     " VALUES ( \"{0}\", \"{1}\")",
                                       groupName.Text, groupColor.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblPropertiesInElement ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblPropertiesInElement failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPropertiesInElement.tblPropertiesInElement' table. You can move, or remove it, as needed.
            this.tblPropertiesInElementTableAdapter.Fill(this.dataSetPropertiesInElement.tblPropertiesInElement);
            // TODO: This line of code loads data into the 'dataSetPropertiesInElement.tblPropertiesInElement' table. You can move, or remove it, as needed.
            this.tblPropertiesInElementTableAdapter.Fill(this.dataSetPropertiesInElement.tblPropertiesInElement);
            // TODO: This line of code loads data into the 'dataSetProperties.tblProperties' table. You can move, or remove it, as needed.
            this.tblPropertiesInElementTableAdapter.Fill(this.dataSetPropertiesInElement.tblPropertiesInElement);
            // TODO: This line of code loads data into the 'dataSetProperties.tblProperties' table. You can move, or remove it, as needed.
            this.tblPropertiesInElementTableAdapter.Fill(this.dataSetPropertiesInElement.tblPropertiesInElement);
            // TODO: This line of code loads data into the 'dataSetPropertiesInElements.tblProperties' table. You can move, or remove it, as needed.
            this.tblPropertiesInElementTableAdapter.Fill(this.dataSetPropertiesInElement.tblPropertiesInElement);
            // TODO: This line of code loads data into the 'dataSetPropertiesInElements.tblProperties' table. You can move, or remove it, as needed.
            this.tblPropertiesInElementTableAdapter.Fill(this.dataSetPropertiesInElement.tblPropertiesInElement);
            // TODO: This line of code loads data into the 'dataSetPropertiesInElements.tblProperties' table. You can move, or remove it, as needed.
            this.tblPropertiesInElementTableAdapter.Fill(this.dataSetPropertiesInElement.tblPropertiesInElement);
        }

        private void RefreshDataGridView()  
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblPropertiesInElement ";
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
