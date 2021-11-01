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
    public partial class FormChartElementsByAtomicWeight : Form
    {
        private OleDbConnection dataConnection;

        private Color lvColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        public FormChartElementsByAtomicWeight(OleDbConnection dataConnection)
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
            chart1.Series.Clear();
            chart1.Series.Add(countStr);


            // load database:
            String col = "elemAtomicWeight";
            double min = Double.MaxValue, max = Double.MinValue, step = 50.0;


            OleDbCommand dataCmd = new OleDbCommand();
            dataCmd.Connection = dataConnection;
            dataCmd.CommandText = "SELECT MIN(" + col + ")" + " FROM tblElements ";
            OleDbDataReader dataReader = dataCmd.ExecuteReader();
            if (dataReader.Read())
            {
                object[] obj = new object[1];
                dataReader.GetValues(obj);
                min = Convert.ToDouble(obj[0]);
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
                max = Convert.ToDouble(obj[0]);
            }
            dataReader2.Close();

            for (double i = 0; i < max / step; i++)
            {
                double from = (min + step * i), to = (min + step * (i+1));
                String cmd = col + " >= " + from.ToString() + " AND " + col + " < " + to.ToString();

                int starter = (int)Math.Floor(min) - ((int)Math.Floor(min) - (int)Math.Floor(min) / (int)Math.Floor(step));

                String str = (starter + (int)Math.Floor(step) * i).ToString() + " - " + (starter + (int)Math.Floor(step) * (i+1)).ToString();
                AppendFromDB(this.dataGridView1, this.chart1, countStr, str, from, to);
            }
        }


        private void AppendFromDB(DataGridView dgv, Chart chart, String countStr, String str, double from, double to)
        {
            String col = "elemAtomicWeight";
            String cmd = col.ToString() + " >= " + from.ToString() + " AND " + col + " < " + to;
            
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
