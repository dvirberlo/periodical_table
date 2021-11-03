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
using System.Windows.Forms.DataVisualization.Charting;

namespace PeriodicalTable
{
    public partial class FormChartElementsByCategory : Form
    {
        private OleDbConnection dataConnection;

        public FormChartElementsByCategory(OleDbConnection dataConnection)
        {
            this.dataConnection = dataConnection;
            InitializeComponent();
            this.Shown += Setup;
        }
        private void Setup(Object sender, EventArgs e)
        {
            String countStr = "כמות היסודות";

            // dataGridView
            string strCols = "קטגוריה,כמות היסודות";
            string[] cols = strCols.Split(',');
            foreach (string gCol in cols)
            {
                this.dataGridView1.Columns.Add("col_"+gCol, gCol);
            }
            // chart
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.Series.Clear();
            chart1.Series.Add(countStr);

            // load database:
            String col = "propertyName";

            OleDbCommand dataCmd = new OleDbCommand();
            dataCmd.Connection = dataConnection;
            dataCmd.CommandText = "SELECT categoryName FROM tblCategories ";
            OleDbDataReader dataReader = dataCmd.ExecuteReader();
            while (dataReader.Read())
            {
                object[] obj = new object[1];
                dataReader.GetValues(obj);
                String catN = obj[0].ToString();
                String cmd = "propertyCategory = '" + catN + "' ";
                AppendFromDB(col, cmd, this.dataGridView1, this.chart1, countStr, catN);
            }
            dataReader.Close();
        }


        private void AppendFromDB(String col, String cmd, DataGridView dgv, Chart chart, String countStr, String str)
        {
            int count = 0;

            OleDbCommand dataCmd = new OleDbCommand();
            dataCmd.Connection = dataConnection;
            dataCmd.CommandText = "SELECT " + col + " FROM tblProperties \n WHERE " + cmd;
            OleDbDataReader dataReader = dataCmd.ExecuteReader();
            while (dataReader.Read())
            {

                object[] obj = new object[1];
                dataReader.GetValues(obj);
                String propN = obj[0].ToString();

                String cmd2 = col + " = '" + propN + "' ";
                OleDbCommand dataCmd2 = new OleDbCommand();
                dataCmd2.Connection = dataConnection;
                dataCmd2.CommandText = "SELECT COUNT(" + col + ") FROM tblPropertiesInElement \n WHERE " + cmd2;
                OleDbDataReader dataReader2 = dataCmd2.ExecuteReader();
                while (dataReader2.Read())
                {
                    object[] obj2 = new object[col.Split(',').Length];
                    dataReader2.GetValues(obj2);
                    int c = Convert.ToInt32(obj2[0]);
                    count += c;
                    
                }
                dataReader2.Close();
            }
            dataReader.Close();

            chart1.Series[countStr].Points.AddXY(str, count);
            dgv.Rows.Add(new string[] { str, count.ToString() });
        }
    }
}
