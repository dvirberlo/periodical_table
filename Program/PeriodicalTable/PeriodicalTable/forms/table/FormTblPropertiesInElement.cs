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
    public partial class FormTblPropertiesInElement : Form
    {
        public FormTblPropertiesInElement()
        {
            InitializeComponent();
        }

        private void FormTblPropertiesInElement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPropertiesInElement.tblPropertiesInElement' table. You can move, or remove it, as needed.
            this.tblPropertiesInElementTableAdapter.Fill(this.dataSetPropertiesInElement.tblPropertiesInElement);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetPropertiesInElement changes = (DataSetPropertiesInElement)dataSetPropertiesInElement.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblPropertiesInElement.GetChanges();
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
                int numRows = tblPropertiesInElementTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetPropertiesInElement.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetPropertiesInElement.RejectChanges();
            }
        }
    }
}
