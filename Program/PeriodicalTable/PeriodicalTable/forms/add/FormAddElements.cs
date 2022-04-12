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
    public partial class FormAddElements : Form
    {
        private DBManager db;
        public FormAddElements(DBManager db)
        {
            InitializeComponent();
            this.db = db;
            FillGroupsCombo();
        }

        private void FillGroupsCombo()                                   // Populate cities combobox
        {
            List<String> values = db.ListForCombo("tblGroups", "*");
            if (values == null)
            {
                MessageBox.Show("Fill combobox failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (String val in values) comboGroup.Items.Add(val);
        }

        private void buttonAdd_Click(object sender, EventArgs e)                   // Add user to table
        {
            String cols = "elemSymbol, elemID, elemFullName, elemEnName, elemHeName, elemRow, elemColumn, elemGroup, elemAtomicWeight, elemEnergyLevels, elemPicture";
            Object[] vals = { symbol.Text, int.Parse(elemID.Text), fullName.Text, enName.Text, heName.Text, int.Parse(elemRow.Text), int.Parse(elemCol.Text), comboGroup.Text, double.Parse(elemW.Text), energyLevels.Text, pictureLocation.Text };
            if (!db.Insert("tblElements", cols, vals))
            {
                MessageBox.Show("Insert failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Inserted successfully");
            RefreshDataGridView();
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
            DataTable tbl = db.GetDataTable("tblElements");
            if (tbl == null)
            {
                MessageBox.Show("Refresh dataGridView failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridView1.DataSource = tbl;
            dataGridView1.AllowUserToAddRows = false;
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
