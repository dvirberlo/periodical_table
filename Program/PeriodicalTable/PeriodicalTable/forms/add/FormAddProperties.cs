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
    public partial class FormAddProperties : Form
    {
        private DBManager db;
        public FormAddProperties(DBManager db)
        {
            InitializeComponent();
            this.db = db;
            FillCatCombo();
        }

        private void FillCatCombo()                                   // Populate cities combobox
        {
            List<String> values = db.ListForCombo("tblCategories", "*");
            if (values == null)
            {
                MessageBox.Show("Fill combobox failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (String val in values) groupColor.Items.Add(val);
        }


        private void buttonAdd_Click(object sender, EventArgs e)                   // Add user to table
        {
            String cols = "PropertyName, PropertyCategory";
            Object[] vals = { userFirstName.Text, groupColor.Text };
            if (!db.Insert("tblProperties", cols, vals))
            {
                MessageBox.Show("Insert failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Inserted successfully");
            RefreshDataGridView();
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetProperties.tblProperties' table. You can move, or remove it, as needed.
            this.tblPropertiesTableAdapter.Fill(this.dataSetProperties.tblProperties);
        }

        private void RefreshDataGridView()  
        {
            DataTable tbl = db.GetDataTable("tblProperties");
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
