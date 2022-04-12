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
    public partial class FormAddGroups : Form
    {
        private DBManager db;
        public FormAddGroups(DBManager db)
        {
            InitializeComponent();
            this.db = db;
        }


        private void buttonAdd_Click(object sender, EventArgs e)                   // Add user to table
        {
            String cols = "groupName, groupColor";
            Object[] vals = { userFirstName.Text, groupColor.Text };
            if (!db.Insert("tblGroups", cols, vals))
            {
                MessageBox.Show("Insert failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Inserted successfully");
            RefreshDataGridView();
        }

        private void FormAddGroups_Load(object sender, EventArgs e)
        {
            this.tblGroupsTableAdapter.Fill(this.dataSetGroups.tblGroups);
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

        private void ColorPickerClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            groupColor.Text = "#"+(cd.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
        }
    }
}
