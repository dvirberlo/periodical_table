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
    public partial class FormUpdateElements : Form
    {
        private DBManager db;
        private int lastRow = 0;
        public FormUpdateElements(DBManager db)
        {
            InitializeComponent();
            this.db = db;
            FillGroupCombo();
            RefreshDataGridView();
        }

        private void FormUpdateStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetElements.tblElements' table. You can move, or remove it, as needed.
            this.tblElementsTableAdapter.Fill(this.dataSetElements.tblElements);
            // TODO: This line of code loads data into the 'dataSetElements.tblElements' table. You can move, or remove it, as needed.
            this.tblElementsTableAdapter.Fill(this.dataSetElements.tblElements);
        }

        private void FillGroupCombo()                                   // Populate cities combobox
        {
            List<String> values = db.ListForCombo("tblGroups", "*");
            if (values == null)
            {
                MessageBox.Show("Fill combobox failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (String val in values) comboGroup.Items.Add(val);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)          //Update students table
        {
            String cols = "elemSymbol, elemID, elemFullName, elemEnName, elemHeName, elemRow, elemColumn, elemGroup, elemAtomicWeight, elemEnergyLevels, elemPicture";
            Object[] vals = { symbol.Text, int.Parse(id.Text), fullName.Text, enName.Text, heName.Text, int.Parse(row.Text), int.Parse(col.Text), comboGroup.Text, double.Parse(atomicWeight.Text), energyLevels.Text, pictureLocation.Text };
            if (!db.Update("tblElements", cols, vals))
            {
                MessageBox.Show("Insert failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Inserted successfully");
            RefreshDataGridView();
            dataGridView1.CurrentCell = dataGridView1[0, lastRow];
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }

        private void EnableButtons()
        {
            buttonUpdate.Enabled = true;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            if (lastRow == 0)
                buttonPrev.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 1)
                buttonNext.Enabled = false;
        }

        private void FillSelectedRow()
        {
            try
            {
                symbol.Text          = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                id.Text              = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                fullName.Text        = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                enName.Text          = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                heName.Text          = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                row.Text             = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                col.Text             = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                comboGroup.Text      = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                atomicWeight.Text    = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                energyLevels.Text    = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                pictureLocation.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                pictureBox1.ImageLocation = pictureLocation.Text;
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            pictureLocation.Text = pictureFileName;
        }


        private void label12_Click(object sender, EventArgs e)
        {

        }


    }
}
