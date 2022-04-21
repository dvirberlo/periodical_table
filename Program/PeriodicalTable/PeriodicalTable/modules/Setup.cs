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

namespace PeriodicalTable.modules
{
    class Setup
    {
        public static void ListView(ListView lv, String cols)
        {
            lv.Columns.Clear();
            string[] colsArr = cols.Split(',');
            foreach (string col in colsArr)
            {
                int width;
                if (lv.Width / (colsArr.Length + 1) < 100)
                    width = 100;
                else
                    width = lv.Width / (colsArr.Length + 1);
                lv.Columns.Add(col, width, HorizontalAlignment.Left);
            }
        }
        public static void FromToRpt(ListView lv, ComboBox from, ComboBox to, Button submit, Button clear, Button color, DBManager db, String table, String col, String cols, String[] addCols, Color def)
        {
            Color lvColor = def;
            from.Enabled = true;
            to.Enabled = false;
            submit.Enabled = false;

            from.TextChanged += (Object sender, EventArgs e) => {
                to.Enabled = true;
                submit.Enabled = true;
                String cmd = " WHERE elemAtomicWeight >= " + from.Text + "\n ORDER BY elemAtomicWeight";
                FillFromDB(to, cmd, db, table, col);
            };
            submit.Click += (Object sender, EventArgs e) => {
                String cmd = " WHERE elemAtomicWeight >= " + from.Text + " AND elemAtomicWeight <= " + to.Text + "\n ORDER BY elemAtomicWeight";
                AddFromDB(lv, cmd, cols, addCols, lvColor, db);
            };
            color.Click += (Object sender, EventArgs e) =>
            {
                ColorDialog cd = new ColorDialog();
                cd.ShowDialog();
                color.ForeColor = cd.Color;
                lvColor = cd.Color;
            };
            Clear(lv, clear);

            FillFromDB(from, "ORDER BY " + col, db, table, col);

        }
        public static void Clear(ListView lv, Button clear)
        {
            clear.Click += (Object sender, EventArgs e) => lv.Items.Clear();
        }
        public static void FillFromDB(ComboBox cb, String cmd, DBManager db, String table, String col)
        {
            cb.Items.Clear();
            List<String> data = db.ListForCombo(table, col, cmd: cmd);
            if (data == null) return;
            foreach (String val in data)
            {
                cb.Items.Add(val);
            }

            cb.Text = cb.Items[0].ToString();
        }
        public static void AddFromDB(ListView lv, String cmd, String cols, String[] addCols, Color lvColor, DBManager db)
        {
            Object[][] data = db.GetReport("tblElements", cols, cmd, addCols);
            if (data == null) return;
            foreach (String[] row in data)
            {
                ListViewItem item = new ListViewItem(row);
                item.ForeColor = lvColor;
                lv.Items.Add(item);
            }
        }
    }
}
