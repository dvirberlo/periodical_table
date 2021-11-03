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
    public partial class FormChartElementsByProperty : Form
    {
        private OleDbConnection dataConnection;

        public FormChartElementsByProperty(OleDbConnection dataConnection)
        {
            this.dataConnection = dataConnection;
            InitializeComponent();
            this.Shown += Setup;
        }
        private void Setup(Object sender, EventArgs e)
        {
            String countStr = "כמות היסודות";

            // dataGridView
            string strCols = "תכונה,כמות היסודות";
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
            dataCmd.CommandText = "SELECT "+col+" FROM tblProperties ";
            OleDbDataReader dataReader = dataCmd.ExecuteReader();
            while (dataReader.Read())
            {
                object[] obj = new object[1];
                dataReader.GetValues(obj);
                String propN = obj[0].ToString();
                String cmd = col + " = '" + propN + "' ";
                AppendFromDB(col, cmd, this.dataGridView1, this.chart1, countStr, propN);
            }
            dataReader.Close();
        }


        private void AppendFromDB(String col, String cmd, DataGridView dgv, Chart chart, String countStr, String str)
        {
            OleDbCommand dataCmd = new OleDbCommand();
            dataCmd.Connection = dataConnection;
            dataCmd.CommandText = "SELECT COUNT(" + col + ") FROM tblPropertiesInElement \n WHERE " + cmd;
            OleDbDataReader dataReader = dataCmd.ExecuteReader();
            while (dataReader.Read())
            {
                object[] obj = new object[col.Split(',').Length];
                dataReader.GetValues(obj);
                int count = Convert.ToInt32(obj[0]);

                chart1.Series[countStr].Points.AddXY(str, count);
                dgv.Rows.Add(new string[]{str, count.ToString()});
            }
            dataReader.Close();
        }
    }
}
