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
    public partial class FormChartElementsByAtomicNum : Form
    {
        private OleDbConnection dataConnection;

        public FormChartElementsByAtomicNum(OleDbConnection dataConnection)
        {
            this.dataConnection = dataConnection;
            InitializeComponent();
            this.Shown += Setup;
        }
        private void Setup(Object sender, EventArgs e)
        {
            String countStr = "כמות היסודות";

            // dataGridView
            string strCols = "טווח,כמות היסודות";
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
            String col = "elemID";
            int min = int.MaxValue, max = int.MinValue, step = 10;


            OleDbCommand dataCmd = new OleDbCommand();
            dataCmd.Connection = dataConnection;
            dataCmd.CommandText = "SELECT MIN(" + col + ")" + " FROM tblElements ";
            OleDbDataReader dataReader = dataCmd.ExecuteReader();
            if (dataReader.Read())
            {
                object[] obj = new object[1];
                dataReader.GetValues(obj);
                min = Convert.ToInt32(obj[0]);
            }
            dataReader.Close();
            OleDbCommand dataCmd2 = new OleDbCommand();
            dataCmd2.Connection = dataConnection;
            dataCmd2.CommandText = "SELECT Max(" + col + ")" + " FROM tblElements ";
            OleDbDataReader dataReader2 = dataCmd2.ExecuteReader();
            if (dataReader2.Read())
            {
                object[] obj = new object[1];
                dataReader2.GetValues(obj);
                max = Convert.ToInt32(obj[0]);
            }
            dataReader2.Close();

            for (int i = 0; i < 1 + (max - min - 1) / step; i++)
            {
                double from = (min + step * i), to = (min + step * (i+1));
                String cmd = col + " >= " + from.ToString() + " AND " + col + " < " + to.ToString();

                String str = (min + step * i).ToString() + " - " + (min + step * (i+1)).ToString();
                AppendFromDB(col, cmd, this.dataGridView1, this.chart1, countStr, str);
            }
        }


        private void AppendFromDB(String col,String cmd, DataGridView dgv, Chart chart, String countStr, String str)
        {
            OleDbCommand dataCmd = new OleDbCommand();
            dataCmd.Connection = dataConnection;
            dataCmd.CommandText = "SELECT COUNT(" + col + ") FROM tblElements \n WHERE " + cmd;
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
