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
using PeriodicalTable.backend;

namespace PeriodicalTable
{
    public partial class FormRptElementsByAtomicNum : Form
    {
        private OleDbConnection dataConnection;
        private DBManager db;

        private Color lvColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        public FormRptElementsByAtomicNum(DBManager db)
        {
            this.db = db;
            this.dataConnection = db.dataConnection;
            InitializeComponent();
            this.Shown += Setup;
        }
        private void Setup(Object sender, EventArgs e)
        {
            FillFromDB(this.elemFrom, "ORDER BY elemID");

            listView.Columns.Clear();
            //string strCols = "elemID,elemRow,elemColumn,elemSymbol,elemGroup,elemFullName,elemEnName,elemHeName,elemAtomicWeight,elemEnergyLevels";
            string strCols = "ממספר,עד מספר,מספר זהות,שורה,טור,סימן,קבוצה,שם מלא,שם אנגלי,שם עברי,משקל אטומי,רמות אנרגיה";
            string[] cols = strCols.Split(',');
            foreach (string col in cols)
            {
                int width;
                if (this.listView.Width / (cols.Length+1) < 100)
                    width = 100;
                else
                    width = this.listView.Width / (cols.Length+1);
                listView.Columns.Add(col, width, HorizontalAlignment.Left);
            }

        }

        private void FromAtoomicChanged(object sender, EventArgs e)
        {
            this.elemTo.Enabled = true;
            this.addBtn.Enabled = true;
            String from = this.elemFrom.Text;
            String cmd = " WHERE elemID >= " + from + "\n ORDER BY elemID";
            FillFromDB(this.elemTo, cmd);
        }

        private void SearchBtnClick(object sender, EventArgs e)
        {
            String from = this.elemFrom.Text;
            String to = this.elemTo.Text;
            String cmd = " WHERE elemID >= " + from + " AND elemID <= " + to + "\n ORDER BY elemID";
            AddFromDB(this.listView, cmd);
        }

        private void FillFromDB(ComboBox cb, String cmd)
        {
            cb.Items.Clear();
            List<String> data = db.ListForCombo("tblElements", "elemID", cmd: cmd);
            if (data == null) return;
            foreach (String val in data)
            {
                cb.Items.Add(val);
            }

            cb.Text = cb.Items[0].ToString();
        }
        private void AddFromDB(ListView lv, String cmd)
        {
            OleDbCommand lvCommand = new OleDbCommand();
            String elemSelects = "elemID,elemRow,elemColumn,elemSymbol,elemGroup,elemFullName,elemEnName,elemHeName,elemID,elemEnergyLevels";
            String[] addCols = { this.elemFrom.Text, this.elemTo.Text };
            Object[][] data = db.GetReport("tblElements", elemSelects, cmd, addCols);
            if (data == null) return;
            foreach (String[] row in data)
            {
                ListViewItem item = new ListViewItem(row);
                item.ForeColor = lvColor;
                lv.Items.Add(item);
            }
        }

        private void clearBtnClick(object sender, EventArgs e)
        {
            this.listView.Items.Clear();
        }

        private void colorBtnClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            colorBtn.ForeColor = cd.Color;
            lvColor = cd.Color;
        }
    }
}
