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
    public partial class FormAddCities : Form
    {
        private DBManager db;
        public FormAddCities(DBManager db)
        {
            InitializeComponent();
            this.db = db;
        }


        private void buttonAdd_Click(object sender, EventArgs e)                   // Add user to table
        {
            String cols = "cityName";
            Object[] vals = { userFirstName.Text };
            if (!db.Insert("tblCities", cols, vals))
            {
                MessageBox.Show("Insert failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Inserted successfully");
            RefreshDataGridView();
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCities.tblCities' table. You can move, or remove it, as needed.
            this.tblCitiesTableAdapter.Fill(this.dataSetCities.tblCities);
            // TODO: This line of code loads data into the 'dataSetCities.tblCities' table. You can move, or remove it, as needed.
            this.tblCitiesTableAdapter.Fill(this.dataSetCities.tblCities);
            // TODO: This line of code loads data into the 'dataSetCities.tblCities' table. You can move, or remove it, as needed.
            this.tblCitiesTableAdapter.Fill(this.dataSetCities.tblCities);
        }

        private void RefreshDataGridView()  
        {
            DataTable tbl = db.GetDataTable("tblCities");
            if (tbl == null)
            {
                MessageBox.Show("Refresh dataGridView failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridView1.DataSource = tbl;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
