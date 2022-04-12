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
    public partial class FormAddGroups : Form
    {
        private OleDbConnection dataConnection;
        public FormAddGroups(OleDbConnection dataConnection)
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
                                    ("INSERT INTO tblGroups " +
                                     "(groupName, groupColor) " +
                                     " VALUES ( \"{0}\", \"{1}\")",
                                       userFirstName.Text, groupColor.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblGroups ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblGroups failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddGroups_Load(object sender, EventArgs e)
        {
            this.tblGroupsTableAdapter.Fill(this.dataSetGroups.tblGroups);
        }

        private void RefreshDataGridView()  
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblGroups ";
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

        private void ColorPickerClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            groupColor.Text = "#"+(cd.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
        }
    }
}
