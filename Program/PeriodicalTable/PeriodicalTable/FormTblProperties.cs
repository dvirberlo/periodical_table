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
    public partial class FormTblProperties : Form
    {
        public FormTblProperties()
        {
            InitializeComponent();
        }

        private void FormTblProperties_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetProperties.tblProperties' table. You can move, or remove it, as needed.
            this.tblPropertiesTableAdapter.Fill(this.dataSetProperties.tblProperties);
            // TODO: This line of code loads data into the 'dataSetElements.tblElements' table. You can move, or remove it, as needed.
            this.tblElementsTableAdapter.Fill(this.dataSetElements.tblElements);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetProperties changes = (DataSetProperties)dataSetProperties.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblProperties.GetChanges();
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
                int numRows = tblPropertiesTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetProperties.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetProperties.RejectChanges();
            }
        }
    }
}
