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
    public partial class FormAddPropertiesInElement : Form
    {
        private DBManager db;
        public FormAddPropertiesInElement(DBManager db)
        {
            InitializeComponent();
            this.db = db;
            FillCatCombo();
            FillPropCombo();
        }

        private void FillCatCombo()                                   // Populate cities combobox
        {
            List<String> values = db.ListForCombo("tblElements", "*");
            if (values == null)
            {
                MessageBox.Show("Fill combobox failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (String val in values) groupColor.Items.Add(val);
        }
        private void FillPropCombo()                                   // Populate cities combobox
        {
            List<String> values = db.ListForCombo("tblProperties", "*");
            if (values == null)
            {
                MessageBox.Show("Fill combobox failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (String val in values) groupName.Items.Add(val);
        }


        private void buttonAdd_Click(object sender, EventArgs e)                   // Add user to table
        {
            String cols = "PropertyName, PropertyElement";
            Object[] vals = { groupName.Text, groupColor.Text };
            if (!db.Insert("tblPropertiesInElement", cols, vals))
            {
                MessageBox.Show("Insert failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Inserted successfully");
            RefreshDataGridView();
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPropertiesInElements.tblProperties' table. You can move, or remove it, as needed.
            this.tblPropertiesInElementTableAdapter.Fill(this.dataSetPropertiesInElement.tblPropertiesInElement);
        }

        private void RefreshDataGridView()
        {
            DataTable tbl = db.GetDataTable("tblPropertiesInElement");
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
