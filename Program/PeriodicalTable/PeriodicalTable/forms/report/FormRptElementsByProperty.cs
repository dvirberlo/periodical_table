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
    public partial class FormRptElementsByProperty : Form
    {
        private OleDbConnection dataConnection;

        private Color lvColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        public FormRptElementsByProperty(OleDbConnection dataConnection)
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
            string strCols = "ממספר,עד מספר,מספר זהות,שורה,טור,סימן,קבוצה,שם מלא,שם אנגלי,שם עברי,משקל אטומי,רמות אנרגיה";
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
            String cmd = " WHERE propertyName = '" + from + "' ";
            AddFromDB(this.listView, cmd);
        }

        private void FillFromDB(ComboBox cb, String cmd)
        {
            cb.Items.Clear();
            OleDbCommand cbCommand = new OleDbCommand();
            cbCommand.Connection = dataConnection;
            String elemSelects = "propertyName";
            cbCommand.CommandText = "SELECT " + elemSelects + " FROM tblPropertiesInElement \n " + cmd + "\n ORDER BY propertyName";
            OleDbDataReader cbReader = cbCommand.ExecuteReader();
            while (cbReader.Read())
            {
                object[] elemObj = new object[elemSelects.Split(',').Length];
                int len = cbReader.GetValues(elemObj);
                String index = Convert.ToString(elemObj[0]);
                cb.Items.Add(index);
            }
            cbReader.Close();

            cb.Text = cb.Items[0].ToString();
        }
        private void AddFromDB(ListView lv, String cmd)
        {
            OleDbCommand lvCommand = new OleDbCommand();
            lvCommand.Connection = dataConnection;
            String propSelects = "propertyElement";
            lvCommand.CommandText = "SELECT " + propSelects + " FROM tblPropertiesInElement \n " + cmd;
            OleDbDataReader lvReader = lvCommand.ExecuteReader();
            bool first = true;
            while (lvReader.Read())
            {
                object[] propObj = new object[propSelects.Split(',').Length];
                lvReader.GetValues(propObj);
                String index = Convert.ToString(propObj[0]);


                OleDbCommand elemCommand = new OleDbCommand();
                elemCommand.Connection = dataConnection;
                String elemSelects = "elemID,elemRow,elemColumn,elemSymbol,elemGroup,elemFullName,elemEnName,elemHeName,elemID,elemEnergyLevels";
                elemCommand.CommandText = "SELECT " + elemSelects + " FROM tblElements \n " + " WHERE elemSymbol =  '" + index + "' " + "\n ORDER BY elemGroup";
                OleDbDataReader elemReader = elemCommand.ExecuteReader();
                while (elemReader.Read())
                {
                    object[] elemObj = new object[elemSelects.Split(',').Length];
                    int len = elemReader.GetValues(elemObj);
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
                elemReader.Close();
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
