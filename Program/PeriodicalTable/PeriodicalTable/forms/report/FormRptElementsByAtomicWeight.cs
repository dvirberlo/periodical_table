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
    public partial class FormRptElementsByAtomicWeight : Form
    {
        private DBManager db;

        private Color lvColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        public FormRptElementsByAtomicWeight(DBManager db)
        {
            this.db = db;
            InitializeComponent();
            this.Shown += Setup;
        }
        private void Setup(Object sender, EventArgs e)
        {
            FillFromDB(this.fromAtomic, "ORDER BY elemAtomicWeight");

            listView.Columns.Clear();
            string strCols = "ממשקל,עד משקל,מספר זהות,שורה,טור,סימן,קבוצה,שם מלא,שם אנגלי,שם עברי,משקל אטומי,רמות אנרגיה";
            string[] cols = strCols.Split(',');
            foreach (string col in cols)
            {
                int width;
                if (this.listView.Width / (cols.Length + 1) < 100)
                    width = 100;
                else
                    width = this.listView.Width / (cols.Length + 1);
                listView.Columns.Add(col, width, HorizontalAlignment.Left);
            }

        }

        private void FromAtoomicChanged(object sender, EventArgs e)
        {
            this.toAtomic.Enabled = true;
            this.addBtn.Enabled = true;
            String from = this.fromAtomic.Text;
            String cmd = " WHERE elemAtomicWeight >= " + from + "\n ORDER BY elemAtomicWeight";
            FillFromDB(this.toAtomic, cmd);
        }

        private void SearchBtnClick(object sender, EventArgs e)
        {
            String from = this.fromAtomic.Text;
            String to = this.toAtomic.Text;
            String cmd = " WHERE elemAtomicWeight >= " + from + " AND elemAtomicWeight <= " + to + "\n ORDER BY elemAtomicWeight";
            AddFromDB(this.listView, cmd);
        }

        private void FillFromDB(ComboBox cb, String cmd)
        {
            cb.Items.Clear();
            List<String> data = db.ListForCombo("tblElements", "elemAtomicWeight", cmd:cmd);
            if (data == null) return;
            foreach (String val in data)
            {
                double atomicWeight = Convert.ToDouble(val);
                cb.Items.Add(atomicWeight);
            }

            cb.Text = cb.Items[0].ToString();

        }
        private void AddFromDB(ListView lv, String cmd)
        {
            String elemSelects = "elemID,elemRow,elemColumn,elemSymbol,elemGroup,elemFullName,elemEnName,elemHeName,elemAtomicWeight,elemEnergyLevels";
            String[] addCols = { this.fromAtomic.Text, this.toAtomic.Text };
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
