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
    public partial class FormRptElementsByGroup : Form
    {
        private OleDbConnection dataConnection;

        private Color lvColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        public FormRptElementsByGroup(OleDbConnection dataConnection)
        {
            this.dataConnection = dataConnection;
            InitializeComponent();
            this.Shown += Setup;
        }
        private void Setup(Object sender, EventArgs e)
        {
            FillFromDB(this.elemFrom, "");

            listView.Columns.Clear();
            //string strCols = "elemID,elemRow,elemColumn,elemSymbol,elemGroup,elemFullName,elemEnName,elemHeName,elemAtomicWeight,elemEnergyLevels";
            string strCols = "קבוצה,מספר זהות,שורה,טור,סימן,שם מלא,שם אנגלי,שם עברי,משקל אטומי,רמות אנרגיה";
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
            this.addBtn.Enabled = true;
        }

        private void SearchBtnClick(object sender, EventArgs e)
        {
            String from = this.elemFrom.Text;
            String cmd = " WHERE elemGroup = '" + from + "'";
            AddFromDB(this.listView, cmd);
        }

        private void FillFromDB(ComboBox cb, String cmd)
        {
            cb.Items.Clear();
            OleDbCommand cbCommand = new OleDbCommand();
            cbCommand.Connection = dataConnection;
            String elemSelects = "groupName";
            cbCommand.CommandText = "SELECT " + elemSelects + " FROM tblGroups \n " + cmd + "\n ORDER BY groupName";
            OleDbDataReader cbReader = cbCommand.ExecuteReader();
            while (cbReader.Read())
            {
                object[] elemObj = new object[elemSelects.Split(',').Length];
                int len = cbReader.GetValues(elemObj);
                String group = Convert.ToString(elemObj[0]);
                cb.Items.Add(group);
            }
            cbReader.Close();
            cb.SelectedText = cb.Items[0].ToString();

        }
        private void AddFromDB(ListView lv, String cmd)
        {
            OleDbCommand lvCommand = new OleDbCommand();
            lvCommand.Connection = dataConnection;
            String elemSelects = "elemID,elemRow,elemColumn,elemSymbol,elemFullName,elemEnName,elemHeName,elemID,elemEnergyLevels";
            lvCommand.CommandText = "SELECT " + elemSelects + " FROM tblElements \n " + cmd + "\n ORDER BY elemGroup";
            OleDbDataReader lvReader = lvCommand.ExecuteReader();
            bool first = true;
            while (lvReader.Read())
            {
                object[] elemObj = new object[elemSelects.Split(',').Length];
                int len = lvReader.GetValues(elemObj);
                String[] elemStrArr = Array.ConvertAll(elemObj, x => x.ToString());
                String[] itemArr;
                if (first)
                {
                    String[] mainCols = { this.elemFrom.Text };
                    itemArr = mainCols.Concat(elemStrArr).ToArray();
                    first = false;
                }
                else
                {
                    String[] mainCols = { "" };
                    itemArr = mainCols.Concat(elemStrArr).ToArray();
                }
                ListViewItem item = new ListViewItem(itemArr);
                item.ForeColor = lvColor;
                lv.Items.Add(item);
            }
            lvReader.Close();
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
