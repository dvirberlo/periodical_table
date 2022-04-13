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
    public partial class FormUpdateGroups : Form
    {
        private DBManager db;
        private int lastRow = 0;
        public FormUpdateGroups(DBManager db)
        {
            InitializeComponent();
            this.db = db;
            RefreshDataGridView();
        }

        private void FormUpdateStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGroups.tblGroups' table. You can move, or remove it, as needed.
            this.tblGroupsTableAdapter.Fill(this.dataSetGroups.tblGroups);
        }


        

        private void buttonUpdate_Click(object sender, EventArgs e)          //Update students table
        {
            String cols = "groupName, groupColor";
            Object[] vals = { userID.Text, groupColor.Text };
            if (!db.Update("tblGroups", cols, vals))
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
            DataTable tbl = db.GetDataTable("tblGroups");
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
                userID.Text          = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                groupColor.Text       = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
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

        private void PickColorClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            groupColor.Text = "#"+(cd.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
        }


    }
}
