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
            //string strCols = "elemID,elemRow,elemColumn,elemSymbol,elemGroup,elemFullName,elemEnName,elemHeName,elemAtomicWeight,elemEnergyLevels";
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
            String elemSelects = "elemAtomicWeight";
            cbCommand.CommandText = "SELECT " + elemSelects + " FROM tblElements \n " + cmd + "\n ORDER BY elemAtomicWeight";
            OleDbDataReader cbReader = cbCommand.ExecuteReader();
            while (cbReader.Read())
            {
                object[] elemObj = new object[elemSelects.Split(',').Length];
                int len = cbReader.GetValues(elemObj);
                double atomicWeight = Convert.ToDouble(elemObj[0]);
                cb.Items.Add(atomicWeight);
            }
            cbReader.Close();
        }
        private void FillFromDB(ListView lv, String cmd)
        {
            lv.Items.Clear();
            OleDbCommand lvCommand = new OleDbCommand();
            lvCommand.Connection = dataConnection;
            String elemSelects = "elemID,elemRow,elemColumn,elemSymbol,elemGroup,elemFullName,elemEnName,elemHeName,elemAtomicWeight,elemEnergyLevels";
            lvCommand.CommandText = "SELECT " + elemSelects + " FROM tblElements \n " + cmd + "\n ORDER BY elemAtomicWeight";
            OleDbDataReader lvReader = lvCommand.ExecuteReader();
            while (lvReader.Read())
            {
                object[] elemObj = new object[elemSelects.Split(',').Length];
                int len = lvReader.GetValues(elemObj);
                String[] elemStrArr = Array.ConvertAll(elemObj, x => x.ToString());
                lv.Items.Add(new ListViewItem(elemStrArr));
            }
            lvReader.Close();
        }
    }
}
