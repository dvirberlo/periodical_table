using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeriodicalTable
{
    public partial class FormTblCategories : Form
    {
        public FormTblCategories()
        {
            InitializeComponent();
        }

        private void FormTblCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCategories.tblCategories' table. You can move, or remove it, as needed.
            this.tblCategoriesTableAdapter.Fill(this.dataSetCategories.tblCategories);
            // TODO: This line of code loads data into the 'dataSetCategories.tblCategories' table. You can move, or remove it, as needed.
            this.tblCategoriesTableAdapter.Fill(this.dataSetCategories.tblCategories);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetCategories changes = (DataSetCategories)dataSetCategories.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblCategories.GetChanges();
                DataRow[] badRows = dt.GetErrors();
                //find the errors and tell the user
                if (badRows.Length > 0)
                {
                    string errorMsg = "";
                    foreach (DataRow row in badRows)
                    {
                        foreach (DataColumn col in row.GetColumnsInError())
                        {
                            errorMsg = errorMsg + row.GetColumnsInError() + "\n";
                        }
                    }
                    MessageBox.Show("Errors in data: " + errorMsg,
                    "Please fix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //no error found, update the database
                int numRows = tblCategoriesTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetCategories.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetCategories.RejectChanges();
            }
        }

        private void FormTblCategories_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCategories.tblCategories' table. You can move, or remove it, as needed.
            this.tblCategoriesTableAdapter.Fill(this.dataSetCategories.tblCategories);

        }
    }
}
