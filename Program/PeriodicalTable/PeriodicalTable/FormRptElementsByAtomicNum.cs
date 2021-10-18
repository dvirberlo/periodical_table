using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeriodicalTable
{
    public partial class FormRptElementsByAtomicNum : Form
    {
        private OleDbConnection dataConnection;

        public FormRptElementsByAtomicNum(OleDbConnection dataConnection)
        {
            this.dataConnection = dataConnection;
            InitializeComponent();
            this.Shown += Setup;
        }
        private void Setup(Object sender, EventArgs e)
        {
            FillFromDB(this.fromAtomic, "");

            listView.Columns.Clear();
            listView.View = View.Details;
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //string s = "elemID,elemRow,elemColumn,elemSymbol,elemGroup,elemFullName,elemEnName,elemHeName,elemAtomicWeight,elemEnergyLevels";
            string strCols = "מספר זהות,שורה,טור,סימן,קבוצה,שם מלא,שם אנגלי,שם עברי,משקל אטומי,רמות אנרגיה";
            string[] cols = strCols.Split(',');
            foreach (string col in cols)
            {
                listView.Columns.Add(col, this.listView.Width / cols.Length, HorizontalAlignment.Center);
            }
        }

        private void FromAtoomicChanged(object sender, EventArgs e)
        {
            this.toAtomic.Enabled = true;
            this.searchBtn.Enabled = true;
            String from = this.fromAtomic.Text;
            String cmd = " WHERE elemAtomicWeight >= " + from;
            FillFromDB(this.toAtomic, cmd);
        }

        private void SearchBtnClick(object sender, EventArgs e)
        {
            String from = this.fromAtomic.Text;
            String to = this.toAtomic.Text;
            String cmd = " WHERE elemAtomicWeight >= " + from + " AND elemAtomicWeight <= " + to;
            FillFromDB(this.listView, cmd);
        }

        private void FillFromDB(ComboBox cb, String cmd)
        {
            cb.Items.Clear();
            OleDbCommand cbCommand = new OleDbCommand();
            cbCommand.Connection = dataConnection;
            cbCommand.CommandText = "SELECT elemID, elemRow, elemColumn, elemSymbol, elemGroup, elemFullName, elemEnName, elemHeName, elemAtomicWeight, elemEnergyLevels FROM tblElements \n" + cmd + "\n ORDER BY elemAtomicWeight";
            OleDbDataReader cbReader = cbCommand.ExecuteReader();
            while (cbReader.Read())
            {
                object[] elemObj = new object[10];
                int len = cbReader.GetValues(elemObj);
                double atomicWeight = Convert.ToDouble(elemObj[8]);
                cb.Items.Add(atomicWeight);
            }
            cbReader.Close();
        }
        private void FillFromDB(ListView lv, String cmd)
        {
            lv.Items.Clear();
            OleDbCommand cbCommand = new OleDbCommand();
            cbCommand.Connection = dataConnection;
            cbCommand.CommandText = "SELECT elemID, elemRow, elemColumn, elemSymbol, elemGroup, elemFullName, elemEnName, elemHeName, elemAtomicWeight, elemEnergyLevels FROM tblElements \n " + cmd + "\n ORDER BY elemAtomicWeight";
            OleDbDataReader cbReader = cbCommand.ExecuteReader();
            while (cbReader.Read())
            {
                object[] elemObj = new object[10];
                int len = cbReader.GetValues(elemObj);
                String[] elemStrArr = Array.ConvertAll(elemObj, x => x.ToString());
                lv.Items.Add(new ListViewItem(elemStrArr));
            }
            cbReader.Close();
        }
    }
}
