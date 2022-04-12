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
    public partial class FormRptElementsByCategory : Form
    {
        private OleDbConnection dataConnection;

        private Color lvColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        public FormRptElementsByCategory(OleDbConnection dataConnection)
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
            string strCols = "קטגוריה,תכונה,מספר זהות,שורה,טור,סימן,קבוצה,שם מלא,שם אנגלי,שם עברי,משקל אטומי,רמות אנרגיה";
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
            String cmd = " WHERE propertyCategory = '" + from + "'";
            AddFromDB(this.listView, cmd);
        }

        private void FillFromDB(ComboBox cb, String cmd)
        {
            cb.Items.Clear();
            OleDbCommand cbCommand = new OleDbCommand();
            cbCommand.Connection = dataConnection;
            String elemSelects = "categoryName";
            cbCommand.CommandText = "SELECT " + elemSelects + " FROM tblCategories \n " + cmd + "\n ORDER BY categoryName";
            OleDbDataReader cbReader = cbCommand.ExecuteReader();
            while (cbReader.Read())
            {
                object[] elemObj = new object[elemSelects.Split(',').Length];
                int len = cbReader.GetValues(elemObj);
                String cat = Convert.ToString(elemObj[0]);
                cb.Items.Add(cat);
            }
            cbReader.Close();
        }
        private void AddFromDB(ListView lv, String cmd)
        {
            OleDbCommand propCmd = new OleDbCommand();
            propCmd.Connection = dataConnection;
            String propSelects = "propertyName";
            propCmd.CommandText = "SELECT " + propSelects + " FROM tblProperties \n " + cmd + "\n ORDER BY propertyName";
            OleDbDataReader propReader = propCmd.ExecuteReader();
            bool firstProp = true;
            while (propReader.Read())
            {
                object[] propObj = new object[propSelects.Split(',').Length];
                propReader.GetValues(propObj);
                String prop = propObj[0].ToString();

                OleDbCommand pCmd = new OleDbCommand();
                pCmd.Connection = dataConnection;
                String pSelects = "propertyElement";
                pCmd.CommandText = "SELECT " + pSelects + " FROM tblPropertiesInElement \n WHERE propertyName = '" + prop + "'";
                OleDbDataReader pReader = pCmd.ExecuteReader();
                bool firstElem = true;
                while (pReader.Read())
                {
                    object[] pObj = new object[pSelects.Split(',').Length];
                    pReader.GetValues(pObj);
                    String symbol = pObj[0].ToString();

                    OleDbCommand lvCommand = new OleDbCommand();
                    lvCommand.Connection = dataConnection;
                    String elemSelects = "elemID,elemRow,elemColumn,elemSymbol,elemGroup,elemFullName,elemEnName,elemHeName,elemAtomicWeight,elemEnergyLevels";
                    lvCommand.CommandText = "SELECT " + elemSelects + " FROM tblElements \n " + "WHERE elemSymbol = '" + symbol + "'\n ORDER BY elemSymbol";
                    OleDbDataReader lvReader = lvCommand.ExecuteReader();
                    while (lvReader.Read())
                    {
                        object[] elemObj = new object[elemSelects.Split(',').Length];
                        int len = lvReader.GetValues(elemObj);
                        String[] elemStrArr = Array.ConvertAll(elemObj, x => x.ToString());
                        String[] itemArr;
                        String[] mainCols = {"", ""};
                        if (firstProp)
                        {
                            mainCols[0] = this.elemFrom.Text;
                            firstProp = false;
                        }
                        if (firstElem)
                        {
                            mainCols[1] = prop;
                            firstElem = false;
                        }
                        itemArr = mainCols.Concat(elemStrArr).ToArray();
                        ListViewItem item = new ListViewItem(itemArr);
                        item.ForeColor = lvColor;
                        lv.Items.Add(item);
                    }
                    lvReader.Close();
                }
                pReader.Close();
            }
            propReader.Close();
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
