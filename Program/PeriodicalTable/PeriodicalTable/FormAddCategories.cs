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
    public partial class FormAddCategories : Form
    {
        private OleDbConnection dataConnection;
        public FormAddCategories(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }


        private void buttonAdd_Click(object sender, EventArgs e)                   // Add user to table
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                // dataGridView1.RowCount
                string str = string.Format
                                    ("INSERT INTO tblCategories " +
                                     "(categoryName) " +
                                     " VALUES ( \"{0}\")",
                                       userFirstName.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblCategories ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblCategories failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCategories.tblCategories' table. You can move, or remove it, as needed.
            this.tblCategoriesTableAdapter.Fill(this.dataSetCategories.tblCategories);
            this.tblCategoriesTableAdapter.Fill(this.dataSetCategories.tblCategories);
        }

        private void RefreshDataGridView()  
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblCategories ";
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
