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
    public partial class FormAddCategories : Form
    {
        private DBManager db;
        public FormAddCategories(DBManager db)
        {
            InitializeComponent();
            this.db = db;
        }


        private void buttonAdd_Click(object sender, EventArgs e)                   // Add user to table
        {
            String cols = "categoryName";
            Object[] vals = { userFirstName.Text };
            if (!db.Insert("tblCategories", cols, vals))
            {
                MessageBox.Show("Insert failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Inserted successfully");
            RefreshDataGridView();
        }

        private void FormAddCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCategories.tblCategories' table. You can move, or remove it, as needed.
            this.tblCategoriesTableAdapter.Fill(this.dataSetCategories.tblCategories);
        }

        private void RefreshDataGridView()
        {
            DataTable tbl = db.GetDataTable("tblCategories");
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
